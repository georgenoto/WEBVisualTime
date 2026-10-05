namespace WEBVisualTime.Servicios.Insudb.DTOs.SDD_NLS_GLOBAL_NAME_DOMAINS;

public class SDD_NLS_GLOBAL_NAME_DOMAINSDto
{
    public int IRID { get; set; }
    public int IVID { get; set; }
    public string NLS_NAME { get; set; }
    public string NLS_PLURAL_NAME { get; set; }
    public string NLS_LANG { get; set; }
    public int GND_IRID { get; set; }
    public string? SDD_GLOBAL_NAME_DOMAINSNAME { get; set; }
    public int NUMBER_OF_TIMES_MODIFIED { get; set; }
    public DateTime DATE_CREATED { get; set; }
    public string CREATED_BY { get; set; }
    public DateTime? DATE_CHANGED { get; set; }
    public string? CHANGED_BY { get; set; }
}
