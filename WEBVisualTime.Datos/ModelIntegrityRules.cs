namespace WEBVisualTime.Datos;

public static class ModelIntegrityRules
{
    // Oracle aggregate audit (2026-11-06): these proposed keys contain duplicates.
    // Remove a restriction only after a stable row identity has been defined and verified.
    public static string? ReadOnlyReason(string entityName) => entityName switch
    {
        "TABLE8006" or "TABLE8007" =>
            "Este catálogo contiene códigos duplicados que no identifican una fila de forma única. " +
            "Está disponible solo para consulta hasta que se defina una clave segura para editar o eliminar registros.",
        _ => null
    };

    public static void EnsureWritable(Type entityType)
    {
        if (ReadOnlyReason(entityType.Name) is { } reason)
            throw new InvalidOperationException(reason);
    }
}
