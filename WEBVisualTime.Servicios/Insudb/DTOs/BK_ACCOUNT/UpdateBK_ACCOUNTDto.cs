namespace WEBVisualTime.Servicios.Insudb.DTOs.BK_ACCOUNT;

public class UpdateBK_ACCOUNTDto
{
    public long NBANKEXT { get; set; }
    public string SACCOUNT { get; set; }
    public int? NTYP_ACC { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SDEPOSIT { get; set; }
    public string SCLIENT { get; set; }
    public int? NCURRENCY { get; set; }
}
