namespace WEBVisualTime.Servicios.Insudb.DTOs.DURPAY_PROD;

public class CreateDURPAY_PRODDto
{
    public int? NIDURAFIX { get; set; }
    public int? NPDURAFIX { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NTYPDURINS { get; set; }
    public int NTYPDURPAY { get; set; }
}
