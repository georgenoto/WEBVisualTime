#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_CAUS
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NCAUSECOD { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SCLAIMTYP { get; set; }

    [ForeignKey("SCLAIMTYP")]
    public Insudb.TABLE132? TABLE132 { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SROUTINE { get; set; }
}
