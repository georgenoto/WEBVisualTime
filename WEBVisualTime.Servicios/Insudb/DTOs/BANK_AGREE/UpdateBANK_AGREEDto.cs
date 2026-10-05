namespace WEBVisualTime.Servicios.Insudb.DTOs.BANK_AGREE;

public class UpdateBANK_AGREEDto
{
    public string STYPE_BANKAGREE { get; set; }
    public long NBANK { get; set; }
    public int NACCOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCLIENT { get; set; }
    public int? NNUMDIGIT { get; set; }
    public string? SFORMAT { get; set; }
}
