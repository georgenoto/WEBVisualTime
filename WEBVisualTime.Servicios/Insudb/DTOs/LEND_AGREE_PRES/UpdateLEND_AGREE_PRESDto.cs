namespace WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PRES;

public class UpdateLEND_AGREE_PRESDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public long NGROUP { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public string SCLIENT { get; set; }
    public long NPRESTAC { get; set; }
    public int NCOD_AGREE { get; set; }
    public int NCITY_RESIDENCE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
