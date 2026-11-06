namespace WEBVisualTime.Servicios.Insudb.DTOs.LIFE_DOCU;

public class CreateLIFE_DOCUDto
{
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DRECEP_DATE { get; set; }
    public int? NSTAT_DOCREQ { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DDATE_TO { get; set; }
    public DateTime? DDATEFREE { get; set; }
    public long? NEVAL { get; set; }
    public DateTime? DDATEVIG { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SREQUEST { get; set; }
    public int? NREASON { get; set; }
    public string? SRANDOM { get; set; }
    public long? NID_SECUENCIA { get; set; }
}
