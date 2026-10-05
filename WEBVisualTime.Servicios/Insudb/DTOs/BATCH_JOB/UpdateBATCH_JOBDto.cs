namespace WEBVisualTime.Servicios.Insudb.DTOs.BATCH_JOB;

public class UpdateBATCH_JOBDto
{
    public string SKEY { get; set; }
    public int NBATCH { get; set; }
    public DateTime? DSTART { get; set; }
    public DateTime? DEND { get; set; }
    public int? NSTATUS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCOMMAND { get; set; }
    public DateTime? DSUBMIT { get; set; }
    public long? NORAJOB { get; set; }
    public int? NUSERSUBMIT { get; set; }
    public int? NSHEET { get; set; }
    public string? SKEY_FATHER { get; set; }
    public string? SOUTPUTFILE { get; set; }
    public string? SFILE { get; set; }
    public string? SVERIFIED_PLA { get; set; }
}
