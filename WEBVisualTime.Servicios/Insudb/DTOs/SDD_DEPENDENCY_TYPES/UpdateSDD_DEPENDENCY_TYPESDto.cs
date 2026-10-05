namespace WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;

public class UpdateSDD_DEPENDENCY_TYPESDto
{
    public int IRID { get; set; }
    public int IVID { get; set; }
    public string TYPE { get; set; }
    public string SYSTEM_FLAG { get; set; }
    public string TRANSITIVE { get; set; }
    public int NUMBER_OF_TIMES_MODIFIED { get; set; }
    public DateTime DATE_CREATED { get; set; }
    public string CREATED_BY { get; set; }
    public DateTime? DATE_CHANGED { get; set; }
    public string? CHANGED_BY { get; set; }
    public string? SUBTYPE { get; set; }
}
