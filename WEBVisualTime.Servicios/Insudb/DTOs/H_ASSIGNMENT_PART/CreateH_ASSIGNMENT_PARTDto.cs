namespace WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;

public class CreateH_ASSIGNMENT_PARTDto
{
    public int NINSUR_AREA { get; set; }
    public int NINTERTYP { get; set; }
    public int NTYPE_ASSIGN { get; set; }
    public DateTime DATE_ASSIG_INI { get; set; }
    public DateTime? DATE_ASSIG_END { get; set; }
    public long NINTERMED { get; set; }
    public int? NTEMPASSI { get; set; }
    public string? STEMPASSI { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
