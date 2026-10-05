#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ROLES
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
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public DateTime? DBIRTHDATE { get; set; }
    public string? SSEXCLIEN { get; set; }

    [ForeignKey("SSEXCLIEN")]
    public Insudb.TABLE18? TABLE18 { get; set; }
    public string? SSMOKING { get; set; }
    public int NTYPERISK { get; set; }

    [ForeignKey("NTYPERISK")]
    public Insudb.TABLE5639? TABLE5639 { get; set; }
    public string? SVIP { get; set; }
    public int NSTATUSROL { get; set; }

    [ForeignKey("NSTATUSROL")]
    public Insudb.TABLE5561? TABLE5561 { get; set; }
    public int? NRATING { get; set; }
    public int NTYPENAME { get; set; }

    [ForeignKey("NTYPENAME")]
    public Insudb.TABLE5592? TABLE5592 { get; set; }
    public int? NCOVERPOS { get; set; }
    public DateTime? DCONTINUE { get; set; }
    public int? NCONTRAT_PAY { get; set; }
    public string? SCONTINUED { get; set; }
    public string? SPRINTNAME { get; set; }
    public string? SITEM { get; set; }
    public decimal? NWEIGHT { get; set; }
    public decimal? NHEIGHT { get; set; }
    public decimal? NIMC { get; set; }
    public int NTYPELIST { get; set; }

    [ForeignKey("NTYPELIST")]
    public Insudb.TABLE9203? TABLE9203 { get; set; }
    public DateTime? DPEPSEARCH { get; set; }
    public int? NUSERPEPSEARCH { get; set; }
    public string? SFPHYSICAL_CREDEN { get; set; }
    public int NCLASSTYPDOC { get; set; }

    [ForeignKey("NCLASSTYPDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNCLASSTYPDOC { get; set; }
    public int NTYPCLIENTDOC { get; set; }

    [ForeignKey("NTYPCLIENTDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNTYPCLIENTDOC { get; set; }
    public int NCITY_RESIDENCE { get; set; }

    [ForeignKey("NCITY_RESIDENCE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string? SSHORT_DES { get; set; }
    public int? NSEVERITYPEP { get; set; }
    public int? NINDAUTHPEP { get; set; }
    public DateTime? DPEPSTATUS { get; set; }
    public decimal? NCAPITAL { get; set; }
    public int? NUSERPEPAUTHREJ { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
