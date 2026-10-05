namespace WEBVisualTime.Servicios.Insudb.DTOs.MODUL_CO_G;

public class UpdateMODUL_CO_GDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public int NGROUP { get; set; }
    public int NMODULEC { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPREMIRAT { get; set; }
    public string? STYP_RAT { get; set; }
    public int NGEOGRAPHAREA { get; set; }
    public int NATTENSYSTEM { get; set; }
}
