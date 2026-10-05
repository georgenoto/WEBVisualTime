namespace WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCPOL;

public class CLIDOCPOLDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NROLE { get; set; }
    public string? TABLE12SDESCRIPT { get; set; }
    public string SCLIENT { get; set; }
    public int NCLASSTYPDOC { get; set; }
    public string? FORMATVALUESNCLASSTYPDOCSDESCRIPT { get; set; }
    public int NTYPCLIENTDOC { get; set; }
    public string? FORMATVALUESNTYPCLIENTDOCSDESCRIPT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DRECEP_DATE { get; set; }
    public DateTime? DDATEVIG { get; set; }
    public int NSTAT_DOCREQ { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLIMIT_DATE { get; set; }
    public long? NID_SECUENCIA { get; set; }
}
