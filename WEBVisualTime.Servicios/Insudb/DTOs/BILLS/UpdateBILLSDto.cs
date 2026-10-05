namespace WEBVisualTime.Servicios.Insudb.DTOs.BILLS;

public class UpdateBILLSDto
{
    public int NINSUR_AREA { get; set; }
    public string SBILLTYPE { get; set; }
    public string SBILLING { get; set; }
    public long NBILLNUM { get; set; }
    public int NCURRENCY { get; set; }
    public string SCLIENT { get; set; }
    public decimal NAMOUNT { get; set; }
    public decimal? NAMO_AFEC { get; set; }
    public decimal? NAMO_EXEN { get; set; }
    public decimal? NIVA { get; set; }
    public long? NCRE_NOTE { get; set; }
    public long? NNEWBILL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NBILLSTAT { get; set; }
    public DateTime DSTATDATE { get; set; }
    public DateTime? DVALDATE { get; set; }
    public string? SKEYADDRESS { get; set; }
    public int? NRECOWNER { get; set; }
    public string? SBILL_IND { get; set; }
    public string? SORIGIN { get; set; }
    public long? NPREVBILL { get; set; }
    public DateTime? DISSUEDAT { get; set; }
    public string? SBILLFULLNUM { get; set; }
    public string? SAUTHORIZATION { get; set; }
    public long? NRUCPRINT { get; set; }
    public long? NIDTRANSACTION { get; set; }
    public string? SBILLNUMSFE { get; set; }
    public long? NBORDEREAUX { get; set; }
    public long? NPOLICY { get; set; }
    public int? NNULLCODE { get; set; }
    public long? NCERTIF { get; set; }
    public long? NRECEIPTCORP { get; set; }
}
