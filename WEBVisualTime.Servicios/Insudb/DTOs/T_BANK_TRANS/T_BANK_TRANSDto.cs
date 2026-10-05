namespace WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_TRANS;

public class T_BANK_TRANSDto
{
    public long NBORDEREAUX { get; set; }
    public string? COLFORMREFSTYPE { get; set; }
    public int NSEQUENCE { get; set; }
    public int? NACC_BANK { get; set; }
    public int? NACC_TYPE { get; set; }
    public string? SACCO_NUM { get; set; }
    public long? NBANK_CODE { get; set; }
    public long? NBK_AGENCY { get; set; }
    public string? SCLIENT { get; set; }
    public long? NMOVEMENT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public string? SACTION { get; set; }
}
