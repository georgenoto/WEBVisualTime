namespace WEBVisualTime.Servicios.Insudb.DTOs.MEDICALFEES;

public class UpdateMEDICALFEESDto
{
    public int NIDMEDICALFEE { get; set; }
    public string SBENEFITCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NVALUE { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SHOMOLOG_BENEFIT { get; set; }
}
