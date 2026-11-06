#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PART_CONTR
{
    public int NTYPE_REL { get; set; }

    [ForeignKey("NTYPE_REL, NNUMBER, NTYPE, NBRANCH")]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE_REL { get; set; }
    public int NNUMBER { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNNUMBER
    {
        get => CONTRMASTERNTYPE_REL;
        set => CONTRMASTERNTYPE_REL = value;
    }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNBRANCH
    {
        get => CONTRMASTERNTYPE_REL;
        set => CONTRMASTERNTYPE_REL = value;
    }
    public DateTime DEFFECDATE { get; set; }
    public int NTYPE { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE
    {
        get => CONTRMASTERNTYPE_REL;
        set => CONTRMASTERNTYPE_REL = value;
    }
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
