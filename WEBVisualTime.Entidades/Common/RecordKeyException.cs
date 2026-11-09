namespace WEBVisualTime.Entidades.Common;

public sealed class RecordKeyException : ArgumentException
{
    public RecordKeyException() : base("La identificación del registro no contiene una llave completa y válida.") { }
}
