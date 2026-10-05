namespace WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_P;

public class DISC_XPRE_PDto
{
    public string SCERTYPE { get; set; }
    public string? POLICYSCERTYPESACCOUNTI { get; set; }
    public int NBRANCH { get; set; }
    public string? POLICYNBRANCHSACCOUNTI { get; set; }
    public int NPRODUCT { get; set; }
    public string? POLICYNPRODUCTSACCOUNTI { get; set; }
    public long NPOLICY { get; set; }
    public string? POLICYNPOLICYSACCOUNTI { get; set; }
    public int NDISC_CODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NPERCENT { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
