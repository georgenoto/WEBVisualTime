#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_AUXILIAR
{
    public string? CARACTER { get; set; }
    public long? NUMERO { get; set; }
    public DateTime? FECHA { get; set; }
}
