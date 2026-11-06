#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FINANCE_CO
{
    public decimal? NAMOUNT { get; set; }
    public int? NFRECUENCY { get; set; }

    [ForeignKey("NFRECUENCY")]
    public Insudb.TABLE250? TABLE250 { get; set; }
    public decimal? NAMOUNT_D { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DDATE_PRINT { get; set; }
    public decimal? NDSCTO_AMO { get; set; }
    public int? NSTAT_CONTR { get; set; }

    [ForeignKey("NSTAT_CONTR")]
    public Insudb.TABLE278? TABLE278 { get; set; }
    public DateTime? DFIRST_DRAF { get; set; }
    public decimal? NINITIAL { get; set; }
    public decimal? NINITIAL_OR { get; set; }
    public decimal? NINTEREST { get; set; }
    public DateTime? DLEDGER_DAT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string? SOPT_COMMI { get; set; }
    public string? SPAYMENT_IN { get; set; }
    public int? NQ_DRAFT { get; set; }
    public string? SWAIT_CONTR { get; set; }
    public int? NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int? NBILL_DAY { get; set; }
    public int? NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public int? NCOD_AGREE { get; set; }
    public string? STYPE_CONTR { get; set; }
    public long? NPOLICY { get; set; }
    public string? SORIGIN { get; set; }
}
