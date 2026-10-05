namespace WEBVisualTime.Servicios.Insudb.DTOs.REQ_ENDOR;

public class CreateREQ_ENDORDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public DateTime DREQSTARTENDOR { get; set; }
    public int NTYPEENDOR { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long NUNDERWRITINGCASEID { get; set; }
    public long? NINTERMED { get; set; }
    public int NOFFICE { get; set; }
    public int NAGENCY { get; set; }
    public string? SCERTYPEENDOR { get; set; }
    public long? NPOLICYENDOR { get; set; }
    public string? SOBS { get; set; }
    public string? SREASON_REJECT { get; set; }
    public int NUSERCODE_REJECT { get; set; }
    public DateTime? DREJECT { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int NUSERCODE_REQ { get; set; }
}
