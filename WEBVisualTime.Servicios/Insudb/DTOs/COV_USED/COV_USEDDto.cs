namespace WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;

public class COV_USEDDto
{
    public long NCLAIM { get; set; }
    public string? CLAIM_CASENCLAIMSSTACASE { get; set; }
    public int NCASE_NUM { get; set; }
    public string? CLAIM_CASENCASE_NUMSSTACASE { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public string? CLAIM_CASENDEMAN_TYPESSTACASE { get; set; }
    public int NGROUP_INSU { get; set; }
    public int NTRANSAC { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NCURRENCY { get; set; }
    public string SCLIENT { get; set; }
    public string? CLIENTSACCOUNT_IN { get; set; }
    public long NSTARTDATE { get; set; }
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
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCON_ID { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime? DRESTIT_DAT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPURPOSE { get; set; }
}
