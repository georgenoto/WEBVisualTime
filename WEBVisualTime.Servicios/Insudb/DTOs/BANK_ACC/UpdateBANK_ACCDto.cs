namespace WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;

public class UpdateBANK_ACCDto
{
    public int NACC_BANK { get; set; }
    public string? SACC_LEDGER { get; set; }
    public long NBANK_CODE { get; set; }
    public long NBK_AGENCY { get; set; }
    public string? SACC_NUMBER { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public int NACC_TYPE { get; set; }
    public decimal? NAVAILABLE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NAVAIL_TYPE { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public int? NLED_COMPAN { get; set; }
    public int? NOFFICE { get; set; }
    public decimal? NTRANSIT_1 { get; set; }
    public decimal? NTRANSIT_2 { get; set; }
    public decimal? NTRANSIT_3 { get; set; }
    public decimal? NTRANSIT_4 { get; set; }
    public decimal? NTRANSIT_5 { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SSTATREGT { get; set; }
    public int NCOMPANY { get; set; }
    public DateTime? DREALDEP { get; set; }
}
