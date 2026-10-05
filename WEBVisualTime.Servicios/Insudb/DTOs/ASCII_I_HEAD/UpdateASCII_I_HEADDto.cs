namespace WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;

public class UpdateASCII_I_HEADDto
{
    public string SASCII_NAME { get; set; }
    public long NBANK_CODE { get; set; }
    public int NCONCEPT { get; set; }
    public DateTime DSTAT_DATE { get; set; }
    public string SACC_NUMBER { get; set; }
    public int NAGENCY { get; set; }
    public string? SSTATMOV { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPAY_FORM { get; set; }
}
