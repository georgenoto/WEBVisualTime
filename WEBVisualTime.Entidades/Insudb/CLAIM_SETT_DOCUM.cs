#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_SETT_DOCUM
{
    public long? NSEQ_IDLEDGERDOCUM { get; set; }
    public long NCONSEC_DOC { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NSTATUS_DOC { get; set; }

    [ForeignKey("NSTATUS_DOC")]
    public Insudb.TABLE203? TABLE203 { get; set; }
    public int? NDOC_CODE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NSETTLEMENT_NUM { get; set; }
}
