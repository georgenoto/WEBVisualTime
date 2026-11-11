namespace WEBVisualTime.Entidades.ImportacionPrimas;

public sealed record PrimaFila(int Fila, string Descripcion, int Ramo, int Producto, DateTime Efecto,
    int Modulo, int Cobertura, int RolOriginal, int RegionalOriginal, int Ambito, int Atencion,
    decimal Capital, int Moneda, int EdadDesde, int EdadHasta, decimal? Masculino, decimal? Femenino,
    int AnioDesde, int AnioHasta);
public sealed record PrimaDocumento(string Archivo, string Huella, List<PrimaFila> Filas);
public sealed record PrimaPlan(PrimaDocumento Documento, int[] Roles, int[] Regionales, int Usuario, DateTime? FechaEfecto = null)
{
    // Optional only for compatibility with plans frozen before renewal support.
    public long? TarifasAnterioresCerradas { get; init; }
    public long Total => (long)Documento.Filas.Count * Roles.Length * Regionales.Length;
    public (PrimaFila Fila, int Rol, int Regional) Item(long indice)
    {
        var combinaciones = Roles.Length * Regionales.Length;
        var fila = Documento.Filas[(int)(indice / combinaciones)];
        if (FechaEfecto is DateTime efecto) fila = fila with { Efecto = efecto.Date };
        return (fila, Roles[(int)(indice % Roles.Length)],
            Regionales[(int)(indice % combinaciones / Roles.Length)]);
    }
}
public sealed record PrimaEstado(string Id, string Archivo, string Estado, long Total, long Preparados,
    long Insertados, long Existentes, string? Error, DateTime Creado);
public sealed record PrimaOpcion(int Codigo, string Nombre);
public sealed record PrimaCatalogos(List<PrimaOpcion> Roles, List<PrimaOpcion> Regionales);
public interface IPrimaImportacionStore
{
    Task<string> CrearAsync(PrimaDocumento documento, byte[] original, CancellationToken ct);
    Task<PrimaDocumento> DocumentoAsync(string id, CancellationToken ct);
    Task<PrimaPlan?> PlanAsync(string id, CancellationToken ct);
    Task<PrimaEstado> EstadoAsync(string id, CancellationToken ct);
    Task<List<PrimaEstado>> RecientesAsync(CancellationToken ct);
    Task<PrimaCatalogos> CatalogosAsync(CancellationToken ct);
    Task ConfigurarAsync(string id, PrimaPlan plan, CancellationToken ct);
    Task EncolarAsync(string id, string revision, CancellationToken ct);
    Task ReanudarAsync(string id, CancellationToken ct);
    Task PausarAsync(string id, CancellationToken ct);
    Task EditarAsync(string id, CancellationToken ct);
    Task<bool> ProcesarSiguienteAsync(CancellationToken ct);
}
