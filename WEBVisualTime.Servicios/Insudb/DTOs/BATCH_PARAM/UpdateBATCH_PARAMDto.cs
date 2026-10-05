namespace WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM;

public class UpdateBATCH_PARAMDto
{
    public int NBATCH { get; set; }
    public int NAREA { get; set; }
    public int NSEQ { get; set; }
    public string? SNAME { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
