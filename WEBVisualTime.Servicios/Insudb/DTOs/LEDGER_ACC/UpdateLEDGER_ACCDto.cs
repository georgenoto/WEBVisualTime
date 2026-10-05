namespace WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;

public class UpdateLEDGER_ACCDto
{
    public int NLED_COMPAN { get; set; }
    public string SACCOUNT { get; set; }
    public string SAUX_ACCOUN { get; set; }
    public string? SADJU_EXCI { get; set; }
    public int? NAUX_CREATE { get; set; }
    public decimal? NBALANCE { get; set; }
    public string? SBLOCK_CRE { get; set; }
    public string? SBLOCK_DEB { get; set; }
    public string? SBUDGET_IND { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SORGAN_UNIT { get; set; }
    public string? SSTATREGT { get; set; }
    public decimal? NTOTAL_CRE { get; set; }
    public decimal? NTOTAL_DEB { get; set; }
    public string? STYPE_ACC { get; set; }
    public int? NUSERCODE { get; set; }
}
