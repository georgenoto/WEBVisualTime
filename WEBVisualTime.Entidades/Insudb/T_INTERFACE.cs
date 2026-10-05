#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_INTERFACE
{
    public string SKEY { get; set; }
    public long NROW { get; set; }
    public long NCOLUMN { get; set; }
    public string? SVALUE { get; set; }
    public string STABLE { get; set; }
    public string? SPROCESS { get; set; }
    public int? NFIELD { get; set; }
    public string? SVALUE_HOMO { get; set; }
    public string? SFIELDDESC { get; set; }
    public int? NDATATYPE { get; set; }
}
