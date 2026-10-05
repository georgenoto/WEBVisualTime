namespace WEBVisualTime.Servicios.Insudb.DTOs.SIGNSCAPOFF;

public class UpdateSIGNSCAPOFFDto
{
    public int NBRANCH { get; set; }
    public int NOFFICE { get; set; }
    public int NCURRENCY { get; set; }
    public int NUSERSIGN { get; set; }
    public int NORDSIGN { get; set; }
    public decimal NCAPMINSING { get; set; }
    public decimal NCAPMAXSING { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SSTATREG { get; set; }
}
