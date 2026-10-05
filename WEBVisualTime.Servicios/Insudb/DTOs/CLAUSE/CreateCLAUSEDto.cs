namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAUSE;

public class CreateCLAUSEDto
{
    public DateTime? DCOMPDATE { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCLIENT { get; set; }
    public int? NGROUP_INSU { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public int? NCAUSE { get; set; }
    public string SAGREE { get; set; }
    public string? STYPE_CLAUSE { get; set; }
    public string? SDOC_ATTACH { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
