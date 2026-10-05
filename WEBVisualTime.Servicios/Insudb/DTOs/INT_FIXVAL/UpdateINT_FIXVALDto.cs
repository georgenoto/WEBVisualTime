namespace WEBVisualTime.Servicios.Insudb.DTOs.INT_FIXVAL;

public class UpdateINT_FIXVALDto
{
    public int NCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NRATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
