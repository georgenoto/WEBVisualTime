namespace WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;

public class CreateSITUATIONDto
{
    public string? SCLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPARTICIP_POLEMP { get; set; }
    public decimal? NPARTICIP_POLCO { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
}
