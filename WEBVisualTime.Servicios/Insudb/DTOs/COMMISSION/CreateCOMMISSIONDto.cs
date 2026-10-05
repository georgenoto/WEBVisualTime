namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMISSION;

public class CreateCOMMISSIONDto
{
    public decimal? NAMOUNT { get; set; }
    public string? SCOMMITYP { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NPERDISCOUNT { get; set; }
    public string? SPLUSCOLLEC { get; set; }
    public string? SPLUSOFFICE { get; set; }
    public string? SPLUSQUALITY { get; set; }
    public int? NAGREEMENT { get; set; }
    public decimal? NPERCENT_CE { get; set; }
    public int? NINSTALLCOM { get; set; }
    public int? NCATEGORY { get; set; }
    public int NID_CAMPAIGN { get; set; }
    public DateTime? DDATEEND_CAMP { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
