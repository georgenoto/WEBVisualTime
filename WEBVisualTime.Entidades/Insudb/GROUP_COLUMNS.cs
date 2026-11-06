#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class GROUP_COLUMNS
{
    public int? NSHEET { get; set; }

    [ForeignKey("NSHEET")]
    public Insudb.TABLE697? TABLE697 { get; set; }
    public int NIDREC { get; set; }
    public string? SFIELD { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCOLUMNNAME { get; set; }
    public int? NORDER { get; set; }
    public string? SVALUESLIST { get; set; }
    public string? STABLE { get; set; }
    public string? SREQUIRE { get; set; }
    public string? SCOMMENT { get; set; }
    public string? SUPDATEIND { get; set; }
}
