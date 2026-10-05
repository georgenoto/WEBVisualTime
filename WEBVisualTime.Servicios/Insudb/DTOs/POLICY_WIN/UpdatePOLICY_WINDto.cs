namespace WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN;

public class UpdatePOLICY_WINDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SV_CONPOLIC { get; set; }
    public string? SV_WINPOLIC { get; set; }
}
