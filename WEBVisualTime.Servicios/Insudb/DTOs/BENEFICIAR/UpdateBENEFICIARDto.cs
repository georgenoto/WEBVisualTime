namespace WEBVisualTime.Servicios.Insudb.DTOs.BENEFICIAR;

public class UpdateBENEFICIARDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public string SCLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPARTICIP { get; set; }
    public int NRELATION { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DDATEDECLA { get; set; }
    public string? SIRREVOC { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public string? SCONTING { get; set; }
    public string? SSEND_MAIL { get; set; }
    public string? SDESIGN { get; set; }
}
