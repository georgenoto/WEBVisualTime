namespace WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;

public class UpdateREINSU_PRIM_HEALTHDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMODULEC { get; set; }
    public long NCURRENCY { get; set; }
    public DateTime DEEFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NREINPRE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREG { get; set; }
    public int? NUSERCODE { get; set; }
}
