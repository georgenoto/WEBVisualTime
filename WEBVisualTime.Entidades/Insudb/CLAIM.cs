#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM
{
    public long NCLAIM { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public string SCLAIMTYP { get; set; }

    [ForeignKey("SCLAIMTYP")]
    public Insudb.TABLE132? TABLE132 { get; set; }
    public int? NCAUSECOD { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENTSCLIENT { get; set; }
    public string? SCOINSURI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DDECLADAT { get; set; }
    public string? SINS_CLAIM { get; set; }
    public string? SLEADCIAL { get; set; }
    public decimal? NLOC_COS_RE { get; set; }
    public decimal? NLOC_OUT_AM { get; set; }
    public decimal? NLOC_PAY_AM { get; set; }
    public decimal? NLOC_REC_AM { get; set; }
    public decimal? NLOC_RESERV { get; set; }
    public string? SMAILNUMB { get; set; }
    public int? NMOVEMENT { get; set; }
    public long? NNOTENUM { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE136? TABLE136 { get; set; }
    public DateTime? DOCCURDAT { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9NOFFICE { get; set; }
    public int NOFFICE_OWN { get; set; }

    [ForeignKey("NOFFICE_OWN")]
    public Insudb.TABLE9? TABLE9NOFFICE_OWN { get; set; }
    public int NOFFICTRA { get; set; }

    [ForeignKey("NOFFICTRA")]
    public Insudb.TABLE9? TABLE9NOFFICTRA { get; set; }
    public DateTime? DPRESCDAT { get; set; }
    public string? SPRINTED { get; set; }
    public string? SREINSURI { get; set; }
    public DateTime? DSHOW_DATE { get; set; }
    public string? SSHOW_STATU { get; set; }
    public string? SSTACLAIM { get; set; }

    [ForeignKey("SSTACLAIM")]
    public Insudb.TABLE135? TABLE135 { get; set; }
    public int NUNACCODE { get; set; }

    [ForeignKey("NUNACCODE")]
    public Insudb.TABLE133? TABLE133 { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SNUMFORM { get; set; }
    public decimal? NTAX_AMO { get; set; }
    public long? NIMAGENUM { get; set; }
    public string? SCESS_NPR { get; set; }
    public string? SCLIENT2 { get; set; }

    [ForeignKey("SCLIENT2")]
    public Insudb.CLIENT? CLIENTSCLIENT2 { get; set; }
    public long NBORDEREAUX_CL { get; set; }

    [ForeignKey("NBORDEREAUX_CL")]
    public Insudb.CLAIM_MASTER? CLAIM_MASTER { get; set; }
    public DateTime? DLIMIT_PAY { get; set; }
    public int? NIDCATAS { get; set; }
    public int NOFFICE_PAY { get; set; }

    [ForeignKey("NOFFICE_PAY")]
    public Insudb.TABLE9? TABLE9NOFFICE_PAY { get; set; }
    public int NWAITCL_CODE { get; set; }

    [ForeignKey("NWAITCL_CODE")]
    public Insudb.TABLE5604? TABLE5604 { get; set; }
    public int NRELASHIP { get; set; }

    [ForeignKey("NRELASHIP")]
    public Insudb.TABLE15? TABLE15 { get; set; }
    public int NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556NOFFICEAGEN { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.AGENCIES? AGENCIESNAGENCY { get; set; }
    public int NAGENCY_PAY { get; set; }

    [ForeignKey("NAGENCY_PAY")]
    public Insudb.AGENCIES? AGENCIESNAGENCY_PAY { get; set; }
    public int NOFFICEAGEN_PAY { get; set; }

    [ForeignKey("NOFFICEAGEN_PAY")]
    public Insudb.TABLE5556? TABLE5556NOFFICEAGEN_PAY { get; set; }
    public long? NCLAIMPARENT { get; set; }
    public string? SUNIQUEID { get; set; }
    public DateTime? DMC_OCCURDAT { get; set; }
    public DateTime? DCOMPLETDATE { get; set; }
    public DateTime? DPAYDATE { get; set; }
    public long NIDPRECLAIM { get; set; }

    [ForeignKey("NIDPRECLAIM")]
    public Insudb.PRECLAIM? PRECLAIM { get; set; }
    public int? NPRECLAIM { get; set; }
    public int NCLAIMANTTYPE { get; set; }

    [ForeignKey("NCLAIMANTTYPE")]
    public Insudb.TABLE9212? TABLE9212 { get; set; }
    public DateTime? DPRESENTDATE { get; set; }
    public int? NIND_REOPENCL { get; set; }
    public int? NCAUSEREOPENCL { get; set; }
    public int? NTYPE_COMMPAY { get; set; }
    public string? SHISTORICAL_CLAIM { get; set; }
}
