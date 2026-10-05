namespace WEBVisualTime.Servicios.Insudb.DTOs.REPORTSHEET;

public class UpdateREPORTSHEETDto
{
    public string SCODE_REPORT { get; set; }
    public int NBOX { get; set; }
    public int NCOLUMN { get; set; }
    public int NROW { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NTYP_SECTION { get; set; }
    public string? SCONTENT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
}
