#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_CONCEPTS
{
    public long NBORDEREAUX { get; set; }
    public string SSEL { get; set; }
    public int NTRANSAC { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT, NCOMPANY")]
    public Insudb.CASH_CONCEPTS? CASH_CONCEPTSNCONCEPT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPROPONUM { get; set; }
    public long? NCERTIF { get; set; }
    public string? SCLIENT { get; set; }
    public long? NORICURR { get; set; }

    [ForeignKey("NORICURR")]
    public Insudb.TABLE11? TABLE11NORICURR { get; set; }
    public decimal? NORIAMOUNT { get; set; }
    public long? NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DVALDATE { get; set; }
    public int? NCHANGESDAT { get; set; }

    [ForeignKey("NCHANGESDAT")]
    public Insudb.TABLE5642? TABLE5642 { get; set; }
    public long? NCLAIM { get; set; }
    public int? NCASE_NUM { get; set; }
    public long? NBANK_CODE { get; set; }

    [ForeignKey("STYPE_BANKAGREE, NBANK_CODE, NACCOUNT")]
    public Insudb.BANK_AGREE? BANK_AGREENBANK_CODE { get; set; }
    public int? NBANK_AGREE { get; set; }
    public int? NAGREEMENT { get; set; }
    public long? NNOTENUM { get; set; }
    public long? NSUPORT_ID { get; set; }
    public int? NTYPESUPPORT { get; set; }

    [ForeignKey("NTYPESUPPORT")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public DateTime? DCOLLECTION { get; set; }
    public string? SACTION { get; set; }
    public long? NCASH_ID { get; set; }
    public int? NMOV_TYPE { get; set; }
    public int? NTYP_ACCO { get; set; }
    public long? NINTERMED { get; set; }
    public int? NCOMPANY { get; set; }

    [NotMapped]
    public Insudb.CASH_CONCEPTS? CASH_CONCEPTSNCOMPANY
    {
        get => CASH_CONCEPTSNCONCEPT;
        set => CASH_CONCEPTSNCONCEPT = value;
    }
    public string? STYPE_BANKAGREE { get; set; }

    [NotMapped]
    public Insudb.BANK_AGREE? BANK_AGREESTYPE_BANKAGREE
    {
        get => BANK_AGREENBANK_CODE;
        set => BANK_AGREENBANK_CODE = value;
    }
    public int? NACCOUNT { get; set; }

    [NotMapped]
    public Insudb.BANK_AGREE? BANK_AGREENACCOUNT
    {
        get => BANK_AGREENBANK_CODE;
        set => BANK_AGREENBANK_CODE = value;
    }
    public int? NDEMAN_TYPE { get; set; }
    public long? NBULLETINS { get; set; }
    public int? NLOAN { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
    public long? NLOANS { get; set; }
    public long? NPOLICY { get; set; }
    public long? NREQUEST_NU { get; set; }
    public long? NBORDEREAUXUSED { get; set; }
}
