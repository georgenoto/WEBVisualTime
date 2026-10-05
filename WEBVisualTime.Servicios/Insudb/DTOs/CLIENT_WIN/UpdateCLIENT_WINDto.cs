namespace WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_WIN;

public class UpdateCLIENT_WINDto
{
    public string SCLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SV_CONCLIEN { get; set; }
    public string? SV_WINCLIEN { get; set; }
}
