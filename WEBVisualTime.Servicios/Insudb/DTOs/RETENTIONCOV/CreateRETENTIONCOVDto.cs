namespace WEBVisualTime.Servicios.Insudb.DTOs.RETENTIONCOV;

public class CreateRETENTIONCOVDto
{
    public DateTime? DNULLDATE { get; set; }
    public decimal? NRETENTION { get; set; }
    public string? SROUTINE { get; set; }
    public int? NCOVPROPOR { get; set; }
    public decimal? NCOMBLIM { get; set; }
    public int? NCOVERCL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SEARTHQUAKE { get; set; }
    public decimal? NMAXRETAMOUNT { get; set; }
}
