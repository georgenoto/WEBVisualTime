#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PART_CONTR
{
    public int NTYPE_REL { get; set; }

    [ForeignKey("NTYPE_REL")]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE_REL { get; set; }
    public int NNUMBER { get; set; }

    [ForeignKey("NNUMBER")]
    public Insudb.CONTRMASTER? CONTRMASTERNNUMBER { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CONTRMASTER? CONTRMASTERNBRANCH { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public int? NARR_PERD { get; set; }
    public decimal? NCOMISION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long? NCORREDOR { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPR_INOUT { get; set; }
    public decimal? NCL_INOUT { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NRATE_BENE { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NCESSPRFIX { get; set; }
    public decimal? NCESSRATE { get; set; }
    public string? SROUCESS { get; set; }
    public string? SROUPROFIT { get; set; }
    public decimal? NAMOUNTPROFIT { get; set; }
    public string? SFREQPROFIT { get; set; }
    public decimal? NEXCESS { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NEXPENSES { get; set; }
    public decimal? NRATE_DEV { get; set; }
}
