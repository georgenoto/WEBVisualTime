namespace WEBVisualTime.Servicios.Insudb.DTOs.CONTR_LIMCOV;

public class CreateCONTR_LIMCOVDto
{
    public DateTime? DNULLDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NLINES { get; set; }
    public decimal? NQUOTA_SHA { get; set; }
    public string? SROUTINE { get; set; }
    public int? NCOVERAPP { get; set; }
    public decimal? NPERCENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NMAXAMOUNT { get; set; }
}
