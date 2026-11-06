#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTRNPRO
{
    public int NNUMBER { get; set; }

    [ForeignKey("NTYPE_REL, NNUMBER, NTYPE, NBRANCH")]
    public Insudb.CONTRMASTER? CONTRMASTERNNUMBER { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNBRANCH
    {
        get => CONTRMASTERNNUMBER;
        set => CONTRMASTERNNUMBER = value;
    }
    public DateTime DEFFECDATE { get; set; }
    public int NTYPE { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE
    {
        get => CONTRMASTERNNUMBER;
        set => CONTRMASTERNNUMBER = value;
    }
    public decimal? NAMOUNT { get; set; }
    public int NTYPE_REL { get; set; }

    [NotMapped]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE_REL
    {
        get => CONTRMASTERNNUMBER;
        set => CONTRMASTERNNUMBER = value;
    }
    public long? NCESSION { get; set; }
    public decimal? NCLAUSULE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NDEDUCIBLE { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NEXCESS { get; set; }
    public decimal? NMAX_EVEN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNUMBER_REP { get; set; }
    public decimal? NPORC_REP { get; set; }
    public decimal? NPREM_DEP { get; set; }
    public decimal? NPREM_FIJ { get; set; }
    public decimal? NPREM_MIN { get; set; }
    public decimal? NRATE_FIJ { get; set; }
    public decimal? NRATE_MAX { get; set; }
    public decimal? NRATE_MIN { get; set; }
    public string? SREINSURAN { get; set; }
    public decimal? NRETENTION { get; set; }
    public int? NUSERCODE { get; set; }
    public int NCURR_PAY { get; set; }
    public decimal? NINTEREST { get; set; }
    public int? NFREQPAY { get; set; }

    [ForeignKey("NFREQPAY")]
    public Insudb.TABLE97? TABLE97NFREQPAY { get; set; }
    public int? NNEXTMONTHPA { get; set; }
    public int? NNEXTYEARPA { get; set; }
    public int? NFREQCT { get; set; }

    [ForeignKey("NFREQCT")]
    public Insudb.TABLE97? TABLE97NFREQCT { get; set; }
    public int? NNEXTMONTHC { get; set; }
    public int? NNEXTYEARC { get; set; }
    public string? SROUCESSPR { get; set; }
    public string? SROUCESSCL { get; set; }
    public string? SAGREEMENTPAYS { get; set; }
    public string? SROUNETRET { get; set; }
    public decimal? NRATE_NRIFV { get; set; }
    public int? NCLAIMSCATAS { get; set; }
    public decimal? NMAXRESPEVEN { get; set; }
    public int? NNUMBERREPEVEN { get; set; }
    public string? SPRORATEREP { get; set; }
    public decimal? NPORC_PAY { get; set; }
    public decimal? NPREMIUM_DEVENG { get; set; }
    public decimal? NEPI { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NCLAIMADJ { get; set; }
    public decimal? NCAPITALREF { get; set; }
    public long? NLIFENUM { get; set; }
    public decimal? NSPCPRIORITY { get; set; }
    public decimal? NSPCLIMIT { get; set; }
}
