namespace WEBVisualTime.Servicios.Insudb.DTOs.REPORT_PROD;

public class CreateREPORT_PRODDto
{
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NREPTYPE { get; set; }
    public string? SREPORT { get; set; }
}
