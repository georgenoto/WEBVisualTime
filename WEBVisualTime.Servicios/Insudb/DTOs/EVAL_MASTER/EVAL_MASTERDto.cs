namespace WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;

public class EVAL_MASTERDto
{
    public long NEVAL { get; set; }
    public string? SCLIENT { get; set; }
    public string? CLIENTSACCOUNT_IN { get; set; }
    public int NBRANCH { get; set; }
    public string? CERTIFICATNBRANCHSCUMUL_CODE { get; set; }
    public int NPRODUCT { get; set; }
    public string? CERTIFICATNPRODUCTSCUMUL_CODE { get; set; }
    public long NPOLICY { get; set; }
    public string? CERTIFICATNPOLICYSCUMUL_CODE { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public long NCERTIF { get; set; }
    public string? CERTIFICATNCERTIFSCUMUL_CODE { get; set; }
    public DateTime DEXPIRDAT { get; set; }
    public int NSTATUS_EVAL { get; set; }
    public string? TABLE5572SDESCRIPT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public long? NNOTEREST { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NCUMUL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCERTYPE { get; set; }
    public string? CERTIFICATSCERTYPESCUMUL_CODE { get; set; }
}
