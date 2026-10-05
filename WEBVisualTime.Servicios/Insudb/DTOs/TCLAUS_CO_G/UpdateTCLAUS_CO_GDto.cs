namespace WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_G;

public class UpdateTCLAUS_CO_GDto
{
    public string SKEY { get; set; }
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public int NGROUP { get; set; }
    public int NCLAUSE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? STYPE_CLAUSE { get; set; }
    public string? SDOC_ATTACH { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public string? SMODIFIED { get; set; }
    public string? SSELECTED { get; set; }
    public string? IND_INPOLICY { get; set; }
}
