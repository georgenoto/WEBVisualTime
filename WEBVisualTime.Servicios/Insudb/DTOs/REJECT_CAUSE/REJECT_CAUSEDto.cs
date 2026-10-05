namespace WEBVisualTime.Servicios.Insudb.DTOs.REJECT_CAUSE;

public class REJECT_CAUSEDto
{
    public int NREJECTCAUSE { get; set; }
    public long NBANK_CODE { get; set; }
    public int NWAY_PAY { get; set; }
    public string? TABLE5002SDESCRIPT { get; set; }
    public string SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SNO_ENDEAVOUR { get; set; }
}
