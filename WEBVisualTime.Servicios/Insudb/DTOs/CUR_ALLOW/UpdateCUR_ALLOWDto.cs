namespace WEBVisualTime.Servicios.Insudb.DTOs.CUR_ALLOW;

public class UpdateCUR_ALLOWDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
}
