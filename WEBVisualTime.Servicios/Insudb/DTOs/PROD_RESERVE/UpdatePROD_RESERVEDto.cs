namespace WEBVisualTime.Servicios.Insudb.DTOs.PROD_RESERVE;

public class UpdatePROD_RESERVEDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NTYPE_RESERVE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SROURESER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NPERCRESER { get; set; }
    public decimal? NRESEAMO { get; set; }
    public decimal? NMAXPERCENT { get; set; }
    public string? SROUTINECOST { get; set; }
    public string? SMORTALCO { get; set; }
}
