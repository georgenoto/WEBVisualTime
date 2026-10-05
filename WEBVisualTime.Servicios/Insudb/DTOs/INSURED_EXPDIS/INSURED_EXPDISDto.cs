namespace WEBVisualTime.Servicios.Insudb.DTOs.INSURED_EXPDIS;

public class INSURED_EXPDISDto
{
    public string SCERTYPE { get; set; }
    public string? CERTIFICATSCERTYPESCUMUL_CODE { get; set; }
    public int NBRANCH { get; set; }
    public string? CERTIFICATNBRANCHSCUMUL_CODE { get; set; }
    public int NPRODUCT { get; set; }
    public string? CERTIFICATNPRODUCTSCUMUL_CODE { get; set; }
    public long NPOLICY { get; set; }
    public string? CERTIFICATNPOLICYSCUMUL_CODE { get; set; }
    public long NCERTIF { get; set; }
    public string? CERTIFICATNCERTIFSCUMUL_CODE { get; set; }
    public int NGROUP_INSU { get; set; }
    public string SCLIENT { get; set; }
    public string? CLIENTSACCOUNT_IN { get; set; }
    public int NDISEXPRC { get; set; }
    public string SDISEXPRI { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SUNIT { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string SPERM_TEMP { get; set; }
    public DateTime? DDATE_FR { get; set; }
    public DateTime? DDATE_TO { get; set; }
    public int? NAGE { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? USERSSACCESSWO { get; set; }
    public int? NCAUSE { get; set; }
    public string SAGREE { get; set; }
    public string? SINITDATE_CALC { get; set; }
    public long? NACTIVITY { get; set; }
    public long? NSPORT { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
