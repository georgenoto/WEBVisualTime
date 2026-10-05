namespace WEBVisualTime.Servicios.Insudb.DTOs.SCHE_TRANSAC;

public class UpdateSCHE_TRANSACDto
{
    public string SSCHE_CODE { get; set; }
    public string SCODISPL { get; set; }
    public int NTRANSAC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SPAY_FORM { get; set; }
    public int NTYPE_AMEND { get; set; }
    public long NID { get; set; }
}
