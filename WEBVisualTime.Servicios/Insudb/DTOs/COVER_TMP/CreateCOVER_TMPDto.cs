namespace WEBVisualTime.Servicios.Insudb.DTOs.COVER_TMP;

public class CreateCOVER_TMPDto
{
    public long NROW { get; set; }
    public long NCOLUMN { get; set; }
    public string? SVALUE { get; set; }
    public string? SSECTION { get; set; }
    public string? SDATATYPE { get; set; }
    public string? SUPDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
