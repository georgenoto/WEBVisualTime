namespace WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_I;

public class UpdateHIS_ASC_IDto
{
    public int NID { get; set; }
    public string SASCII_NAME { get; set; }
    public string SPAY_FORM { get; set; }
    public long NBANK_CODE { get; set; }
    public int NCONCEPT { get; set; }
    public DateTime DSTAT_DATE { get; set; }
    public string SACC_NUMBER { get; set; }
    public int NAGENCY { get; set; }
    public string SCLIENT { get; set; }
    public string SACCOUNTHOLDER { get; set; }
    public long NREQUEST_NU { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public string SBANKACCOUNT { get; set; }
    public long NBANKEXT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
