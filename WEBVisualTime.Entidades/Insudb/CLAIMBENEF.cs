#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIMBENEF
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASENDEMAN_TYPE { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENTSCLIENT { get; set; }
    public int NBENE_TYPE { get; set; }

    [ForeignKey("NBENE_TYPE")]
    public Insudb.TABLE184? TABLE184 { get; set; }
    public int NID { get; set; }
    public int NOFFICE_PAY { get; set; }

    [ForeignKey("NOFFICE_PAY")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEMANDANT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NRELATION { get; set; }

    [ForeignKey("NRELATION")]
    public Insudb.TABLE15? TABLE15 { get; set; }
    public decimal? NPARTICIP { get; set; }
    public string? SBENEF_TYP { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DINIT_DATE { get; set; }
    public DateTime? DEND_DATE { get; set; }
    public string? SCLIENT_REP { get; set; }

    [ForeignKey("SCLIENT_REP")]
    public Insudb.CLIENT? CLIENTSCLIENT_REP { get; set; }
    public DateTime? DNEXT_PAY { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SPAY_INSTALL { get; set; }
    public int NOFFICEAGEN_PAY { get; set; }

    [ForeignKey("NOFFICEAGEN_PAY")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public int NAGENCY_PAY { get; set; }

    [ForeignKey("NAGENCY_PAY")]
    public Insudb.AGENCIES? AGENCIES { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DSHOWDATE { get; set; }
    public int NPAYMENTADDRESS { get; set; }

    [ForeignKey("NPAYMENTADDRESS")]
    public Insudb.TABLE7801? TABLE7801 { get; set; }
}
