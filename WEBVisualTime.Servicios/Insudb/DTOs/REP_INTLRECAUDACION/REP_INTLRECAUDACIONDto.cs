namespace WEBVisualTime.Servicios.Insudb.DTOs.REP_INTLRECAUDACION;

public class REP_INTLRECAUDACIONDto
{
    public string SKEY { get; set; }
    public long NSEQ { get; set; }
    public string? SCLIENT { get; set; }
    public string? SDIGIT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NPROPONUM { get; set; }
    public int? NPRODUCT { get; set; }
    public decimal? NAMOUNT_LOCAL { get; set; }
    public decimal? NAMOUNT { get; set; }
    public long? NRECEIPT { get; set; }
    public long? NBORDEREAUX { get; set; }
    public string? SDESCRIPTOLD { get; set; }
    public string? SDESCRIPTACC { get; set; }
    public int? NSHEET { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NSTATUSREND { get; set; }
    public int? NTYPEREJEC { get; set; }
    public long? NBULLETINS { get; set; }
    public int? NSECTION { get; set; }
    public int? NORDER { get; set; }
    public long? NCERTIF { get; set; }
    public long? NBANK { get; set; }
}
