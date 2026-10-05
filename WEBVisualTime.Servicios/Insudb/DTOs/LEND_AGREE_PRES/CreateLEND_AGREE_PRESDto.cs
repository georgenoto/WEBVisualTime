namespace WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PRES;

public class CreateLEND_AGREE_PRESDto
{
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
