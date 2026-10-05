namespace WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;

public class UpdateNOTIFICA_ERPDto
{
    public string SPROCESO { get; set; }
    public string SKEY { get; set; }
    public string SESTADO { get; set; }
    public DateTime DFECHA_PROCESO { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DOPERDATE { get; set; }
}
