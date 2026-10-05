namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_MASTER;

public class CreateCLAIM_MASTERDto
{
    public string SCLIENT { get; set; }
    public int? NCOVER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SKEY { get; set; }
    public string? SFILENAME { get; set; }
    public int? NPROVIDER { get; set; }
    public int? NOFFICE { get; set; }
    public int? NSTATUS { get; set; }
    public string? SSTATUS_PROC { get; set; }
    public int? NPAY_PROVIDER { get; set; }
}
