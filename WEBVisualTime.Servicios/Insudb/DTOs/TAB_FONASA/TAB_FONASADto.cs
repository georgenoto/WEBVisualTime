namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_FONASA;

public class TAB_FONASADto
{
    public int NYEAR { get; set; }
    public string SSERVICE { get; set; }
    public string SSUBSERVICE { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public string? USERSSACCESSWO { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
}
