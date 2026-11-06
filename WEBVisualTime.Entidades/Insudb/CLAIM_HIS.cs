#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_HIS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [NotMapped]
    public Insudb.CLAIM_CASE? CLAIM_CASENCASE_NUM
    {
        get => CLAIM_CASENCLAIM;
        set => CLAIM_CASENCLAIM = value;
    }
    public int NDEMAN_TYPE { get; set; }

    [NotMapped]
    public Insudb.CLAIM_CASE? CLAIM_CASENDEMAN_TYPE
    {
        get => CLAIM_CASENCLAIM;
        set => CLAIM_CASENCLAIM = value;
    }
    public int NTRANSAC { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int NOPER_TYPE { get; set; }

    [ForeignKey("NOPER_TYPE")]
    public Insudb.TABLE140? TABLE140 { get; set; }
    public string? SCESSICOI { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public string? SEXECUTED { get; set; }
    public decimal? NINC_AMOUNT { get; set; }
    public decimal? NINCOMETAX { get; set; }
    public string? SIND_AUT { get; set; }
    public string? SIND_ORDER { get; set; }
    public string? SIND_REV { get; set; }
    public decimal? NLOC_AMOUNT { get; set; }
    public DateTime? DOPERDATE { get; set; }
    public string? SORDER_NUM { get; set; }
    public int? NPAY_TYPE { get; set; }

    [ForeignKey("NPAY_TYPE")]
    public Insudb.TABLE199? TABLE199 { get; set; }
    public DateTime? DPOSTED { get; set; }
    public long? NSERV_ORDER { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public long? NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public int? NPAY_FORM { get; set; }

    [ForeignKey("NPAY_FORM")]
    public Insudb.TABLE138? TABLE138 { get; set; }
    public string? SREINSU_IND { get; set; }
    public string? SCOINSU_IND { get; set; }
    public long? NCASH_ID { get; set; }
    public int? NDOC_TYPE { get; set; }

    [ForeignKey("NDOC_TYPE")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public long? NBILL { get; set; }
    public DateTime? DBILL_DATE { get; set; }
    public string? SCO_PAY { get; set; }
    public long? NNOTENUM { get; set; }
    public long? NID { get; set; }
    public string? SINDMARGIN { get; set; }
    public string? SPAY_RENT { get; set; }
    public string? SIND_TRANFER { get; set; }
    public long? NPROCEEDINGNUM { get; set; }
    public int? NTRANSCLAIMREV { get; set; }
    public decimal? NDDR { get; set; }
    public int? NDEDUCTIBLE_METHOD { get; set; }
    public string? SIND_RASA { get; set; }
    public string? SINDPROCESS { get; set; }
    public decimal? NDED_AMOUNT { get; set; }
    public DateTime? DBACKUPDATE { get; set; }
    public long? NRECOVER { get; set; }
    public long? NRELATION { get; set; }
    public decimal? NRASA { get; set; }
    public DateTime? DCTB_DATE { get; set; }
    public string? SPOSTEDSEQUENCE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NSETTLEMENT_NUM { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
    public decimal? NAMOUNT_VAT { get; set; }
    public decimal? NAMOUNT_FTT { get; set; }
    public decimal? NAMOUNT_AGREE { get; set; }
    public decimal? NAMOUNT_ADJUST { get; set; }
    public decimal? NAMOUNT_VAT_LOSS { get; set; }
    public decimal? NAMOUNT_FTT_LOSS { get; set; }
    public decimal? NSETTLEMENT_PAY { get; set; }
    public int? NSETTLEMENT_CONC { get; set; }
}
