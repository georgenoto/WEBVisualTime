namespace WEBVisualTime.Servicios.Insudb.DTOs.MEDICALBENEFITS;

public class CreateMEDICALBENEFITSDto
{
    public string STYPEBENEFIT { get; set; }
    public string SBENEFITCLAS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public long NIND_PACKAGE { get; set; }
}
