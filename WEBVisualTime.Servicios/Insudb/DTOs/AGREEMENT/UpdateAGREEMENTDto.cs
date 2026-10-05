namespace WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;

public class UpdateAGREEMENTDto
{
    public string SCLIENT { get; set; }
    public int NCOD_AGREE { get; set; }
    public int? NQ_DRAFT { get; set; }
    public decimal? NMAX_PERC_DCTO { get; set; }
    public DateTime? DINIT_DATE { get; set; }
    public DateTime? DEND_DATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public int NTYPEAGREE { get; set; }
    public int NTYPE_REC { get; set; }
    public long NINTERMED { get; set; }
    public int NAGENCY { get; set; }
    public string? SEMAIL_CONTACT { get; set; }
    public string? SPHONE_CONTACT { get; set; }
    public string? SCLIENAME { get; set; }
    public string? SFIRSTNAME { get; set; }
    public string? SLASTNAME { get; set; }
    public int? NPOSITION { get; set; }
    public string? SEMAILA_CONTACT { get; set; }
    public string? SPHONEA_CONTACT { get; set; }
    public string? SPHONEFAX { get; set; }
    public string? SNAME_AGREE { get; set; }
    public string? SNOCOLLECTION { get; set; }
    public long? NIMAGENUM { get; set; }
    public int? NPROV_GROUP { get; set; }
    public int? NPROVIDER { get; set; }
}
