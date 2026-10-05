namespace WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCPOL;

public class CreateCLIDOCPOLDto
{
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DRECEP_DATE { get; set; }
    public DateTime? DDATEVIG { get; set; }
    public int NSTAT_DOCREQ { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLIMIT_DATE { get; set; }
    public long? NID_SECUENCIA { get; set; }
}
