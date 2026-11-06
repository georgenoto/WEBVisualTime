#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_SETTLEMENT
{
    public long NSETTLEMENT_NUM { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NEXCHANGE_REF { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NPAYMENT_METHOD { get; set; }

    [ForeignKey("NPAYMENT_METHOD")]
    public Insudb.TABLE9252? TABLE9252 { get; set; }
    public int? NPAYEE { get; set; }

    [ForeignKey("NPAYEE")]
    public Insudb.TABLE9251? TABLE9251 { get; set; }
    public int? NSETTLEMENT_STAT { get; set; }

    [ForeignKey("NSETTLEMENT_STAT")]
    public Insudb.TABLE9250? TABLE9250 { get; set; }
    public int? NSETTLEMENT_CONC { get; set; }

    [ForeignKey("NSETTLEMENT_CONC")]
    public Insudb.TABLE9249? TABLE9249 { get; set; }
    public long? NNOTENUM { get; set; }
    public int? NUSER_AMEND { get; set; }
    public long? NSEQUENCE_ID { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTYPELIST { get; set; }

    [ForeignKey("NTYPELIST")]
    public Insudb.TABLE9203? TABLE9203 { get; set; }
    public DateTime? DPEPSEARCH { get; set; }
    public int? NUSERPEPSEARCH { get; set; }
    public int? NSEVERITYPEP { get; set; }

    [ForeignKey("NSEVERITYPEP")]
    public Insudb.TABLE9204? TABLE9204 { get; set; }
    public int? NINDAUTHPEP { get; set; }
    public DateTime? DPEPSTATUS { get; set; }
    public int? NUSERUIF { get; set; }
    public int? NCLAIMANTTYPE { get; set; }

    [ForeignKey("NCLAIMANTTYPE")]
    public Insudb.TABLE9212? TABLE9212 { get; set; }
    public string? SCLIENT2 { get; set; }
    public int? NPROVIDER { get; set; }
    public string? SCLIENT_PAYEE { get; set; }
    public DateTime? DSETTLEMENTDAT { get; set; }
    public DateTime? DPAYAUTH { get; set; }
    public decimal? NAMOUNT_ORDEN { get; set; }
    public decimal? NAMOUNT_TOTAL { get; set; }
    public decimal? NAMOUNT_DEDUCOIN { get; set; }
    public decimal? NAMOUNT_VAT { get; set; }
    public decimal? NAMOUNT_FTT { get; set; }
    public decimal? NAMOUNT_AGREE { get; set; }
    public decimal? NAMOUNT_ADJUST { get; set; }
    public decimal? NSETTLEMENT_PAY { get; set; }
    public decimal? NAMOUNT_VAT_LOSS { get; set; }
    public decimal? NAMOUNT_FTT_LOSS { get; set; }
    public long? NREQUEST_NU { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
    public long? NBANKEXT { get; set; }
    public string? SBANKACCOUNT { get; set; }
    public int? NACC_TYPE { get; set; }

    [ForeignKey("NACC_TYPE")]
    public Insudb.TABLE190? TABLE190 { get; set; }
    public string? SREFUND { get; set; }
    public string? SCLIENAMEPAYEE { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
    public string? SCLINUMDOCU { get; set; }
    public int? NOFFICE { get; set; }
    public string? SPHONE { get; set; }
    public string? SCELLPHONE { get; set; }
    public string? SEMAIL { get; set; }
    public int? NUSER_PAYMETHODCREATE { get; set; }
    public DateTime? DPAYMETHODCREATE { get; set; }
    public int? NUSER_PAYMETHODAMEN { get; set; }
    public DateTime? DPAYMETHODAMEN { get; set; }
    public long? NSEQ_IDPAYMENTMETHOD { get; set; }
    public int? NUSER_DERIVEDBY { get; set; }
    public int? NUSER_AUTHORIZATION { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE9274? TABLE9274 { get; set; }
    public long? NSETTLEMENT_ORIG { get; set; }
    public long? NSEQ_IDLEDGERDOCUM { get; set; }
    public string? SCLIENT_BENEF { get; set; }
    public string? SCLIENT_REP { get; set; }
}
