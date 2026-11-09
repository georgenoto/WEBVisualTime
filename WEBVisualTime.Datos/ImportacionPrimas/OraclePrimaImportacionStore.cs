using System.Text.Json;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using WEBVisualTime.Entidades.ImportacionPrimas;

namespace WEBVisualTime.Datos.ImportacionPrimas;

public sealed class OraclePrimaImportacionStore(AppDbContext db, ILogger<OraclePrimaImportacionStore> logger) : IPrimaImportacionStore
{
    const string Jobs = "INSUDB.TEMP_VT_PRIMA_IMPORT";
    const string Stage = "INSUDB.TEMP_VT_PRIMA_STAGE";
    public const string Columns = "NBRANCH,NPRODUCT,DEFFECDATE,NROLE,NMODULEC,NCOVER,NGEOGRAPHAREA,NATTENSYSTEM,NOFFICE,NCAPITAL_INIT,NCAPITAL_END,NPOLICY_YEAR_INIT,NPOLICY_YEAR_END,NCURRENCY,NAGE_INIT,NAGE_END,NAMOUNTF,NAMOUNTM,DNULLDATE,DCOMPDATE,NUSERCODE";
    public static readonly string[] Keys = Columns.Split(',').Take(16).ToArray();
    static string Match => string.Join(" AND ", Keys.Select(k => $"t.{k}=s.{k}"));
    static string Equal => "DECODE(t.NAMOUNTF,s.NAMOUNTF,1,0)=1 AND DECODE(t.NAMOUNTM,s.NAMOUNTM,1,0)=1 AND DECODE(t.DNULLDATE,s.DNULLDATE,1,0)=1";
    async Task<OracleConnection> Open(CancellationToken ct)
    {
        var c = new OracleConnection(db.Database.GetConnectionString());
        try { await c.OpenAsync(ct); return c; } catch { await c.DisposeAsync(); throw; }
    }
    static OracleCommand Command(OracleConnection c, string sql, params (string Name, object? Value)[] args)
    {
        var cmd = c.CreateCommand(); cmd.BindByName = true; cmd.CommandText = sql; cmd.CommandTimeout = 120;
        foreach (var (name, value) in args)
        {
            var p = cmd.Parameters.Add(name, value is string s && s.Length > 3500 ? OracleDbType.Clob : value switch
            { string => OracleDbType.Varchar2, byte[] => OracleDbType.Blob, DateTime => OracleDbType.Date, decimal => OracleDbType.Decimal, int or long => OracleDbType.Int64, _ => OracleDbType.Varchar2 });
            p.Value = value ?? DBNull.Value;
        }
        return cmd;
    }
    static async Task<int> Execute(OracleConnection c, string sql, CancellationToken ct, params (string, object?)[] args)
    { using var cmd = Command(c, sql, args); return await cmd.ExecuteNonQueryAsync(ct); }
    static async Task<long> Count(OracleConnection c, string sql, CancellationToken ct, params (string, object?)[] args)
    { using var cmd = Command(c, sql, args); return Convert.ToInt64(await cmd.ExecuteScalarAsync(ct)); }
    static void Id(string id) { if (!Guid.TryParseExact(id, "N", out _)) throw new ArgumentException("Identificador de importación inválido."); }
    public async Task<string> CrearAsync(PrimaDocumento documento, byte[] original, CancellationToken ct)
    {
        var id = Guid.NewGuid().ToString("N"); using var c = await Open(ct);
        await Execute(c, $"INSERT INTO {Jobs}(ID,ARCHIVO,HUELLA,ESTADO,DOCUMENTO,ORIGINAL,CREADO,TOTAL,PREPARADOS,INSERTADOS,EXISTENTES) VALUES(:id,:archivo,:hash,'BORRADOR',:doc,:original,SYSDATE,0,0,0,0)", ct,
            ("id", id), ("archivo", documento.Archivo), ("hash", documento.Huella), ("doc", JsonSerializer.Serialize(documento)),("original",original));
        return id;
    }
    async Task<string?> Json(string id, string column, CancellationToken ct)
    {
        Id(id); using var c = await Open(ct); using var cmd = Command(c, $"SELECT {column} FROM {Jobs} WHERE ID=:id", ("id", id));
        using var reader = await cmd.ExecuteReaderAsync(ct);
        if (!await reader.ReadAsync(ct)) throw new KeyNotFoundException("Importación no encontrada.");
        return reader.IsDBNull(0) ? null : reader.GetString(0);
    }
    public async Task<PrimaDocumento> DocumentoAsync(string id, CancellationToken ct) => JsonSerializer.Deserialize<PrimaDocumento>((await Json(id, "DOCUMENTO", ct))!)!;
    public async Task<PrimaPlan?> PlanAsync(string id, CancellationToken ct) => await Json(id, "PLAN", ct) is { } json ? JsonSerializer.Deserialize<PrimaPlan>(json) : null;
    public async Task<PrimaCatalogos> CatalogosAsync(CancellationToken ct)
    {
        using var c = await Open(ct);
        async Task<List<PrimaOpcion>> Read(string table, string key)
        {
            using var cmd = Command(c, $"SELECT {key},MAX(TRIM(SDESCRIPT)) FROM INSUDB.{table} GROUP BY {key} ORDER BY {key}");
            using var r = await cmd.ExecuteReaderAsync(ct); var list = new List<PrimaOpcion>();
            while (await r.ReadAsync(ct)) list.Add(new(Convert.ToInt32(r.GetValue(0)), r.IsDBNull(1) ? "" : r.GetString(1)));
            return list;
        }
        return new(await Read("TABLE12", "NROLE"), await Read("TABLE9", "NOFFICE"));
    }
    public async Task ConfigurarAsync(string id, PrimaPlan plan, CancellationToken ct)
    {
        Id(id); using var c = await Open(ct);
        await VerificarEsquema(c,plan,ct);
        var catalogs = await CatalogosAsync(ct);
        if (plan.Roles.Any(x => !catalogs.Roles.Any(r => r.Codigo == x)) || plan.Regionales.Any(x => !catalogs.Regionales.Any(r => r.Codigo == x))) throw new ArgumentException("La selección contiene códigos que no existen en los catálogos.");
        if (await Count(c, "SELECT COUNT(*) FROM INSUDB.USERS WHERE NUSERCODE=:u", ct, ("u", plan.Usuario)) != 1) throw new ArgumentException("El usuario Oracle declarado no existe en USERS.");
        var json = JsonSerializer.Serialize(plan);
        var updated = await Execute(c, $"UPDATE {Jobs} SET PLAN=:plan,PLAN_HASH=:hash,TOTAL=:total,ESTADO='REVISADO',ERROR=NULL WHERE ID=:id AND ESTADO IN ('BORRADOR','REVISADO')", ct,
            ("id", id), ("plan", json), ("hash", Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(json)))) , ("total", plan.Total));
        if (updated != 1) throw new ArgumentException("La importación ya está congelada; cree otra para modificar selecciones.");
    }
    static async Task VerificarEsquema(OracleConnection c,PrimaPlan plan,CancellationToken ct)
    {
        var constraints = new Dictionary<string,List<string>>();
        using(var cmd=Command(c,"SELECT c.CONSTRAINT_NAME,k.COLUMN_NAME FROM ALL_CONSTRAINTS c JOIN ALL_CONS_COLUMNS k ON k.OWNER=c.OWNER AND k.CONSTRAINT_NAME=c.CONSTRAINT_NAME WHERE c.OWNER='INSUDB' AND c.TABLE_NAME='TAR_HEALT_PREM' AND c.CONSTRAINT_TYPE IN ('P','U') AND c.STATUS='ENABLED' AND c.VALIDATED='VALIDATED'"))
        using(var r=await cmd.ExecuteReaderAsync(ct))
            while(await r.ReadAsync(ct)) { var name=r.GetString(0); if(!constraints.ContainsKey(name))constraints[name]=[]; constraints[name].Add(r.GetString(1)); }
        if(!constraints.Values.Any(cols=>cols.Count==Keys.Length && cols.ToHashSet().SetEquals(Keys)))
            throw new ArgumentException("La clave única validada de TAR_HEALT_PREM no coincide con los 16 campos esperados. El DBA debe verificarla antes de habilitar la carga.");
        var numeric=new Dictionary<string,(int? Precision,int? Scale)>();
        using(var cmd=Command(c,"SELECT COLUMN_NAME,DATA_PRECISION,DATA_SCALE FROM ALL_TAB_COLUMNS WHERE OWNER='INSUDB' AND TABLE_NAME='TAR_HEALT_PREM' AND DATA_TYPE='NUMBER'"))
        using(var r=await cmd.ExecuteReaderAsync(ct))
            while(await r.ReadAsync(ct))numeric[r.GetString(0)]=(r.IsDBNull(1)?null:Convert.ToInt32(r.GetValue(1)),r.IsDBNull(2)?null:Convert.ToInt32(r.GetValue(2)));
        foreach(var f in plan.Documento.Filas)
        {
            var values=new Dictionary<string,decimal?> { ["NCAPITAL_INIT"]=f.Capital,["NCAPITAL_END"]=9999999,["NAMOUNTF"]=f.Femenino,["NAMOUNTM"]=f.Masculino };
            foreach(var (name,value) in values)
            {
                if(!numeric.TryGetValue(name,out var meta))throw new ArgumentException($"El tipo Oracle de {name} no es NUMBER; revise el esquema.");
                if(value is not decimal v)continue;
                var scale=meta.Scale;
                if(scale is >=0 and <28 && decimal.Round(v,scale.Value)!=v || scale is <0 && (scale<=-28 ? v!=0 : v% (decimal)Math.Pow(10,-scale.Value)!=0))
                    throw new ArgumentException($"Fila {f.Fila}: {name} perdería decimales con la escala real de Oracle ({scale}).");
                if(meta.Precision is int precision && scale is int s && precision-s<28 && v>=(decimal)Math.Pow(10,precision-s))
                    throw new ArgumentException($"Fila {f.Fila}: {name} excede la precisión real de Oracle.");
            }
        }
    }
    public async Task EncolarAsync(string id, string revision, CancellationToken ct)
    {
        Id(id); using var c = await Open(ct);
        // Frozen plan and status transition are committed together by this single statement.
        var changed = await Execute(c, $"UPDATE {Jobs} SET ESTADO='EN_COLA',ERROR=NULL WHERE ID=:id AND ESTADO='REVISADO' AND PLAN_HASH=:hash", ct, ("id", id), ("hash",revision));
        if (changed == 0 && await Count(c,$"SELECT COUNT(*) FROM {Jobs} WHERE ID=:id AND PLAN_HASH=:hash AND ESTADO IN ('EN_COLA','PREPARANDO','COMPLETADO')",ct,("id",id),("hash",revision))==0)
            throw new ArgumentException("La revisión cambió. Vuelva a revisar antes de confirmar.");
    }
    public async Task ReanudarAsync(string id, CancellationToken ct)
    {
        Id(id); using var c = await Open(ct);
        await Execute(c, $"UPDATE {Jobs} SET ESTADO='EN_COLA',ERROR=NULL WHERE ID=:id AND ESTADO IN ('ERROR','PAUSADO')", ct, ("id", id));
    }
    public async Task PausarAsync(string id,CancellationToken ct)
    {
        Id(id);using var c=await Open(ct);
        await Execute(c,$"UPDATE {Jobs} SET ESTADO='PAUSADO' WHERE ID=:id AND ESTADO IN ('EN_COLA','PREPARANDO')",ct,("id",id));
    }
    static PrimaEstado ReadEstado(System.Data.Common.DbDataReader r) => new(r.GetString(0),r.GetString(1),r.GetString(2),Convert.ToInt64(r.GetValue(3)),Convert.ToInt64(r.GetValue(4)),Convert.ToInt64(r.GetValue(5)),Convert.ToInt64(r.GetValue(6)),r.IsDBNull(7)?null:r.GetString(7),r.GetDateTime(8));
    const string StatusColumns = "ID,ARCHIVO,ESTADO,TOTAL,PREPARADOS,INSERTADOS,EXISTENTES,ERROR,CREADO";
    public async Task<PrimaEstado> EstadoAsync(string id, CancellationToken ct)
    {
        Id(id); using var c = await Open(ct); using var cmd = Command(c, $"SELECT {StatusColumns} FROM {Jobs} WHERE ID=:id", ("id",id));
        using var r = await cmd.ExecuteReaderAsync(ct); if (!await r.ReadAsync(ct)) throw new KeyNotFoundException("Importación no encontrada."); return ReadEstado(r);
    }
    public async Task<List<PrimaEstado>> RecientesAsync(CancellationToken ct)
    {
        using var c = await Open(ct); using var cmd = Command(c, $"SELECT {StatusColumns} FROM {Jobs} ORDER BY CREADO DESC FETCH FIRST 30 ROWS ONLY");
        using var r = await cmd.ExecuteReaderAsync(ct); var list = new List<PrimaEstado>(); while (await r.ReadAsync(ct)) list.Add(ReadEstado(r)); return list;
    }
    public async Task<bool> ProcesarSiguienteAsync(CancellationToken ct)
    {
        using var c = await Open(ct); var ids = new List<string>();
        using (var cmd = Command(c, $"SELECT ID FROM {Jobs} WHERE ESTADO IN ('EN_COLA','PREPARANDO') ORDER BY CREADO FETCH FIRST 20 ROWS ONLY"))
        using (var r = await cmd.ExecuteReaderAsync(ct)) { while (await r.ReadAsync(ct)) ids.Add(r.GetString(0)); }
        foreach (var id in ids)
        {
            using var tx = c.BeginTransaction();
            try
            {
                PrimaPlan plan; long start;
                using (var cmd = Command(c, $"SELECT PLAN,PREPARADOS FROM {Jobs} WHERE ID=:id AND ESTADO IN ('EN_COLA','PREPARANDO') FOR UPDATE NOWAIT", ("id", id)))
                using (var r = await cmd.ExecuteReaderAsync(ct))
                {
                    if (!await r.ReadAsync(ct)) { tx.Rollback(); continue; }
                    plan = JsonSerializer.Deserialize<PrimaPlan>(r.GetString(0))!; start = Convert.ToInt64(r.GetValue(1));
                }
                if (start < plan.Total)
                {
                    var count = (int)Math.Min(1000, plan.Total - start);
                    await StageBatch(c, id, plan, start, count, ct);
                    await Execute(c, $"UPDATE {Jobs} SET PREPARADOS=:n,ESTADO='PREPARANDO' WHERE ID=:id", ct, ("id",id),("n",start+count));
                }
                else await Publish(c, id, ct);
                tx.Commit(); return true;
            }
            catch (OracleException ex) when (ex.Number == 54) { tx.Rollback(); /* Another worker/publication owns the lock. */ }
            catch (OperationCanceledException) { tx.Rollback(); throw; }
            catch (Exception ex)
            {
                logger.LogError(ex,"Error de importación de primas {ImportacionId}",id);
                tx.Rollback();
                // Do not overwrite COMPLETADO if commit succeeded but its acknowledgement was lost.
                var error = ex is ArgumentException ? ex.Message : ex is OracleException oe ? $"Error Oracle ORA-{oe.Number:D5}. Revise restricciones, tipos y disponibilidad con soporte. No se confirmó este segmento/publicación." : "Error al preparar o publicar. Consulte el registro de soporte.";
                await Execute(c, $"UPDATE {Jobs} SET ESTADO='ERROR',ERROR=:error WHERE ID=:id AND ESTADO IN ('EN_COLA','PREPARANDO')", ct,("id",id),("error",error[..Math.Min(error.Length,1900)]));
                return true;
            }
        }
        return false;
    }
    static async Task StageBatch(OracleConnection c,string id,PrimaPlan plan,long start,int count,CancellationToken ct)
    {
        using var cmd = Command(c, $"INSERT INTO {Stage}(IMPORT_ID,ITEM_NO,SOURCE_ROW,{Columns}) VALUES(:job,:item,:source,{string.Join(',', Columns.Split(',').Select((_,i)=>":p"+i))})");
        cmd.ArrayBindCount=count;
        var items=Enumerable.Range(0,count).Select(i=>plan.Item(start+i)).ToArray();
        void Add(string name,OracleDbType type,object[] values) { var p=cmd.Parameters.Add(name,type); p.Value=values; }
        Add("job",OracleDbType.Varchar2,items.Select(_=>(object)id).ToArray());
        Add("item",OracleDbType.Int64,Enumerable.Range(0,count).Select(i=>(object)(start+i)).ToArray());
        Add("source",OracleDbType.Int32,items.Select(x=>(object)x.Fila.Fila).ToArray());
        object[] Values((PrimaFila Fila,int Rol,int Regional) x)
        {
            var f=x.Fila;
            return [f.Ramo,f.Producto,f.Efecto,x.Rol,f.Modulo,f.Cobertura,f.Ambito,f.Atencion,x.Regional,f.Capital,9999999m,f.AnioDesde,f.AnioHasta,f.Moneda,f.EdadDesde,f.EdadHasta,(object?)f.Femenino??DBNull.Value,(object?)f.Masculino??DBNull.Value,DBNull.Value,DateTime.Now,plan.Usuario];
        }
        var matrix=items.Select(Values).ToArray();
        for(var col=0;col<21;col++) Add("p"+col,col is 2 or 18 or 19?OracleDbType.Date:OracleDbType.Decimal,matrix.Select(v=>v[col]).ToArray());
        try { await cmd.ExecuteNonQueryAsync(ct); }
        catch(OracleException ex) when(ex.Number==24381)
        {
            var index=ex.Errors.Count>0?ex.Errors[0].ArrayBindIndex:0;
            var source=index>=0&&index<items.Length?items[index].Fila.Fila:0;
            throw new ArgumentException($"No se pudo preparar el segmento {start/1000+1}, fila Excel {source}. Revise el tipo, precisión y restricciones de Oracle. Ningún registro de este segmento fue confirmado.",ex);
        }
    }
    static async Task Publish(OracleConnection c,string id,CancellationToken ct)
    {
        // Serializes against other imports AND external target writers during compare/insert.
        await Execute(c,"LOCK TABLE INSUDB.TAR_HEALT_PREM IN EXCLUSIVE MODE NOWAIT",ct);
        if(await Count(c,$"SELECT COUNT(*) FROM {Stage} s WHERE s.IMPORT_ID=:id AND (NOT EXISTS(SELECT 1 FROM INSUDB.PRODMASTER p WHERE p.NBRANCH=s.NBRANCH AND p.NPRODUCT=s.NPRODUCT) OR NOT EXISTS(SELECT 1 FROM INSUDB.TAB_MODUL m WHERE m.NBRANCH=s.NBRANCH AND m.NPRODUCT=s.NPRODUCT AND m.NMODULEC=s.NMODULEC AND m.DEFFECDATE<=s.DEFFECDATE AND (m.DNULLDATE IS NULL OR m.DNULLDATE>s.DEFFECDATE)) OR NOT EXISTS(SELECT 1 FROM INSUDB.TABLE12 r WHERE r.NROLE=s.NROLE) OR NOT EXISTS(SELECT 1 FROM INSUDB.TABLE9 o WHERE o.NOFFICE=s.NOFFICE) OR NOT EXISTS(SELECT 1 FROM INSUDB.TABLE9214 a WHERE a.NGEOGRAPHAREA=s.NGEOGRAPHAREA) OR NOT EXISTS(SELECT 1 FROM INSUDB.TABLE9215 a WHERE a.NATTENSYSTEM=s.NATTENSYSTEM) OR NOT EXISTS(SELECT 1 FROM INSUDB.USERS u WHERE u.NUSERCODE=s.NUSERCODE))",ct,("id",id))>0)
            throw new ArgumentException("Existen códigos de producto, módulo vigente, rol, regional, ámbito, atención o usuario que no coinciden con los catálogos. Corrija la entrada y cree otra importación.");
        var conflicts=await Count(c,$"SELECT COUNT(*) FROM {Stage} s JOIN INSUDB.TAR_HEALT_PREM t ON {Match} WHERE s.IMPORT_ID=:id AND NOT({Equal})",ct,("id",id));
        if(conflicts>0) throw new ArgumentException($"Publicación bloqueada: {conflicts} coincidencias de clave con primas o vigencia diferentes. No se actualizó ninguna tarifa.");
        // Catch overlaps even when the 16-part key differs (same dimensions and intersecting ranges).
        var dimensions=Keys.Where(k=> !new[]{"DEFFECDATE","NCAPITAL_INIT","NCAPITAL_END","NPOLICY_YEAR_INIT","NPOLICY_YEAR_END","NAGE_INIT","NAGE_END"}.Contains(k)).ToArray();
        var dims=string.Join(" AND ",dimensions.Select(k=>$"t.{k}=s.{k}"));
        var overlap="t.NAGE_INIT<=s.NAGE_END AND s.NAGE_INIT<=t.NAGE_END AND t.NCAPITAL_INIT<=s.NCAPITAL_END AND s.NCAPITAL_INIT<=t.NCAPITAL_END AND t.NPOLICY_YEAR_INIT<=s.NPOLICY_YEAR_END AND s.NPOLICY_YEAR_INIT<=t.NPOLICY_YEAR_END";
        var overlaps=await Count(c,$"SELECT COUNT(*) FROM {Stage} s JOIN INSUDB.TAR_HEALT_PREM t ON {dims} AND {overlap} WHERE s.IMPORT_ID=:id AND NOT({Match}) AND (t.DNULLDATE IS NULL OR t.DNULLDATE>s.DEFFECDATE)",ct,("id",id));
        if(overlaps>0) throw new ArgumentException("Existen tarifas con rangos o vigencias superpuestas. Revise la vigencia anterior antes de publicar; no se anula automáticamente.");
        var existing=await Count(c,$"SELECT COUNT(*) FROM {Stage} s WHERE s.IMPORT_ID=:id AND EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})",ct,("id",id));
        await Execute(c,$"UPDATE {Stage} s SET RESULTADO='EXISTENTE' WHERE s.IMPORT_ID=:id AND EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})",ct,("id",id));
        var selected=string.Join(',',Columns.Split(',').Select(k=>k=="DCOMPDATE"?"SYSDATE":"s."+k));
        var inserted=await Execute(c,$"INSERT INTO INSUDB.TAR_HEALT_PREM({Columns}) SELECT {selected} FROM {Stage} s WHERE s.IMPORT_ID=:id AND NOT EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})",ct,("id",id));
        var total=await Count(c,$"SELECT TOTAL FROM {Jobs} WHERE ID=:id",ct,("id",id));
        if(inserted+existing!=total) throw new ArgumentException("La conciliación no coincide con el total esperado; publicación revertida.");
        await Execute(c,$"UPDATE {Stage} SET RESULTADO='INSERTADO' WHERE IMPORT_ID=:id AND RESULTADO='PREPARADO'",ct,("id",id));
        await Execute(c,$"UPDATE {Jobs} SET ESTADO='COMPLETADO',INSERTADOS=:n,EXISTENTES=:e,ERROR=NULL WHERE ID=:id",ct,("id",id),("n",inserted),("e",existing));
    }
}
