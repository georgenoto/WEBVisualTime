namespace WEBVisualTime.Servicios.Insudb.DTOs.REP_ERROR;

public class REP_ERRORDto
{
    public string? SPROCESS_NAME { get; set; }
    public int? SSQLCODE { get; set; }
    public string? SSQLERRM { get; set; }
    public string? SDESCRIPTION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NORDER { get; set; }
}
