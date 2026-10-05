namespace WEBVisualTime.Servicios.Insudb.DTOs.BENEFICIAR;

public class CreateBENEFICIARDto
{
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPARTICIP { get; set; }
    public int NRELATION { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DDATEDECLA { get; set; }
    public string? SIRREVOC { get; set; }
    public string? SCONTING { get; set; }
    public string? SSEND_MAIL { get; set; }
    public string? SDESIGN { get; set; }
}
