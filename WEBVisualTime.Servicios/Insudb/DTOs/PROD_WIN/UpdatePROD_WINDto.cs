namespace WEBVisualTime.Servicios.Insudb.DTOs.PROD_WIN;

public class UpdatePROD_WINDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SV_CONPRODU { get; set; }
    public string? SV_WINPRODU { get; set; }
    public string? SV_WINPRODU1 { get; set; }
}
