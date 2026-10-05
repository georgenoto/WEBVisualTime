#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REINSURAN
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int NMODULEC { get; set; }
    public int NTYPE_REIN { get; set; }

    [ForeignKey("NTYPE_REIN")]
    public Insudb.TABLE173? TABLE173 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public DateTime? DACCEDATE { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOMMISSI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SHEAP_CODE { get; set; }
    public decimal? NINTER_RATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNUMBER { get; set; }
    public decimal? NRESER_RATE { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NUSERCODE { get; set; }
    public int NCHANGE { get; set; }

    [ForeignKey("NCHANGE")]
    public Insudb.TABLE5531? TABLE5531 { get; set; }
    public string? NACEP_CODE { get; set; }
    public string? SMANUALMOV { get; set; }
    public decimal? NCAPITAL_REI { get; set; }
    public int? NORDEN { get; set; }
    public decimal? NSHARE_REI { get; set; }
    public decimal? NPREMIUM_AGREE { get; set; }
    public decimal? NEXCESS { get; set; }
    public decimal? NRETENTION { get; set; }
    public decimal? NSPCPRIORITY { get; set; }
    public int? NCOMPANYBROKER { get; set; }
    public decimal? NFACPERCENTREQ { get; set; }
    public int? NFACBRANCH_REIREQ { get; set; }
    public decimal? NFACPERCENTREQ_COV { get; set; }
    public int? NCOVAPPSCOPE { get; set; }
    public decimal? NLIMITFROM { get; set; }
    public decimal? NLIMIT { get; set; }
    public decimal? NAGGREGATELIMIT { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NAMOUNT_CONT { get; set; }
}
