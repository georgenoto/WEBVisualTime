#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class QC_PARAM
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NBRANCH, NPRODUCT")]
    public Insudb.PRODMASTER? PRODMASTER { get; set; }
    public string SPOLITYPE { get; set; }
    public long NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SINDQCOBL { get; set; }
    public int? NROUTY_QC { get; set; }

    [ForeignKey("NROUTY_QC")]
    public Insudb.TABLE9105? TABLE9105NROUTY_QC { get; set; }
    public string? SROUT_QC { get; set; }

    [ForeignKey("SROUT_QC, NROUTY_QC")]
    public Insudb.TAB_ROUTINE? TAB_ROUTINESROUT_QC { get; set; }
    public int? NROUTY_QCCAP { get; set; }

    [ForeignKey("NROUTY_QCCAP")]
    public Insudb.TABLE9105? TABLE9105NROUTY_QCCAP { get; set; }
    public string? SROUT_QCCAP { get; set; }

    [ForeignKey("SROUT_QCCAP, NROUTY_QCCAP")]
    public Insudb.TAB_ROUTINE? TAB_ROUTINESROUT_QCCAP { get; set; }
    public int? NMINAGEQC { get; set; }
    public decimal? NCAPMINCC { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREG { get; set; }
    public int? NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
