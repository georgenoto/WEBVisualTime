namespace WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;

public class CreateSDD_DEPEND_STATUSESDto
{
    public string DESCRIPTION { get; set; }
    public string SYSTEM_FLAG { get; set; }
    public int NUMBER_OF_TIMES_MODIFIED { get; set; }
    public DateTime DATE_CREATED { get; set; }
    public string CREATED_BY { get; set; }
    public DateTime? DATE_CHANGED { get; set; }
    public string? CHANGED_BY { get; set; }
}
