namespace WEBVisualTime.Servicios.Insudb.DTOs.REFINAN_DRA;

public class CreateREFINAN_DRADto
{
    public int? NBRANCH { get; set; }
    public decimal? NCOMMISSION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NPREMIUM { get; set; }
    public string? SSTAT_FINPR { get; set; }
    public string SSTATREGT { get; set; }
    public string? SCLIENT { get; set; }
    public int NUSERCODE { get; set; }
    public long? NOPT_DRAFT { get; set; }
}
