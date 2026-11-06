#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CASH_MOV
{
    public int NACC_CASH { get; set; }

    [ForeignKey("NACC_CASH, NOFFICE, NCURRENCY, NCASHNUM")]
    public Insudb.CASH_ACC? CASH_ACCNACC_CASH { get; set; }
    public int NOFFICE { get; set; }

    [NotMapped]
    public Insudb.CASH_ACC? CASH_ACCNOFFICE
    {
        get => CASH_ACCNACC_CASH;
        set => CASH_ACCNACC_CASH = value;
    }
    public int NCURRENCY { get; set; }

    [NotMapped]
    public Insudb.CASH_ACC? CASH_ACCNCURRENCY
    {
        get => CASH_ACCNACC_CASH;
        set => CASH_ACCNACC_CASH = value;
    }
    public int NTRANSAC { get; set; }
    public int NCASHNUM { get; set; }

    [NotMapped]
    public Insudb.CASH_ACC? CASH_ACCNCASHNUM
    {
        get => CASH_ACCNACC_CASH;
        set => CASH_ACCNACC_CASH = value;
    }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public long? NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public int? NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE22? TABLE22 { get; set; }
    public int? NACC_BANK { get; set; }

    [ForeignKey("NACC_BANK")]
    public Insudb.BANK_ACC? BANK_ACC { get; set; }
    public int? NCARD_TYPE { get; set; }

    [ForeignKey("NCARD_TYPE")]
    public Insudb.TABLE183? TABLE183 { get; set; }
    public long? NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7NBANK_CODE { get; set; }
    public int? NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public DateTime? DCARD_EXPIR { get; set; }
    public string? SCARD_NUM { get; set; }
    public int? NCL_TRANSAC { get; set; }
    public int? NCOMPANYC { get; set; }

    [ForeignKey("NCOMPANYC")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NVOUCHER_LE { get; set; }
    public long? NVOUCHER { get; set; }
    public long? NCONTRAT { get; set; }

    [ForeignKey("NCONTRAT, NDRAFT")]
    public Insudb.FINANC_DRA? FINANC_DRANCONTRAT { get; set; }
    public string? SDEP_NUMBER { get; set; }
    public DateTime? DDOC_DATE { get; set; }
    public string? SDOCNUMBE { get; set; }
    public int? NDRAFT { get; set; }

    [NotMapped]
    public Insudb.FINANC_DRA? FINANC_DRANDRAFT
    {
        get => FINANC_DRANCONTRAT;
        set => FINANC_DRANCONTRAT = value;
    }
    public decimal? NEXCHANGE { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int? NMOV_TYPE { get; set; }

    [ForeignKey("NMOV_TYPE")]
    public Insudb.TABLE78? TABLE78 { get; set; }
    public string? SNULL_MOVEM { get; set; }
    public string? SNULL_RECOR { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NYEAR_MONTH { get; set; }
    public long? NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public int? NTYP_ACCO { get; set; }

    [ForeignKey("NTYP_ACCO")]
    public Insudb.TABLE400? TABLE400 { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENTSCLIENT { get; set; }
    public string? SNUMFORM { get; set; }
    public string? SINTER_PAY { get; set; }

    [ForeignKey("SINTER_PAY")]
    public Insudb.CLIENT? CLIENTSINTER_PAY { get; set; }
    public string? STYPE_ACC { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DLEDGER_DAT { get; set; }
    public int NUSER_SOL { get; set; }
    public int? NCHEQUELOCAT { get; set; }

    [ForeignKey("NCHEQUELOCAT")]
    public Insudb.TABLE5553? TABLE5553 { get; set; }
    public int NCOMPANY { get; set; }
    public string? SPROCESS { get; set; }
    public int? NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public DateTime? DPOSTED { get; set; }
    public int? NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public int NINPUTCHANNEL { get; set; }

    [ForeignKey("NINPUTCHANNEL")]
    public Insudb.TABLE5554? TABLE5554 { get; set; }
    public DateTime DVALDATE { get; set; }
    public string? SR_DEPNUM { get; set; }
    public int NORI_CURR { get; set; }
    public decimal NORI_AMOUNT { get; set; }
    public long? NSUPPORT_ID { get; set; }
    public int? NTYPESUPPORT { get; set; }

    [ForeignKey("NTYPESUPPORT")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public DateTime? DCOLLECTION { get; set; }
    public int? NCHEQUE_STAT { get; set; }

    [ForeignKey("NCHEQUE_STAT")]
    public Insudb.TABLE5576? TABLE5576 { get; set; }
    public long? NCASH_ID { get; set; }
    public decimal? NFIN_INT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NBANK_AGREE { get; set; }

    [ForeignKey("NBANK_AGREE")]
    public Insudb.TABLE7? TABLE7NBANK_AGREE { get; set; }
    public long? NPROPONUM { get; set; }
    public long? NBULLETINS { get; set; }
    public int? NCASE_NUM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCASE_NUM { get; set; }
    public int? NDEMAN_TYPE { get; set; }

    [NotMapped]
    public Insudb.CLAIM_CASE? CLAIM_CASENDEMAN_TYPE
    {
        get => CLAIM_CASENCASE_NUM;
        set => CLAIM_CASENCASE_NUM = value;
    }
    public long? NID { get; set; }
    public long? NBORDERUSED { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
}
