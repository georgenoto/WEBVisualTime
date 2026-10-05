namespace WEBVisualTime.Servicios.Insudb.DTOs.CONTRAT_PAY;

public class CONTRAT_PAYDto
{
    public long NCONTRAT_PAY { get; set; }
    public int NTYPE_CONTRAT { get; set; }
    public string? STYP_COM_IND { get; set; }
    public int? NCOM_TABNUM { get; set; }
    public string? SCLIENT { get; set; }
    public string SDESCRIPT { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public int NTYPE_CALC { get; set; }
    public string? TABLE8100SDESCRIPT { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public int NAPLY { get; set; }
    public string? TABLE8101SDESCRIPT { get; set; }
    public string? STAXIN { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTYP_ACCO { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public string? SROUTINE { get; set; }
    public DateTime? DLASTCALCULATED { get; set; }
}
