namespace WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;

public class CreateCASH_ACCDto
{
    public int NLED_COMPAN { get; set; }
    public string? SACCOUNT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NAVAILABLE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SSTATREGT { get; set; }
    public decimal? NMIN_AMOUNT { get; set; }
    public int NCOMPANY { get; set; }
    public int? NTYPECASH { get; set; }
}
