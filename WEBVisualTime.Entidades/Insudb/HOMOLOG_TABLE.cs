#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class HOMOLOG_TABLE
{
    public int NSYSTEM { get; set; }
    public int? NTABLE { get; set; }
    public int? NID { get; set; }
    public string? SCOLUMNNAME_VT { get; set; }
    public string? SCODVALUE_VT { get; set; }
    public string? SVALUE_VT { get; set; }
    public string? STABLENAME { get; set; }
    public string? SCOLUMNNAME { get; set; }
    public string? SCODVALUE { get; set; }
    public string? SPREDOM { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
