namespace WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;

public class UpdateCONTRMASTERDto
{
    public int NTYPE_REL { get; set; }
    public int NNUMBER { get; set; }
    public int NTYPE { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public int NBRANCH { get; set; }
    public int NCURRENCY { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NCURR_PAY { get; set; }
    public string? SFORMPAY { get; set; }
}
