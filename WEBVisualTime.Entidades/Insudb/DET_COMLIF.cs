#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DET_COMLIF
{
    public int NCOMTABLI { get; set; }

    [ForeignKey("NCOMTABLI")]
    public Insudb.TAB_COMLIF? TAB_COMLIF { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }
    public int NPOLICY_DUR { get; set; }
    public int NMIN_DURAT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NWAY_PAY { get; set; }
    public int NSELLCHANNEL { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NCOVER { get; set; }
    public int? NMAX_DURAT { get; set; }
    public int NMODULEC { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int NAGE_INIT { get; set; }
    public int? NAGE_END { get; set; }
    public int NTYPE_CONTRAT { get; set; }

    [ForeignKey("NTYPE_CONTRAT")]
    public Insudb.TABLE9108? TABLE9108 { get; set; }
    public string? SROUTINE { get; set; }
    public int? NLIFE_SCHE { get; set; }
    public int? NTYPCOMMIS { get; set; }

    [ForeignKey("NTYPCOMMIS")]
    public Insudb.TABLE5662? TABLE5662 { get; set; }
    public decimal? NPERC_PAY { get; set; }
    public int? NTYPERISK { get; set; }

    [ForeignKey("NTYPERISK")]
    public Insudb.TABLE5639? TABLE5639 { get; set; }
    public string? SSMOKING { get; set; }
    public decimal? NCAPITAL_INIT { get; set; }
    public decimal? NCAPITAL_END { get; set; }
    public decimal? NAMOUNTLIM { get; set; }
    public decimal? NDRCOMM { get; set; }
    public int? NIDCOMM { get; set; }
    public int NCATEGORY { get; set; }

    [ForeignKey("NCATEGORY")]
    public Insudb.TABLE9202? TABLE9202 { get; set; }
}
