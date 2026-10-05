namespace WEBVisualTime.Servicios.Insudb.DTOs.LIFE_SPECI;

public class CreateLIFE_SPECIDto
{
    public int NAGEEND { get; set; }
    public int NAGESTART { get; set; }
    public decimal NCAPEND { get; set; }
    public decimal NCAPSTART { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCRTHECNI { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SSEXCLIEN { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SRANDOM { get; set; }
}
