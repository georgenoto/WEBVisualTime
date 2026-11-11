using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using WEBVisualTime.Entidades.ReplicaBeneficios;
using static WEBVisualTime.Datos.ReplicaBeneficios.BeneficioSql;

namespace WEBVisualTime.Datos.ReplicaBeneficios;

public sealed class OracleReplicaBeneficiosStore(AppDbContext db, ILogger<OracleReplicaBeneficiosStore> logger) : IReplicaBeneficiosStore
{
    async Task<OracleConnection> Open(CancellationToken ct)
    {
        var c = new OracleConnection(db.Database.GetConnectionString());
        try { await c.OpenAsync(ct); return c; } catch { c.Dispose(); throw; }
    }
    static OracleCommand Cmd(OracleConnection c, string sql, params (string, object?)[] args)
    {
        var cmd = c.CreateCommand(); cmd.BindByName = true; cmd.CommandText = sql; cmd.CommandTimeout = 120;
        foreach (var (name, value) in args)
        {
            // Only bind parameters used by this statement (ODP.NET rejects extras).
            if (!System.Text.RegularExpressions.Regex.IsMatch(sql, ":" + name + @"\b")) continue;
            var p = cmd.Parameters.Add(name, value switch { int or long => OracleDbType.Int64, DateTime => OracleDbType.Date, string s when s.Length > 3500 => OracleDbType.Clob, _ => OracleDbType.Varchar2 });
            p.Value = value ?? DBNull.Value;
        }
        return cmd;
    }
    static async Task<int> Exec(OracleConnection c, string sql, CancellationToken ct, params (string, object?)[] a)
    { using var cmd = Cmd(c, sql, a); return await cmd.ExecuteNonQueryAsync(ct); }
    static async Task<long> Number(OracleConnection c, string sql, CancellationToken ct, params (string, object?)[] a)
    { using var cmd = Cmd(c, sql, a); return Convert.ToInt64(await cmd.ExecuteScalarAsync(ct)); }
    static Task<int> Event(OracleConnection c, string id, string action, string detail, CancellationToken ct) =>
        Exec(c, "INSERT INTO INSUDB.TEMP_VT_BEN_EVENTO(EVENTO_ID,ID,FECHA,ACCION,DETALLE) VALUES(:eventId,:id,SYSDATE,:action,:detail)", ct,
            ("eventId", Guid.NewGuid().ToString("N")), ("id", id), ("action", action), ("detail", detail));
    static void CheckId(string id) { if (!Guid.TryParseExact(id, "N", out _)) throw new ArgumentException("Identificador inválido."); }
    static (string, object?)[] Args(string id, BeneficioPlan p) => [("id", id), ("ramo", p.Ramo), ("producto", p.Producto), ("base", p.Base), ("usuario", p.Usuario)];
    async Task<List<BeneficioOpcion>> Options(string sql, CancellationToken ct, params (string, object?)[] a)
    {
        using var c = await Open(ct); using var cmd = Cmd(c, sql, a); using var r = await cmd.ExecuteReaderAsync(ct);
        var result = new List<BeneficioOpcion>();
        while (await r.ReadAsync(ct)) result.Add(new(Convert.ToInt32(r.GetValue(0)), r.IsDBNull(1) ? "" : r.GetString(1)));
        return result;
    }
    public Task<List<BeneficioOpcion>> ProductosAsync(CancellationToken ct) => Options("SELECT NPRODUCT,MAX(TRIM(SDESCRIPT)) FROM INSUDB.PRODMASTER WHERE NBRANCH=5 GROUP BY NPRODUCT ORDER BY NPRODUCT", ct);
    public Task<List<BeneficioOpcion>> ModulosAsync(int producto, CancellationToken ct) => Options("SELECT NMODULEC,MAX(TRIM(SDESCRIPT)) FROM INSUDB.TAB_MODUL WHERE NBRANCH=5 AND NPRODUCT=:producto GROUP BY NMODULEC ORDER BY NMODULEC", ct, ("producto", producto));
    public async Task<List<string>> RecientesAsync(CancellationToken ct)
    {
        using var c = await Open(ct); using var cmd = Cmd(c, $"SELECT ID FROM {Jobs} ORDER BY CREADO DESC FETCH FIRST 30 ROWS ONLY");
        using var r = await cmd.ExecuteReaderAsync(ct); var ids = new List<string>(); while (await r.ReadAsync(ct)) ids.Add(r.GetString(0)); return ids;
    }
    static async Task Validate(OracleConnection c, BeneficioPlan p, CancellationToken ct)
    {
        p.Validar(); var a = Args("", p);
        if (await Number(c, "SELECT COUNT(*) FROM INSUDB.PRODMASTER WHERE NBRANCH=:ramo AND NPRODUCT=:producto", ct, a) == 0 ||
            await Number(c, "SELECT COUNT(*) FROM INSUDB.USERS WHERE NUSERCODE=:usuario", ct, a) != 1)
            throw new ArgumentException("Producto o usuario Oracle inexistente.");
        foreach (var modulo in p.Destinos.Append(p.Base))
            if (await Number(c, "SELECT COUNT(*) FROM INSUDB.TAB_MODUL WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC=:m", ct, [..a, ("m", modulo)]) == 0)
                throw new ArgumentException($"El módulo {modulo} no pertenece al producto.");
        // Set comparison relies on unique business keys and scalar columns.
        var keys = new Dictionary<string, HashSet<string>>();
        using (var cmd = Cmd(c, "SELECT c.CONSTRAINT_NAME,k.COLUMN_NAME FROM ALL_CONSTRAINTS c JOIN ALL_CONS_COLUMNS k ON k.OWNER=c.OWNER AND k.CONSTRAINT_NAME=c.CONSTRAINT_NAME WHERE c.OWNER='INSUDB' AND c.TABLE_NAME='MEDBENEFITS_PROD' AND c.CONSTRAINT_TYPE IN ('P','U') AND c.STATUS='ENABLED' AND c.VALIDATED='VALIDATED'"))
        using (var r = await cmd.ExecuteReaderAsync(ct))
            while (await r.ReadAsync(ct)) { if (!keys.ContainsKey(r.GetString(0))) keys[r.GetString(0)] = []; keys[r.GetString(0)].Add(r.GetString(1)); }
        if (!keys.Values.Any(k => k.SetEquals(new[] { "NBRANCH", "NPRODUCT", "NMODULEC", "DEFFECDATE", "NCOVER", "NIDMEDBENEF" })))
            throw new ArgumentException("El DBA debe verificar la clave única de seis campos de MEDBENEFITS_PROD antes de habilitar la réplica.");
        using var meta = Cmd(c, "SELECT COLUMN_NAME,DATA_TYPE FROM ALL_TAB_COLUMNS WHERE OWNER='INSUDB' AND TABLE_NAME='MEDBENEFITS_PROD'");
        using var mr = await meta.ExecuteReaderAsync(ct); var types = new Dictionary<string, string>();
        while (await mr.ReadAsync(ct)) types[mr.GetString(0)] = mr.GetString(1);
        if (Columns.Split(',').Any(col => !types.TryGetValue(col, out var t) || t is not ("NUMBER" or "DATE" or "VARCHAR2" or "CHAR" or "NVARCHAR2" or "NCHAR")))
            throw new ArgumentException("Columnas de beneficios incompatibles con la réplica. Revise tipos Oracle y posibles LOB con el DBA.");
    }
    public async Task<string> CrearAsync(BeneficioPlan plan, CancellationToken ct)
    {
        plan.Validar(); plan = plan with { Destinos = plan.Destinos.Order().ToArray() };
        using var c = await Open(ct); using var tx = c.BeginTransaction(); await Validate(c, plan, ct);
        var id = Guid.NewGuid().ToString("N"); var a = Args(id, plan);
        await Exec(c, $"LOCK TABLE {Target} IN SHARE ROW EXCLUSIVE MODE NOWAIT", ct);
        await Exec(c, $"INSERT INTO {Jobs}(ID,PLAN,REVISION,ESTADO,CREADO,FECHA_COPIA) VALUES(:id,:plan,:rev,'REVISADO',SYSDATE,SYSDATE)", ct,
            ("id", id), ("plan", JsonSerializer.Serialize(plan)), ("rev", Convert.ToHexString(RandomNumberGenerator.GetBytes(32))));
        for (var index = 0; index < plan.Destinos.Length; index++)
            await Exec(c, $"INSERT INTO {Dest}(ID,NMODULEC,ORDEN,ANTERIORES) SELECT :id,:m,:orden,COUNT(*) FROM {Target} WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC=:m", ct, [..a, ("m", plan.Destinos[index]), ("orden", index + 1)]);
        var n = await Exec(c, $"INSERT INTO {Snapshot}(ID,TIPO,ITEM_NO,{Columns}) SELECT :id,'BASE',ROW_NUMBER() OVER(ORDER BY DEFFECDATE,NCOVER,NIDMEDBENEF),{Columns} FROM {Target} WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC=:base", ct, a);
        if (n == 0) throw new ArgumentException("El módulo base no tiene beneficios para copiar.");
        await Exec(c, $"INSERT INTO {Snapshot}(ID,TIPO,ITEM_NO,{Columns}) SELECT :id,'ANTES',ROW_NUMBER() OVER(ORDER BY NMODULEC,DEFFECDATE,NCOVER,NIDMEDBENEF),{Columns} FROM {Target} WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC IN (SELECT NMODULEC FROM {Dest} WHERE ID=:id)", ct, a);
        await Exec(c, $"UPDATE {Jobs} SET BASE_FILAS=:n,TOTAL=:total WHERE ID=:id", ct, ("id", id), ("n", n), ("total", checked((long)n * plan.Destinos.Length)));
        await Event(c, id, "REVISADO", $"Base: {n}; destinos: {plan.Destinos.Length}. Reglas v1: copia íntegra, reemplazo de selección.", ct);
        tx.Commit(); return id;
    }
    public async Task<BeneficioEstado> EstadoAsync(string id, CancellationToken ct)
    {
        CheckId(id); using var c = await Open(ct);
        BeneficioEstado state;
        using (var cmd = Cmd(c, $"SELECT ESTADO,PLAN,BASE_FILAS,TOTAL,PREPARADOS,ELIMINADOS,ERROR,REVISION FROM {Jobs} WHERE ID=:id", ("id", id)))
        using (var r = await cmd.ExecuteReaderAsync(ct))
        {
            if (!await r.ReadAsync(ct)) throw new ArgumentException("Operación inexistente.");
            state = new(id, r.GetString(0), JsonSerializer.Deserialize<BeneficioPlan>(r.GetString(1))!, Convert.ToInt64(r.GetValue(2)), Convert.ToInt64(r.GetValue(3)), Convert.ToInt64(r.GetValue(4)), Convert.ToInt64(r.GetValue(5)), r.IsDBNull(6) ? null : r.GetString(6), r.GetString(7), []);
        }
        using var d = Cmd(c, $"SELECT NMODULEC,ANTERIORES FROM {Dest} WHERE ID=:id ORDER BY NMODULEC", ("id", id)); using var dr = await d.ExecuteReaderAsync(ct);
        while (await dr.ReadAsync(ct)) state.Destinos.Add(new(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt64(dr.GetValue(1)))); return state;
    }
    public async Task AccionAsync(string id, string accion, string? revision, CancellationToken ct)
    {
        CheckId(id); using var c = await Open(ct); using var tx = c.BeginTransaction();
        using var cmd = Cmd(c, $"SELECT ESTADO,REVISION FROM {Jobs} WHERE ID=:id FOR UPDATE NOWAIT", ("id", id));
        string state, rev; using (var r = await cmd.ExecuteReaderAsync(ct)) { if (!await r.ReadAsync(ct)) throw new ArgumentException("Operación inexistente."); state = r.GetString(0); rev = r.GetString(1); }
        var next = accion switch
        {
            "ejecutar" when state == "REVISADO" && revision == rev => "EN_COLA",
            "pausar" when state is "EN_COLA" or "PREPARANDO" => "PAUSADO",
            "reanudar" when state is "ERROR" or "PAUSADO" => "EN_COLA",
            "restaurar" when state == "COMPLETADO" && revision == rev => "RESTAURAR",
            "reintentarRestauracion" when state == "ERROR_RESTAURAR" => "RESTAURAR",
            _ => throw new ArgumentException("La acción no corresponde al estado actual o cambió la revisión. Recargue la operación.")
        };
        await Exec(c, $"UPDATE {Jobs} SET ESTADO=:s,ERROR=NULL WHERE ID=:id", ct, ("id", id), ("s", next));
        await Event(c, id, accion, $"{state} → {next}", ct); tx.Commit();
    }
    static async Task Equal(OracleConnection c, string left, string right, CancellationToken ct, (string, object?)[] a)
    {
        // Compare multiplicity as well as values, including nullable unique keys.
        left = $"SELECT {Columns},COUNT(*) REPETICIONES FROM ({left}) GROUP BY {Columns}";
        right = $"SELECT {Columns},COUNT(*) REPETICIONES FROM ({right}) GROUP BY {Columns}";
        if (await Number(c, $"SELECT COUNT(*) FROM ({left})", ct, a) != await Number(c, $"SELECT COUNT(*) FROM ({right})", ct, a) ||
            await Number(c, Difference(left, right), ct, a) != 0 || await Number(c, Difference(right, left), ct, a) != 0)
            throw new ArgumentException("La configuración cambió o el contenido no coincide. No se modificaron los destinos; cree una nueva revisión si hubo cambios externos.");
    }
    static async Task Publish(OracleConnection c, BeneficioEstado s, bool restore, CancellationToken ct)
    {
        var a = Args(s.Id, s.Plan); await Validate(c, s.Plan, ct);
        await Exec(c, $"LOCK TABLE {Target} IN SHARE ROW EXCLUSIVE MODE NOWAIT", ct);
        var before = $"SELECT {Columns} FROM {Snapshot} WHERE ID=:id AND TIPO='ANTES'";
        var staged = $"SELECT {Columns} FROM {Stage} WHERE ID=:id";
        await Equal(c, Selected, restore ? staged : before, ct, a);
        if (!restore)
        {
            await Equal(c, $"SELECT {Columns} FROM {Target} WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC=:base", $"SELECT {Columns} FROM {Snapshot} WHERE ID=:id AND TIPO='BASE'", ct, a);
            if (await Number(c, $"SELECT COUNT(*) FROM {Stage} WHERE ID=:id", ct, a) != s.Total) throw new ArgumentException("Preparación incompleta.");
        }
        var deleted = await Exec(c, Delete, ct, a);
        await Exec(c, Insert(restore ? Snapshot : Stage, restore ? "AND TIPO='ANTES'" : ""), ct, a);
        await Equal(c, Selected, restore ? before : staged, ct, a);
        await Exec(c, $"UPDATE {Jobs} SET ESTADO=:state,ELIMINADOS=:n,ERROR=NULL WHERE ID=:id", ct, [..a, ("state", restore ? "RESTAURADO" : "COMPLETADO"), ("n", restore ? s.Eliminados : deleted)]);
        await Event(c, s.Id, restore ? "RESTAURADO" : "COMPLETADO", $"Transacción completa. Filas eliminadas en esta operación: {deleted}.", ct);
    }
    public async Task<bool> ProcesarAsync(CancellationToken ct)
    {
        using var c = await Open(ct); var ids = new List<string>();
        using (var cmd = Cmd(c, $"SELECT ID FROM {Jobs} WHERE ESTADO IN ('EN_COLA','PREPARANDO','RESTAURAR') ORDER BY CREADO FETCH FIRST 20 ROWS ONLY"))
        using (var r = await cmd.ExecuteReaderAsync(ct)) while (await r.ReadAsync(ct)) ids.Add(r.GetString(0));
        foreach (var id in ids)
        {
            var restore = false; var phase = "Consulta de avance"; using var tx = c.BeginTransaction();
            try
            {
                using (var cmd = Cmd(c, $"SELECT ESTADO FROM {Jobs} WHERE ID=:id AND ESTADO IN ('EN_COLA','PREPARANDO','RESTAURAR') FOR UPDATE NOWAIT", ("id", id)))
                { var value = await cmd.ExecuteScalarAsync(ct); if (value is null) { tx.Rollback(); continue; } restore = value.ToString() == "RESTAURAR"; }
                var s = await EstadoAsync(id, ct); var a = Args(id, s.Plan);
                phase = restore ? "Restauración" : s.Preparados == s.Total ? "Publicación final" : $"Segmento {s.Preparados / 1000 + 1}, desde item {s.Preparados + 1}";
                if (restore || s.Preparados == s.Total) await Publish(c, s, restore, ct);
                else
                {
                    var end = Math.Min(s.Total, s.Preparados + 1000);
                    var inserted = await Exec(c, Prepare, ct, [..a, ("startNo", s.Preparados), ("endNo", end)]);
                    if (inserted != end - s.Preparados) throw new ArgumentException("Cantidad inesperada al preparar el segmento.");
                    await Exec(c, $"UPDATE {Jobs} SET PREPARADOS=:n,ESTADO='PREPARANDO' WHERE ID=:id", ct, ("id", id), ("n", end));
                    await Event(c, id, "SEGMENTO", $"Segmento {s.Preparados / 1000 + 1}: items {s.Preparados + 1}–{end}; {inserted} filas.", ct);
                }
                tx.Commit(); return true;
            }
            catch (OracleException ex) when (ex.Number == 54) { tx.Rollback(); }
            catch (OperationCanceledException) { try { tx.Rollback(); } catch { } throw; }
            catch (Exception ex)
            {
                logger.LogError(ex, "Réplica beneficios {Id}", id);
                try { tx.Rollback(); } catch { /* Connection may have died during commit. Reconcile on a new connection. */ }
                using var recovery = await Open(ct);
                var reason = ex is ArgumentException ? ex.Message : ex is OracleException oe ? $"Error Oracle ORA-{oe.Number:D5}. Consulte soporte con el identificador de operación." : "Error de ejecución. Consulte soporte con el identificador de operación.";
                var message = phase + ": " + reason;
                // Conditional UPDATE also waits for an unresolved server transaction; never overwrite a committed result.
                using var recoveryTx = recovery.BeginTransaction();
                var changed = await Exec(recovery, $"UPDATE {Jobs} SET ESTADO=:s,ERROR=:error WHERE ID=:id AND ESTADO IN ('EN_COLA','PREPARANDO','RESTAURAR')", ct,
                    ("id", id), ("s", restore ? "ERROR_RESTAURAR" : "ERROR"), ("error", message));
                if (changed == 1) await Event(recovery, id, "ERROR", message, ct);
                recoveryTx.Commit(); return true;
            }
        }
        return false;
    }
}
