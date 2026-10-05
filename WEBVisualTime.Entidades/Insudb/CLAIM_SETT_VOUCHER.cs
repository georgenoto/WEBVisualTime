#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_SETT_VOUCHER
{
    public long NSETTLEMENT_NUM { get; set; }

    [ForeignKey("NSETTLEMENT_NUM")]
    public Insudb.CLAIM_SETTLEMENT? CLAIM_SETTLEMENT { get; set; }
    public long NCLAIM_VOUCHER { get; set; }

    [ForeignKey("NCLAIM_VOUCHER")]
    public Insudb.CLAIM_VOUCHER? CLAIM_VOUCHER { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NAMOUNT_TOTAL { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public decimal? NAMOUNT_VAT { get; set; }
    public decimal? NAMOUNT_FTT { get; set; }
    public decimal? NAMOUNT_AGREE { get; set; }
    public decimal? NAMOUNT_ADJUST { get; set; }
    public decimal? NSETTLEMENT_PAY { get; set; }
    public decimal? NAMOUNT_VAT_LOSS { get; set; }
    public decimal? NAMOUNT_FTT_LOSS { get; set; }
    public int NTYPEDISC_PROV { get; set; }

    [ForeignKey("NTYPEDISC_PROV")]
    public Insudb.TABLE9254? TABLE9254 { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
    public decimal? NAGREE_DISCOUNT { get; set; }
}
