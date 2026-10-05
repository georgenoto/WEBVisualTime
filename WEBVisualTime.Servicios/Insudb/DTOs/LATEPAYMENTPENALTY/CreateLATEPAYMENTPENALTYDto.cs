namespace WEBVisualTime.Servicios.Insudb.DTOs.LATEPAYMENTPENALTY;

public class CreateLATEPAYMENTPENALTYDto
{
    public int? NDAY_END { get; set; }
    public int NDAYSPENALTY { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
