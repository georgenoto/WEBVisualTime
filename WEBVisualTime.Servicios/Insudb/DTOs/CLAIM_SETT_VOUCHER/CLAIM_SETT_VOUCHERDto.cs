namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_VOUCHER;

public class CLAIM_SETT_VOUCHERDto
{
    public long NSETTLEMENT_NUM { get; set; }
    public string? CLAIM_SETTLEMENTSCLIENT2 { get; set; }
    public long NCLAIM_VOUCHER { get; set; }
    public string? CLAIM_VOUCHERSCLINUMDOCU { get; set; }
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
    public int? NTYPEDISC_PROV { get; set; }
    public string? TABLE9254SDESCRIPT { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
    public decimal? NAGREE_DISCOUNT { get; set; }
}
