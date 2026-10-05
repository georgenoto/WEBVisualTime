namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_CONTACT;

public class UpdateTAB_PROV_CONTACTDto
{
    public int NPROVIDER { get; set; }
    public int NSEQ { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NPOSITION { get; set; }
    public string? SNAME_CONTACT { get; set; }
    public string? SE_MAIL { get; set; }
    public string? SPHONE_CONTACT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
