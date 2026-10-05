namespace WEBVisualTime.Servicios.Insudb.DTOs.GROUPS;

public class UpdateGROUPSDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public long NPOLICY { get; set; }
    public int NPRODUCT { get; set; }
    public int NGROUP { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SCLIENT { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NPARTICIP { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPARTICIP_CO { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
