namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_EXC;

public class CreateTAB_AM_EXCDto
{
    public string? SCLIENT { get; set; }
    public int? NEXC_CODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DINIT_DATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DEND_DATE { get; set; }
    public string? STYPE_EXC { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public string? SPREEXISTING { get; set; }
    public string? SCARENCY { get; set; }
    public string? SPERMANENT { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NMOVEMENT { get; set; }
    public string? SSEL { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
