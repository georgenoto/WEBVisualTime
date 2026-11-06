namespace WEBVisualTime.Servicios.Insudb.DTOs.STIPEND_POL;

public class CreateSTIPEND_POLDto
{
    public int NUSERCODE { get; set; }
    public string? SCOMMITYP { get; set; }
    public long? NCONTRAT_PAY { get; set; }
    public long? NINTERMED { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
}
