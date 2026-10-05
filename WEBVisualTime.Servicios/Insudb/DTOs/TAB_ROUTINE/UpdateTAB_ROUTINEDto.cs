namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_ROUTINE;

public class UpdateTAB_ROUTINEDto
{
    public string SROUTINE { get; set; }
    public int NROUTINETYPE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
