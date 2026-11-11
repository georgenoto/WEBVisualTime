namespace WEBVisualTime.Entidades.ReplicaBeneficios;

public sealed record BeneficioOpcion(int Codigo, string Nombre);
public sealed record BeneficioPlan(int Ramo, int Producto, int Base, int[] Destinos, int Usuario)
{
    public void Validar()
    {
        if (Ramo != 5 || Producto <= 0 || Base <= 0 || Usuario <= 0)
            throw new ArgumentException("Indique producto, módulo base y usuario Oracle. El ramo es 5.");
        if (Destinos is null || Destinos.Length == 0 || Destinos.Length > 500 || Destinos.Any(x => x <= 0 || x == Base) || Destinos.Distinct().Count() != Destinos.Length)
            throw new ArgumentException("Seleccione entre 1 y 500 destinos distintos, sin incluir el módulo base.");
    }
}
public sealed record BeneficioResumen(string Id, string Estado, BeneficioPlan Plan, DateTime Creado, DateTime? Ejecutado);
public sealed record BeneficioDestino(int Modulo, long Anteriores);
public sealed record BeneficioEstado(string Id, string Estado, BeneficioPlan Plan, long BaseFilas, long Total,
    long Preparados, long Eliminados, string? Error, string Revision, List<BeneficioDestino> Destinos);
public interface IReplicaBeneficiosStore
{
    Task<List<BeneficioOpcion>> ProductosAsync(CancellationToken ct);
    Task<List<BeneficioOpcion>> ModulosAsync(int producto, CancellationToken ct);
    Task<List<BeneficioResumen>> RecientesAsync(CancellationToken ct);
    Task<string> CrearAsync(BeneficioPlan plan, CancellationToken ct);
    Task EditarAsync(string id, string revision, BeneficioPlan plan, CancellationToken ct);
    Task<BeneficioEstado> EstadoAsync(string id, CancellationToken ct);
    Task AccionAsync(string id, string accion, string? revision, CancellationToken ct);
    Task<bool> ProcesarAsync(CancellationToken ct);
}
