namespace WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_DET;

public class ASCII_I_DETDto
{
    public string SASCII_NAME { get; set; }
    public string? ASCII_I_HEADSACC_NUMBER { get; set; }
    public int NID { get; set; }
    public string SCLIENT { get; set; }
    public string? CLIENTSACCOUNT_IN { get; set; }
    public string SCLIENAME { get; set; }
    public long NREQUEST_NEW { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public string SBANKACCOUNT { get; set; }
    public long NBANKEXT { get; set; }
    public string? TABLE7SDESCRIPT { get; set; }
    public int NOFF_DEST_ID { get; set; }
    public string? TABLE9SDESCRIPT { get; set; }
    public int NPAY_ID { get; set; }
    public string? TABLE9229SDESCRIPT { get; set; }
    public DateTime DDATE_PAY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
