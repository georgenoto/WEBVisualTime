namespace WEBVisualTime.Servicios.Insudb.DTOs.TAX_FIXVAL;

public class CreateTAX_FIXVALDto
{
    public int NTYPESUPPORT { get; set; }
    public decimal? NPERCENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
}
