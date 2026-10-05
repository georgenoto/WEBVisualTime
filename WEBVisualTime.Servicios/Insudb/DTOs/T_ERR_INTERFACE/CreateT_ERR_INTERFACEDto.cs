namespace WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_INTERFACE;

public class CreateT_ERR_INTERFACEDto
{
    public long NERROR { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SCERTYPE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public string? SCLIENT { get; set; }
    public long? NCLAIM { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
