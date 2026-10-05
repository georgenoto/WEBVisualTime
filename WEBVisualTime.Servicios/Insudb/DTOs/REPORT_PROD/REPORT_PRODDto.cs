namespace WEBVisualTime.Servicios.Insudb.DTOs.REPORT_PROD;

public class REPORT_PRODDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SCODISPL { get; set; }
    public string? WINDOWSSCODISP { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NREPTYPE { get; set; }
    public int NTRATYPEP { get; set; }
    public string? SREPORT { get; set; }
}
