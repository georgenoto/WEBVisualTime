namespace WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;

public class UpdateSITUATIONDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public int NSITUATION { get; set; }
    public int NCOD_AGREE { get; set; }
    public string? SCLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPARTICIP_POLEMP { get; set; }
    public decimal? NPARTICIP_POLCO { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
}
