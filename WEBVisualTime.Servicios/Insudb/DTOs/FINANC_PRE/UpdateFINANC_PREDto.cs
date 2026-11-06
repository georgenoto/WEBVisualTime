namespace WEBVisualTime.Servicios.Insudb.DTOs.FINANC_PRE;

public class UpdateFINANC_PREDto
{
    public int? NBRANCH { get; set; }
    public decimal? NCOMMISSION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public long? NINTERMED { get; set; }
    public int? NOFFICE { get; set; }
    public long? NPOLICY { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long NRECEIPT { get; set; }
    public string? SSTAT_FINPR { get; set; }
    public string SSTATREGT { get; set; }
    public string? SCLIENT { get; set; }
    public int NUSERCODE { get; set; }
    public int? NPRODUCT { get; set; }
    public int? NCOMPANY { get; set; }
    public string? SEXTRECEIPT { get; set; }
}
