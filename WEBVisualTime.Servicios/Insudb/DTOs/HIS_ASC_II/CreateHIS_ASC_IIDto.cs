namespace WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_II;

public class CreateHIS_ASC_IIDto
{
    public string SBANK_ORI { get; set; }
    public int NPERIOD_YEAR { get; set; }
    public int NPERIOD_MONTH { get; set; }
    public int? NORDER { get; set; }
    public string? SUNIQ_CODE { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SCURRENCY { get; set; }
    public string? SPAY_MET { get; set; }
    public string? SCONCEPT { get; set; }
    public string? SREFERENCE { get; set; }
    public string? SDOC_TYPE { get; set; }
    public string SCLIENAME { get; set; }
    public string? SPHON_BEN { get; set; }
    public string SBANKACCOUNT { get; set; }
    public string SBANKEXT { get; set; }
    public string SSTATUS { get; set; }
    public string SREASON { get; set; }
    public string SDETAIL { get; set; }
    public long? NCHEQUE { get; set; }
    public long? NORDER_ACH { get; set; }
    public DateTime? DATE_UPLOAD { get; set; }
    public DateTime? DATE_PAY { get; set; }
    public long? NTRANSF { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string SSTATMOV { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NREQUEST_NU { get; set; }
    public string? SKEY { get; set; }
    public string NDOCUMENT { get; set; }
}
