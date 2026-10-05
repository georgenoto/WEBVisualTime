namespace WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;

public class CURR_ACCDto
{
    public int NTYP_ACCO { get; set; }
    public string? TABLE400SDESCRIPT { get; set; }
    public string STYPE_ACC { get; set; }
    public string SCLIENT { get; set; }
    public string? CLIENTSACCOUNT_IN { get; set; }
    public int NCURRENCY { get; set; }
    public decimal? NBALANCE { get; set; }
    public decimal? NCREDIT { get; set; }
    public decimal? NDEBIT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NLED_COMPAN { get; set; }
    public string? LEDGER_ACCNLED_COMPANSADJU_EXCI { get; set; }
    public string? SACCOUNT { get; set; }
    public string? LEDGER_ACCSACCOUNTSADJU_EXCI { get; set; }
    public string? SCERTYPE { get; set; }
    public string? CERTIFICATSCERTYPESCUMUL_CODE { get; set; }
    public int NCOMPANY { get; set; }
    public string? COMPANYSACCOUNT { get; set; }
    public int NPRODUCT { get; set; }
    public string? CERTIFICATNPRODUCTSCUMUL_CODE { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public string? LEDGER_ACCSAUX_ACCOUNSADJU_EXCI { get; set; }
    public int NBRANCH { get; set; }
    public string? CERTIFICATNBRANCHSCUMUL_CODE { get; set; }
    public long NCERTIF { get; set; }
    public string? CERTIFICATNCERTIFSCUMUL_CODE { get; set; }
    public long NPOLICY { get; set; }
    public string? CERTIFICATNPOLICYSCUMUL_CODE { get; set; }
    public int NINSUR_AREA { get; set; }
    public string? TABLE5001SDESCRIPT { get; set; }
}
