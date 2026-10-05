namespace WEBVisualTime.Servicios.Insudb.DTOs.LOGBILLS;

public class CreateLOGBILLSDto
{
    public int NCURRENCY { get; set; }
    public decimal NAMOUNT { get; set; }
    public DateTime DSTATDATE { get; set; }
    public int NSTATUSCODE { get; set; }
    public string? SSTATUSDESC { get; set; }
    public string SBILLNUMSFE { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SPROCESSED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NRECEIPTCORP { get; set; }
}
