namespace WEBVisualTime.Servicios.Insudb.DTOs.REQ_ENDOR;

public class REQ_ENDORDto
{
    public long NREQENDOR { get; set; }
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
    public DateTime DREQSTARTENDOR { get; set; }
    public int NTYPEENDOR { get; set; }
    public string? TABLE6059SDESCRIPT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? USERSNUSERCODESACCESSWO { get; set; }
    public long NUNDERWRITINGCASEID { get; set; }
    public long? NINTERMED { get; set; }
    public int NOFFICE { get; set; }
    public string? TABLE9SDESCRIPT { get; set; }
    public int NAGENCY { get; set; }
    public string? TABLE5555SDESCRIPT { get; set; }
    public string? SCERTYPEENDOR { get; set; }
    public long? NPOLICYENDOR { get; set; }
    public string? SOBS { get; set; }
    public string? SREASON_REJECT { get; set; }
    public int NUSERCODE_REJECT { get; set; }
    public string? USERSNUSERCODE_REJECTSACCESSWO { get; set; }
    public DateTime? DREJECT { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int NUSERCODE_REQ { get; set; }
    public string? USERSNUSERCODE_REQSACCESSWO { get; set; }
}
