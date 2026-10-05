#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_VOUCHER_ORDER
{
    public long NCLAIM_VOUCHER { get; set; }

    [ForeignKey("NCLAIM_VOUCHER")]
    public Insudb.CLAIM_VOUCHER? CLAIM_VOUCHER { get; set; }
    public long NORDER_NUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NBORDEREAUX_CL { get; set; }
    public long? NSETTLEMENT_NUM { get; set; }
}
