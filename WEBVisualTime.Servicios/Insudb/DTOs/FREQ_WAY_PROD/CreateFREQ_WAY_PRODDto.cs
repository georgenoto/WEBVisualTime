namespace WEBVisualTime.Servicios.Insudb.DTOs.FREQ_WAY_PROD;

public class CreateFREQ_WAY_PRODDto
{
    public int? NCURRENCY { get; set; }
    public decimal? NPRE_ISSUE { get; set; }
    public decimal? NPRE_AMEND { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NLIMIT_EXCTAX { get; set; }
    public int? NQPREM_BAS_ANN { get; set; }
    public string? SIVA_COVER_IND { get; set; }
    public string? SNO_SELL { get; set; }
    public decimal? NPRE_COVEREXT { get; set; }
    public decimal? NPRE_ISSUEMAX { get; set; }
    public decimal? NDISC_PAYMETH { get; set; }
}
