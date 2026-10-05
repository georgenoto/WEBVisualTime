#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_BK_AGE
{
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public long NBK_AGENCY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SN_ABA { get; set; }
}
