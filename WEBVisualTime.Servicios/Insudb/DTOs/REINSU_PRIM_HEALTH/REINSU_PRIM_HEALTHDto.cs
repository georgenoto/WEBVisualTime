namespace WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;

public class REINSU_PRIM_HEALTHDto
{
    public int NBRANCH { get; set; }
    public string? TABLE10SDESCRIPT { get; set; }
    public int NPRODUCT { get; set; }
    public string? PRODMASTERSDESCRIPT { get; set; }
    public int NMODULEC { get; set; }
    public int NCURRENCY { get; set; }
    public string? TABLE11SDESCRIPT { get; set; }
    public DateTime DEEFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NREINPRE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREG { get; set; }
    public int? NUSERCODE { get; set; }
}
