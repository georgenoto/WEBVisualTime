#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_SETT_ORDER
{
    public long NSETTLEMENT_NUM { get; set; }

    [ForeignKey("NSETTLEMENT_NUM")]
    public Insudb.CLAIM_SETTLEMENT? CLAIM_SETTLEMENT { get; set; }
    public long NORDER_NUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NAMOUNT_ORDEN { get; set; }
    public decimal? NAMOUNT_TOTAL { get; set; }
    public decimal? NAMOUNT_DEDUCOIN { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public decimal? NAMOUNT_VAT { get; set; }
    public decimal? NAMOUNT_FTT { get; set; }
    public decimal? NAMOUNT_AGREE { get; set; }
    public decimal? NAMOUNT_ADJUST { get; set; }
    public decimal? NSETTLEMENT_PAY { get; set; }
    public decimal? NAMOUNT_VAT_LOSS { get; set; }
    public decimal? NAMOUNT_FTT_LOSS { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
}
