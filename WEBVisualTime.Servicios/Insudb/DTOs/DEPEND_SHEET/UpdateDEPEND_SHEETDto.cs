namespace WEBVisualTime.Servicios.Insudb.DTOs.DEPEND_SHEET;

public class UpdateDEPEND_SHEETDto
{
    public long NSHEET_FATHER { get; set; }
    public long NSHEET_CHILD { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
