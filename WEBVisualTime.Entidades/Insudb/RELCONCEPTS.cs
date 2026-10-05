#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RELCONCEPTS
{
    public string SSEL { get; set; }
    public long NBORDEREAUX { get; set; }
    public int NTRANSAC { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.CASH_CONCEPTS? CASH_CONCEPTSNCONCEPT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPROPONUM { get; set; }
    public long? NCERTIF { get; set; }
    public string? SCLIENT { get; set; }
    public int NORICURR { get; set; }

    [ForeignKey("NORICURR")]
    public Insudb.TABLE11? TABLE11NORICURR { get; set; }
    public decimal? NORIAMOUNT { get; set; }
    public int NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DVALDATE { get; set; }
    public int NCHANGEDAT { get; set; }

    [ForeignKey("NCHANGEDAT")]
    public Insudb.TABLE5642? TABLE5642 { get; set; }
    public long? NCLAIM { get; set; }
    public int? NCASE_NUM { get; set; }
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.BANK_AGREE? BANK_AGREENBANK_CODE { get; set; }
    public int? NBANK_AGREE { get; set; }
    public int? NAGREEMENT { get; set; }
    public long? NNOTENUM { get; set; }
    public long? NSUPORT_ID { get; set; }
    public int NTYPESUPPORT { get; set; }

    [ForeignKey("NTYPESUPPORT")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public DateTime? DCOLLECTION { get; set; }
    public long? NCASH_ID { get; set; }
    public int? NMOV_TYPE { get; set; }
    public int? NTYP_ACCO { get; set; }
    public long? NINTERMED { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.CASH_CONCEPTS? CASH_CONCEPTSNCOMPANY { get; set; }
    public string? STYPE_BANKAGREE { get; set; }

    [ForeignKey("STYPE_BANKAGREE")]
    public Insudb.BANK_AGREE? BANK_AGREESTYPE_BANKAGREE { get; set; }
    public int NACCOUNT { get; set; }

    [ForeignKey("NACCOUNT")]
    public Insudb.BANK_AGREE? BANK_AGREENACCOUNT { get; set; }
    public int? NDEMAN_TYPE { get; set; }
    public long? NBULLETINS { get; set; }
    public int? NLOAN { get; set; }
    public long? NBORDEREAUXUSED { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
    public long? NLOANS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NRELRECOVER { get; set; }
    public int? NRETENTIONTAXCODE { get; set; }
    public int? NRETENTIONCODE { get; set; }
    public string? NRETENTIONSERIES { get; set; }
    public DateTime? DAUTORIZATIONDATE { get; set; }
    public DateTime? DENDINGDATE { get; set; }
    public decimal? NRETENTION { get; set; }
    public decimal? NTAXRETENTION { get; set; }
    public decimal? NRETENTIONBASE { get; set; }
    public string? NAUTORIZATIONNUMBER { get; set; }
    public long? NBILLNUM { get; set; }
    public int? NTAXAMOU { get; set; }
    public long? NPOLICY { get; set; }
    public long? NREQUEST_NU { get; set; }
}
