#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COVER
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int NGROUP_INSU { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCAPITALI { get; set; }
    public string? SCHANGE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SFRANDEDI { get; set; }

    [ForeignKey("SFRANDEDI")]
    public Insudb.TABLE64? TABLE64 { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NDISCOUNT { get; set; }
    public long? NFIXAMOUNT { get; set; }
    public long? NMAXAMOUNT { get; set; }
    public string? SFREE_PREMI { get; set; }
    public long? NMINAMOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NRATE { get; set; }
    public int? NWAIT_QUAN { get; set; }
    public decimal? NRATECOVE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SWAIT_TYPE { get; set; }

    [ForeignKey("SWAIT_TYPE")]
    public Insudb.TABLE52? TABLE52 { get; set; }
    public string? SFRANCAPL { get; set; }

    [ForeignKey("SFRANCAPL")]
    public Insudb.TABLE33? TABLE33 { get; set; }
    public decimal? NDISC_AMOUN { get; set; }
    public int? NTYPDURINS { get; set; }

    [ForeignKey("NTYPDURINS")]
    public Insudb.TABLE5589? TABLE5589NTYPDURINS { get; set; }
    public int? NDURINSUR { get; set; }
    public int? NAGEMININS { get; set; }
    public int? NAGEMAXINS { get; set; }
    public int? NAGEMAXPER { get; set; }
    public int? NTYPDURPAY { get; set; }

    [ForeignKey("NTYPDURPAY")]
    public Insudb.TABLE5589? TABLE5589NTYPDURPAY { get; set; }
    public int? NDURPAY { get; set; }
    public int? NCAUSEUPD { get; set; }

    [ForeignKey("NCAUSEUPD")]
    public Insudb.TABLE5547? TABLE5547 { get; set; }
    public decimal? NCAPITAL_WAIT { get; set; }
    public int? NAGELIMIT { get; set; }
    public int? NAGE_PER { get; set; }
    public DateTime? DANIVERSARY { get; set; }
    public DateTime? DSEEKTAR { get; set; }
    public DateTime? DFER { get; set; }
    public int? NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int? NRETARIF { get; set; }

    [ForeignKey("NRETARIF")]
    public Insudb.TABLE5559? TABLE5559 { get; set; }
    public decimal? NCAPITAL_O { get; set; }
    public decimal? NPREMIUM_O { get; set; }
    public decimal? NRATECOVE_O { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NRECAMOUNT { get; set; }
    public decimal? NDESCAMOUNT { get; set; }
    public decimal? NCOMMI_AN { get; set; }
    public decimal? NRATECOVE_B { get; set; }
    public decimal? NCAPITAL_REQ { get; set; }
    public decimal? NRATECLA { get; set; }
    public long? NFIXAMOCLA { get; set; }
    public long? NMINAMOCLA { get; set; }
    public long? NMAXAMOCLA { get; set; }
    public decimal? NDISCCLA { get; set; }
    public decimal? NDISC_AMOCLA { get; set; }
    public int? NFRANCDAYS { get; set; }
    public int? NFREQMAXEVEN { get; set; }

    [ForeignKey("NFREQMAXEVEN")]
    public Insudb.TABLE340? TABLE340 { get; set; }
    public string? SROUTMAX_EVEN { get; set; }
    public int? NFREQUEN { get; set; }
    public int? NMAXEVEN_QUAN { get; set; }
    public string? SREDUCCAPITAL { get; set; }
    public decimal? NREDUCAPAGE { get; set; }
    public int? NAGELIMITCAP { get; set; }
    public decimal? NPERCCOAS { get; set; }
    public DateTime? DFREE_PREM_IN { get; set; }
    public DateTime? DFREE_PREM_LIM { get; set; }
    public DateTime? DANTIDATE { get; set; }
    public decimal? NANTI_AMOUNT { get; set; }
    public decimal? NCLAIMRAT { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
    public string? SCOVERCHANGE { get; set; }
}
