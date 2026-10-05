namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_MEDSPEC;

public class UpdateTAB_PROV_MEDSPECDto
{
    public int NPROVIDER { get; set; }
    public string SMEDSPECIALIALTY { get; set; }
    public int NMAIN_MEDSPECIALIALTY { get; set; }
    public string? SREG_MEDICALPROF { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
