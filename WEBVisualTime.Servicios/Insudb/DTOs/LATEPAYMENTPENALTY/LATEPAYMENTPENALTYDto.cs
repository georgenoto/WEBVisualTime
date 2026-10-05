namespace WEBVisualTime.Servicios.Insudb.DTOs.LATEPAYMENTPENALTY;

public class LATEPAYMENTPENALTYDto
{
    public int NBRANCH { get; set; }
    public string? TABLE10SDESCRIPT { get; set; }
    public int NPRODUCT { get; set; }
    public string? PRODMASTERSDESCRIPT { get; set; }
    public int NDAY_INI { get; set; }
    public DateTime DEFFECTDATE { get; set; }
    public int? NDAY_END { get; set; }
    public int NDAYSPENALTY { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
