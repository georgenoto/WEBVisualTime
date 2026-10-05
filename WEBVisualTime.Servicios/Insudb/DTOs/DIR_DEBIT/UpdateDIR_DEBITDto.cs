namespace WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT;

public class UpdateDIR_DEBITDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SACCOUNT { get; set; }
    public long NBANKEXT { get; set; }
    public string SCLIENT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SCREDI_CARD { get; set; }
    public int NTYP_CRECARD { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCARDEXPIR { get; set; }
    public string? SBANKAUTH { get; set; }
    public string SREUSE { get; set; }
    public int? NTYP_ACC { get; set; }
    public int? NSTATUS_BANKAUTH { get; set; }
    public long? NIDCOLLECT { get; set; }
    public int? NBILL_DAYINI { get; set; }
    public DateTime? DBANKAUTH { get; set; }
    public string? SDEBIT_CARD { get; set; }
    public int? NBILL_DAYEND { get; set; }
}
