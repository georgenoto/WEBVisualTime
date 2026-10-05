#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_GENCOV
{
    public int NCOVERGEN { get; set; }
    public string? SAUTOMREP { get; set; }
    public int NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public int NBRANCH_EST { get; set; }

    [ForeignKey("NBRANCH_EST")]
    public Insudb.TABLE71? TABLE71 { get; set; }
    public int NBRANCH_GEN { get; set; }

    [ForeignKey("NBRANCH_GEN")]
    public Insudb.TABLE634? TABLE634 { get; set; }
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public decimal? NCACALFIX { get; set; }
    public string? SCACALFRI { get; set; }
    public string? SCACALILI { get; set; }
    public string? SCACALREI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCOVER_IN { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SFRANCAPL { get; set; }

    [ForeignKey("SFRANCAPL")]
    public Insudb.TABLE33? TABLE33 { get; set; }
    public long? NFRANCFIX { get; set; }
    public long? NFRANCMAX { get; set; }
    public long? NFRANCMIN { get; set; }
    public decimal? NFRANCRAT { get; set; }
    public string? SFRANTYPE { get; set; }

    [ForeignKey("SFRANTYPE")]
    public Insudb.TABLE64? TABLE64 { get; set; }
    public decimal? NMEDRESER { get; set; }
    public decimal? NPREMIFIX { get; set; }
    public decimal? NPREMIMAX { get; set; }
    public decimal? NPREMIMIN { get; set; }
    public decimal? NPREMIRAT { get; set; }
    public string? SROUCAPIT { get; set; }
    public string? SROUFRANC { get; set; }
    public string? SROUPREMI { get; set; }
    public string? SROURESER { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCONDSVS { get; set; }
    public string? SINFORPROV { get; set; }
    public string? SPROVIDER { get; set; }

    [ForeignKey("SPROVIDER")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public string SRISK { get; set; }
    public decimal? NFRANCRATCLA { get; set; }
    public long? NFRANCFIXCLA { get; set; }
    public long? NFRANXMINCLA { get; set; }
    public long? NFRANXMAXCLA { get; set; }
    public string? SROUFRANCCLA { get; set; }
    public string? STAXHEREDITY { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public DateTime? DOCCURDAT { get; set; }
}
