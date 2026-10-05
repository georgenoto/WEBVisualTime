namespace WEBVisualTime.Servicios.Insudb.DTOs.PROD_RESERVE;

public class CreatePROD_RESERVEDto
{
    public DateTime? DNULLDATE { get; set; }
    public string? SROURESER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NPERCRESER { get; set; }
    public decimal? NRESEAMO { get; set; }
    public decimal? NMAXPERCENT { get; set; }
    public string? SROUTINECOST { get; set; }
    public string? SMORTALCO { get; set; }
}
