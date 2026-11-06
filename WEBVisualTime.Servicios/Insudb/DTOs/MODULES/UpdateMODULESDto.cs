namespace WEBVisualTime.Servicios.Insudb.DTOs.MODULES;

public class UpdateMODULESDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NGROUP_INSU { get; set; }
    public int NMODULEC { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCHANGEI { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NPREMIRAT { get; set; }
    public string? STYP_RAT { get; set; }
    public string? SINHERIT { get; set; }
    public int? NGEOGRAPHAREA { get; set; }
    public int? NATTENSYSTEM { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
