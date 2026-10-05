namespace WEBVisualTime.Servicios.Insudb.DTOs.DURPAY_PROD;

public class UpdateDURPAY_PRODDto
{
    public int NID { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int? NIDURAFIX { get; set; }
    public int? NPDURAFIX { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NTYPDURINS { get; set; }
    public int NTYPDURPAY { get; set; }
}
