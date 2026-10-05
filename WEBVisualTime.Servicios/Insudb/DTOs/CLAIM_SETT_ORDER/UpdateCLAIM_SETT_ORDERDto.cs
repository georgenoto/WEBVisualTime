namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_ORDER;

public class UpdateCLAIM_SETT_ORDERDto
{
    public long NSETTLEMENT_NUM { get; set; }
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
