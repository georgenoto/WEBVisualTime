namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_BILL_I;

public class UpdateTAB_BILL_IDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NBILL_ITEM { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SSHORT_DES { get; set; }
    public int? NUSERCODE { get; set; }
}
