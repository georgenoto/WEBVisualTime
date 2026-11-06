#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_DOCTYP
{
    public string SSEL { get; set; }
    public long NBORDEREAUX { get; set; }
    public int NSEQUENCE { get; set; }
    public int NCOLLECDOCTYP { get; set; }

    [ForeignKey("NCOLLECDOCTYP")]
    public Insudb.TABLE5587? TABLE5587 { get; set; }
    public long NDOCUMENT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public long? NCONTRAT { get; set; }
    public int? NDRAFT { get; set; }
    public string? SCLIENT { get; set; }
    public long? NBULLETINS { get; set; }
    public long? NPROPONUM { get; set; }
    public int? NTYPEMOVE { get; set; }

    [ForeignKey("NTYPEMOVE")]
    public Insudb.TABLE5525? TABLE5525 { get; set; }
    public DateTime? DMOVDATE { get; set; }
    public int? NTYPE { get; set; }
    public int? NTRATYPEI { get; set; }

    [ForeignKey("NTRATYPEI")]
    public Insudb.TABLE24? TABLE24 { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public decimal? NAMOUNTCOL { get; set; }
    public decimal? NAMOUNTPAY { get; set; }
    public decimal? NPAYSOONDISC { get; set; }
    public decimal? NINTEREST_RATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public string? SMANAUTI { get; set; }
    public int? NSTATUS_PRE { get; set; }
    public decimal? NCOMAMOU { get; set; }
    public decimal? NPARTICIP { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long? NINTERMED { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NCASH_MOV { get; set; }
    public DateTime? DPOSTED { get; set; }
    public string? STYPE_DETAI { get; set; }
    public decimal? NCOMMI_RATE { get; set; }
    public int? NINTERTYP { get; set; }
    public decimal? NRATE_DISC { get; set; }
    public decimal? NNOM_VALBON { get; set; }
    public DateTime? DISSUEDATBON { get; set; }
    public DateTime? DEXPIRDATBON { get; set; }
    public decimal? NTAX { get; set; }
    public int? NORIGIN { get; set; }

    [ForeignKey("NORIGIN")]
    public Insudb.TABLE5633? TABLE5633 { get; set; }
    public DateTime? DDATE_ORIGIN { get; set; }
    public int? NINSTITUTION { get; set; }

    [ForeignKey("NINSTITUTION")]
    public Insudb.TAB_FN_INSTITUTION? TAB_FN_INSTITUTION { get; set; }
    public int? NCHANGESDAT { get; set; }
    public DateTime? DVALUEDATE { get; set; }
    public long? NCOLLECTOR { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
    public long? NLOANS { get; set; }
    public long? NTYP_PROFITWORKER { get; set; }
    public string? SNEWRECEIPT { get; set; }
    public long? NCOD_SAAPV { get; set; }
    public string? SFOLIONUMBER { get; set; }
    public string? SBILLADVANCE { get; set; }
    public DateTime? DLIMITDATE { get; set; }
}
