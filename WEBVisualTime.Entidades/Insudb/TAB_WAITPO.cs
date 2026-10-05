#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_WAITPO
{
    public int NWAIT_CODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public int NAREAWAIT { get; set; }

    [ForeignKey("NAREAWAIT")]
    public Insudb.TABLE5603? TABLE5603 { get; set; }
    public int NORDER { get; set; }
    public string? SCONVERT { get; set; }
}
