#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_CASH_MOV
{
    public long NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public int NSEQUENCE { get; set; }
    public int? NACC_CASH { get; set; }
    public int? NLOCAL { get; set; }

    [ForeignKey("NLOCAL")]
    public Insudb.TAB_LOCAT? TAB_LOCAT { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
    public string? SCARD_NUM { get; set; }
    public int? NCARD_TYP { get; set; }
    public DateTime? DDOC_DATE { get; set; }
    public string? SDOCNUMBE { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int? NMOV_TYPE { get; set; }
    public long? NBANK_CODE { get; set; }
    public int? NCOMPANY { get; set; }
    public int? NTRANSAC { get; set; }
    public int? NCHEQUELOCAT { get; set; }
    public int? NCASH_NUM { get; set; }
    public int? NOFFICE { get; set; }
    public int? NCASHNUM { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public long? NCLAIM { get; set; }
    public int? NCONCEPT { get; set; }
    public int? NACC_BANK { get; set; }
    public int? NCARD_TYPE { get; set; }
    public int? NBRANCH_LED { get; set; }
    public DateTime? DCARD_EXPIR { get; set; }
    public int? NCL_TRANSAC { get; set; }
    public int? NCOMPANYC { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NVOUCHER_LE { get; set; }
    public long? NVOUCHER { get; set; }
    public long? NCONTRAT { get; set; }
    public string? SDEP_NUMBER { get; set; }
    public int? NDRAFT { get; set; }
    public long? NINTERMED { get; set; }
    public string? SNULL_MOVEM { get; set; }
    public string? SNULL_RECOR { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NYEAR_MONTH { get; set; }
    public int? NTYP_ACCO { get; set; }
    public string? SCLIENT { get; set; }
    public string? SNUMFORM { get; set; }
    public string? SINTER_PAY { get; set; }
    public string? STYPE_ACC { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DLEDGER_DAT { get; set; }
    public int? NUSER_SQL { get; set; }
    public string? SPROCESS { get; set; }
    public int? NINSUR_AREA { get; set; }
    public DateTime? DPOSTED { get; set; }
    public int? NCOD_AGREE { get; set; }
    public int? NINPUTCHANNEL { get; set; }
    public DateTime? DVALDATE { get; set; }
    public string? SR_DEPNUM { get; set; }
    public int? NORI_CURR { get; set; }
    public decimal? NORI_AMOUNT { get; set; }
    public long? NSUPPORT_ID { get; set; }
    public int? NTYPESSUPORT { get; set; }
    public DateTime? DCOLLECTION { get; set; }
    public int? NCHEQUE_STAT { get; set; }
    public long? NCASH_ID { get; set; }
    public decimal? NFIN_INT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NBANK_AGREE { get; set; }
    public long? NPROPONUM { get; set; }
    public long? NBULLETINS { get; set; }
    public int? NCASE_NUM { get; set; }
    public int? NDEMAN_TYPE { get; set; }
    public string? SACTION { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
}
