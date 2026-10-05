#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FREQ_WAY_PROD
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public int NPAYFREQ { get; set; }

    [ForeignKey("NPAYFREQ")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NPRE_ISSUE { get; set; }
    public decimal? NPRE_AMEND { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NLIMIT_EXCTAX { get; set; }
    public int? NQPREM_BAS_ANN { get; set; }
    public string? SIVA_COVER_IND { get; set; }
    public string? SNO_SELL { get; set; }
    public decimal? NPRE_COVEREXT { get; set; }
    public decimal? NPRE_ISSUEMAX { get; set; }
    public decimal? NDISC_PAYMETH { get; set; }
}
