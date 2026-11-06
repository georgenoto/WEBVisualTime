namespace WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT_CLI;

public class UpdateDIR_DEBIT_CLIDto
{
    public string SCLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SACCOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NBANKEXT { get; set; }
    public string? SBANKAUTH { get; set; }
    public int NBILL_DAY { get; set; }
    public int? NSTATUS_BANKAUTH { get; set; }
}
