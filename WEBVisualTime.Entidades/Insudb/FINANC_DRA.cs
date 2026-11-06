#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FINANC_DRA
{
    public decimal? NAMOUNT { get; set; }
    public int? NSTAT_DRAFT { get; set; }

    [ForeignKey("NSTAT_DRAFT")]
    public Insudb.TABLE253? TABLE253 { get; set; }
    public decimal? NAMOUNT_NET { get; set; }
    public long? NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public decimal? NCOMMISSION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public int NDRAFT { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NINTAMMOU { get; set; }
    public int? NSTATPRINT { get; set; }

    [ForeignKey("NSTATPRINT")]
    public Insudb.TABLE282? TABLE282 { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public DateTime? DSTAT_DATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public long? NBULLETINS { get; set; }
    public decimal? NAMO_AFEC { get; set; }
    public decimal? NAMO_EXEN { get; set; }
    public decimal? NIVA { get; set; }
    public decimal? NCOM_AFEC { get; set; }
    public decimal? NCOM_EXEN { get; set; }
    public DateTime DLIMITDATE { get; set; }
    public long? NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public string? SINDCHEQUE { get; set; }
    public DateTime? DCOLLSUS_INI { get; set; }
    public DateTime? DCOLLSUS_END { get; set; }
    public int? NSUS_REASON { get; set; }

    [ForeignKey("NSUS_REASON")]
    public Insudb.TABLE5566? TABLE5566 { get; set; }
    public string? SSUS_ORIGI { get; set; }
    public long? NCOLLECTOR { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SBILLTYPE { get; set; }
    public int? NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public string? SDOCNUMBE { get; set; }
    public int? NRETENTIONTAXCODE { get; set; }
    public int? NRETENTIONCODE { get; set; }
    public string? NRETENTIONSERIES { get; set; }
    public DateTime? DAUTORIZATIONDATE { get; set; }
    public DateTime? DENDINGDATE { get; set; }
    public decimal? NRETENTION { get; set; }
    public decimal? NTAXRETENTION { get; set; }
    public decimal? NRETENTIONBASE { get; set; }
    public string? NAUTORIZATIONNUMBER { get; set; }
    public decimal? NEMISRIGHT { get; set; }
    public decimal? NIVA_SSC { get; set; }
    public decimal? NIVA_SBK { get; set; }
    public decimal? NIVA_OTHER { get; set; }
    public decimal? NIVA_OTHER_DESC { get; set; }
    public decimal? NIVA_OTHER_DESCOMPEN { get; set; }
    public decimal? NIVA_PERCENT { get; set; }
    public long? NBORDEREAUX_ADV { get; set; }
}
