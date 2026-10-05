namespace WEBVisualTime.Servicios.Insudb.DTOs.CRED_CARD;

public class UpdateCRED_CARDDto
{
    public string SCLIENT { get; set; }
    public long NBANKEXT { get; set; }
    public string SCREDI_CARD { get; set; }
    public int NCARD_TYPE { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCARDEXPIR { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public int? NCURRENCY { get; set; }
}
