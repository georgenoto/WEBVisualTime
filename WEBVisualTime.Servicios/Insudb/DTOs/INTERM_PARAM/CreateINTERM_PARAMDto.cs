namespace WEBVisualTime.Servicios.Insudb.DTOs.INTERM_PARAM;

public class CreateINTERM_PARAMDto
{
    public decimal NINSU_ASSIST { get; set; }
    public decimal? NSOAP_AGENT { get; set; }
    public decimal? NSOAP_SUPERVIS { get; set; }
    public int? NBONUS_CURR { get; set; }
    public decimal? NMAX_BONUS { get; set; }
    public decimal? NMAX_ACCOMP { get; set; }
    public decimal? NMINAMOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NDAY_DISCLOAN { get; set; }
}
