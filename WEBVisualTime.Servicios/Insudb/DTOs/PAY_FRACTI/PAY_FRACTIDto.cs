namespace WEBVisualTime.Servicios.Insudb.DTOs.PAY_FRACTI;

public class PAY_FRACTIDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NPAYFREQ { get; set; }
    public string? TABLE36SDESCRIPT { get; set; }
    public int NQUOTA { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NRATEPAYF { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
}
