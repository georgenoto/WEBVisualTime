#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COVER_CO_P
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY")]
    public Insudb.POLICY? POLICYSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNBRANCH
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNPRODUCT
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNPOLICY
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public decimal? NCAPITAL { get; set; }
    public string? SCHANGE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SFRANDEDI { get; set; }

    [ForeignKey("SFRANDEDI")]
    public Insudb.TABLE64? TABLE64 { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NDISCOUNT { get; set; }
    public long? NFIXAMOUNT { get; set; }
    public long? NMAXAMOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public long? NMINAMOUNT { get; set; }
    public int? NWAIT_QUAN { get; set; }
    public string? SWAIT_TYPE { get; set; }

    [ForeignKey("SWAIT_TYPE")]
    public Insudb.TABLE52? TABLE52 { get; set; }
    public decimal? NRATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SFRANCAPL { get; set; }

    [ForeignKey("SFRANCAPL")]
    public Insudb.TABLE33? TABLE33 { get; set; }
    public decimal? NDISC_AMOUN { get; set; }
    public int? NDURINSUR { get; set; }
    public int NTYPDURINS { get; set; }

    [ForeignKey("NTYPDURINS")]
    public Insudb.TABLE5589? TABLE5589NTYPDURINS { get; set; }
    public int? NAGEMININSM { get; set; }
    public int? NAGEMAXINSM { get; set; }
    public int? NAGEMAXPERM { get; set; }
    public int? NAGEMININSF { get; set; }
    public int? NAGEMAXINSF { get; set; }
    public int? NAGEMAXPERF { get; set; }
    public int? NDURPAY { get; set; }
    public int? NTYPDURPAY { get; set; }

    [ForeignKey("NTYPDURPAY")]
    public Insudb.TABLE5589? TABLE5589NTYPDURPAY { get; set; }
    public decimal? NRATECOVE { get; set; }
    public decimal? NPREMIUM { get; set; }
    public int? NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int? NRETARIF { get; set; }

    [ForeignKey("NRETARIF")]
    public Insudb.TABLE5559? TABLE5559 { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SREQUIRED { get; set; }
    public decimal? NCAPITAL_O { get; set; }
    public decimal? NPREMIUM_O { get; set; }
    public decimal? NRATECOVE_O { get; set; }
    public decimal? NCAPITALTOT { get; set; }
    public decimal? NCAPITALWAITTOT { get; set; }
    public decimal? NPREMIUMTOT { get; set; }
    public decimal? NRATEAVG_N { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NRECAMOUNT { get; set; }
    public decimal? NDESCAMOUNT { get; set; }
    public decimal? NCOMMI_AN { get; set; }
    public decimal? NRATECOVE_B { get; set; }
    public decimal? NCAPMAX { get; set; }
    public decimal? NCAPMIN { get; set; }
    public decimal? NPREMAX { get; set; }
    public decimal? NPREMIN { get; set; }
    public int? NTYP_AGEMINM { get; set; }
    public int? NTYP_AGEMINF { get; set; }
    public decimal? NPERCENT { get; set; }
    public int? NFREQMAXEVEN { get; set; }

    [ForeignKey("NFREQMAXEVEN")]
    public Insudb.TABLE340? TABLE340 { get; set; }
    public int? NMAXEVEN_QUAN { get; set; }
    public int? NFREQUEN { get; set; }
    public string? SROUTMAX_EVEN { get; set; }
    public long? NMOVEMENT { get; set; }
    public decimal? NPREMIUM_SM { get; set; }
    public decimal? NPREMIUM_CM { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
