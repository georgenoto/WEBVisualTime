namespace WEBVisualTime.Servicios.Insudb.DTOs.TYPE_AMEND;

public class CreateTYPE_AMENDDto
{
    public DateTime? DNULLDATE { get; set; }
    public string? SIND_ORDER_SERV { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NTYPEISSUE { get; set; }
    public int NLEVEL { get; set; }
    public string? SRETARIF { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NTYPE_EV_ENDOR { get; set; }
    public string? SRESOLUTION { get; set; }
    public string? SGOVAPRNAME { get; set; }
    public DateTime? DRESDATE { get; set; }
    public string? SCONDSVS { get; set; }
    public int? NTYPEA_AMEND { get; set; }
    public string SSHOWSTATUS { get; set; }
}
