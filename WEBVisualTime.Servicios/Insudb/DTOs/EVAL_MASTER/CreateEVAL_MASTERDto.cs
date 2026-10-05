namespace WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;

public class CreateEVAL_MASTERDto
{
    public string? SCLIENT { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public long NCERTIF { get; set; }
    public DateTime DEXPIRDAT { get; set; }
    public int NSTATUS_EVAL { get; set; }
    public decimal? NCAPITAL { get; set; }
    public long? NNOTEREST { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NCUMUL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCERTYPE { get; set; }
}
