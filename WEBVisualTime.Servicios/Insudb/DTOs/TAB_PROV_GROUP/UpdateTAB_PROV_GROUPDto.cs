namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_GROUP;

public class UpdateTAB_PROV_GROUPDto
{
    public int NPROVIDER { get; set; }
    public int NPROV_GROUP { get; set; }
    public DateTime? DINPDATE { get; set; }
    public DateTime? DOUTDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
