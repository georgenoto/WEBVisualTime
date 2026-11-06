#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_COMLIF
{
    public int NCOMTABLI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NINTERTYP { get; set; }

    [ForeignKey("NINTERTYP")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
}
