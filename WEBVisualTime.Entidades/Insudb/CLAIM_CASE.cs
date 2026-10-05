#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_CASE
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SSTACASE { get; set; }

    [ForeignKey("SSTACASE")]
    public Insudb.TABLE135? TABLE135 { get; set; }
    public long? NNOTEDAMA { get; set; }
    public string? SCLAIM_AFFE { get; set; }
    public decimal? NGROWTH_RATEI { get; set; }
    public decimal? NGROWTH_RATEE { get; set; }
    public decimal? NAPV_CAPITAL { get; set; }
    public DateTime? DSUMMON_LIMIT { get; set; }
    public string? SHAS_SURV_PENSION_BENEFS { get; set; }
    public DateTime? DSUMMON { get; set; }
    public string? SAFP_TRANS_TYPE { get; set; }
    public decimal? NSTAY_BONUS { get; set; }
    public decimal? NAPV_BALANCE_BC2052 { get; set; }
    public decimal? NAPV_BALANCE_AC2052 { get; set; }
    public decimal? NTRANSF_AMOUNT { get; set; }
    public decimal? NAPV_TAX { get; set; }
    public decimal? NAPV_BENEF_BALANCE { get; set; }
    public long NAFP { get; set; }

    [ForeignKey("NAFP")]
    public Insudb.TABLE5524? TABLE5524 { get; set; }
    public int? NSENDTO_LGM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE136? TABLE136 { get; set; }
}
