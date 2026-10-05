namespace WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_EVAL_ROL;

public class UpdateMEDICAL_EVAL_ROLDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NROLE { get; set; }
    public string SCLIENT { get; set; }
    public int NMEDICALSTAT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NMONTHS { get; set; }
}
