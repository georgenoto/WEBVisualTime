namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_SHORT_G;

public class UpdateTAB_SHORT_GDto
{
    public int NMONTHMAX { get; set; }
    public int NDAYSMAX { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NRATEDEVO { get; set; }
    public decimal? NRATEPREM { get; set; }
    public int? NUSERCODE { get; set; }
}
