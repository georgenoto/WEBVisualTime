namespace WEBVisualTime.Servicios.Insudb.DTOs.CHARG_PREBASPAY;

public class CreateCHARG_PREBASPAYDto
{
    public int? NAGE_END { get; set; }
    public int? NMONTH_END { get; set; }
    public int? NTYPE_CHARG { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NRATE_PPIN { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SAPLYQUOT { get; set; }
}
