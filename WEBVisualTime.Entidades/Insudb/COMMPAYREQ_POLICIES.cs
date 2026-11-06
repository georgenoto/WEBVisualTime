#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMPAYREQ_POLICIES
{
    public long NID_COMMPAYREQ { get; set; }

    [ForeignKey("NID_COMMPAYREQ")]
    public Insudb.COMMPAYMENTREQUESTS? COMMPAYMENTREQUESTS { get; set; }
    public int NCONSEC { get; set; }
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
    public int NMODULEC { get; set; }
    public int? NGROUP_INSU { get; set; }
    public string SPOLITYPE { get; set; }
    public int? NIND_POLICY { get; set; }
    public int? NIND_CURRENT_POLICY { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int? NINTERTYP { get; set; }

    [ForeignKey("NINTERTYP")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
    public string? SCLIENAME_INTERMEDIA { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public DateTime DEXPIRDAT { get; set; }
    public long NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11 { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NBALANCECAPITAL { get; set; }
    public decimal? NBALANCEDEDUC { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NPREMIUMN { get; set; }
    public decimal? NPREMIUMNPAID { get; set; }
    public decimal? NCLAIMSAMOUNTBASE_SETT { get; set; }
    public decimal? NCLAIMSAMOUNTBASE_PEND { get; set; }
    public int? NRATECLAIMS { get; set; }
    public int? NRATEPROFIT { get; set; }
    public int? NRATEPROJECTED_CLAIMS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
