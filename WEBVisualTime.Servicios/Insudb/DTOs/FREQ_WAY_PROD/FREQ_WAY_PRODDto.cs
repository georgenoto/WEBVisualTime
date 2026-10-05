namespace WEBVisualTime.Servicios.Insudb.DTOs.FREQ_WAY_PROD;

public class FREQ_WAY_PRODDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NWAY_PAY { get; set; }
    public string? TABLE5002SDESCRIPT { get; set; }
    public int NPAYFREQ { get; set; }
    public string? TABLE36SDESCRIPT { get; set; }
    public DateTime DEFFECDATE { get; set; }
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
