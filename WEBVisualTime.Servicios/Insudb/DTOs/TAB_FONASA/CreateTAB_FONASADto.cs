namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_FONASA;

public class CreateTAB_FONASADto
{
    public DateTime? DNULLDATE { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
}
