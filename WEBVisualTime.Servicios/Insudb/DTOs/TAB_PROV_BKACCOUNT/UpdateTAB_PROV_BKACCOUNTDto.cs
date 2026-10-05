namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_BKACCOUNT;

public class UpdateTAB_PROV_BKACCOUNTDto
{
    public int NPROVIDER { get; set; }
    public long NBANKEXT { get; set; }
    public string SACCOUNT { get; set; }
    public int NTYP_ACC { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SDEPOSIT { get; set; }
    public string? SCLIENTR { get; set; }
    public int? NCURRENCY { get; set; }
}
