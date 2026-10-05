namespace WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_MASSIVE;

public class CreateT_ERR_MASSIVEDto
{
    public string SKEY { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public long? NERROR { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCERTYPE { get; set; }
    public string? SCLIENT { get; set; }
    public long? NSEQ { get; set; }
    public string? STYPE { get; set; }
}
