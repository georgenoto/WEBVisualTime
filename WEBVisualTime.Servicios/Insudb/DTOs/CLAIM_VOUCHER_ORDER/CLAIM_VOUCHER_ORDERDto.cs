namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER_ORDER;

public class CLAIM_VOUCHER_ORDERDto
{
    public long NCLAIM_VOUCHER { get; set; }
    public string? CLAIM_VOUCHERSCLINUMDOCU { get; set; }
    public long NORDER_NUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NBORDEREAUX_CL { get; set; }
    public long? NSETTLEMENT_NUM { get; set; }
}
