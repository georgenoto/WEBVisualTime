namespace WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_DET;

public class CreateASCII_I_DETDto
{
    public string SCLIENT { get; set; }
    public string SCLIENAME { get; set; }
    public long NREQUEST_NEW { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public string SBANKACCOUNT { get; set; }
    public long NBANKEXT { get; set; }
    public int NOFF_DEST_ID { get; set; }
    public DateTime DDATE_PAY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
