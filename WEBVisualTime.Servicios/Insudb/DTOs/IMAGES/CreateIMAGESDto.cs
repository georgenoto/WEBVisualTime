namespace WEBVisualTime.Servicios.Insudb.DTOs.IMAGES;

public class CreateIMAGESDto
{
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public byte[]? IIMAGE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NRECTYPE { get; set; }
    public int NUSERCODE { get; set; }
}
