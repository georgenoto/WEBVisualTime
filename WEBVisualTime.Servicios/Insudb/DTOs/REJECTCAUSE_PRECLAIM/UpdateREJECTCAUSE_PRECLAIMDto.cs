namespace WEBVisualTime.Servicios.Insudb.DTOs.REJECTCAUSE_PRECLAIM;

public class UpdateREJECTCAUSE_PRECLAIMDto
{
    public long NIDPRECLAIM { get; set; }
    public int NREJECT_CAUSE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SMESSAGE_REJECT { get; set; }
}
