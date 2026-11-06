#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CL_COVER
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCLAIM { get; set; }
    public int NCOVER { get; set; }
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
    public int NMODULEC { get; set; }
    public int NCURRENCY { get; set; }
    public int NBRANCH_EST { get; set; }

    [ForeignKey("NBRANCH_EST")]
    public Insudb.TABLE71? TABLE71 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public int? NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NCOST_RECU { get; set; }
    public decimal? NDAMAGES { get; set; }
    public decimal? NEXP_AMOUNT { get; set; }
    public decimal? NFRA_AMOUNT { get; set; }
    public string? SFRANTYPE { get; set; }

    [ForeignKey("SFRANTYPE")]
    public Insudb.TABLE64? TABLE64 { get; set; }
    public int? NGROUP { get; set; }
    public decimal? NLOC_COS_RE { get; set; }
    public decimal? NLOC_PAY_AM { get; set; }
    public decimal? NLOC_REC_AM { get; set; }
    public decimal? NLOC_RESERV { get; set; }
    public decimal? NPAY_AMOUNT { get; set; }
    public int? NQUANTITY { get; set; }
    public decimal? NREC_AMOUNT { get; set; }
    public decimal? NRESERVE { get; set; }
    public string? SRESERVSTAT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NDAMPROF { get; set; }
    public decimal? NTAX_AMO { get; set; }
    public string SBILL_IND { get; set; }
    public decimal? NRATEEQCOST { get; set; }
    public decimal? NDEPRECIATEBASE { get; set; }
    public decimal? NDEPRECIATERATE { get; set; }
    public decimal? NDEPRECIATEAMOUNT { get; set; }
    public decimal? NRASA { get; set; }
    public int? NFRANCDAYS { get; set; }
    public decimal? NDAYDEDAMOUNT { get; set; }
    public decimal? NORIG_RESERVE { get; set; }
}
