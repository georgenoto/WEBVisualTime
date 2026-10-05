#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MOVE_ACC
{
    public int NTYP_ACCO { get; set; }

    [ForeignKey("NTYP_ACCO")]
    public Insudb.CURR_ACC? CURR_ACCNTYP_ACCO { get; set; }
    public string STYPE_ACC { get; set; }

    [ForeignKey("STYPE_ACC")]
    public Insudb.CURR_ACC? CURR_ACCSTYPE_ACC { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CURR_ACC? CURR_ACCSCLIENT { get; set; }
    public int NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.CURR_ACC? CURR_ACCNCURRENCY { get; set; }
    public DateTime DOPERDATE { get; set; }
    public long NIDCONSEC { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public decimal? NAMOUNT { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public int? NBRANCH { get; set; }
    public long? NCERTIF { get; set; }
    public string? SCHEQUE { get; set; }
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public decimal? NCREDIT { get; set; }
    public decimal? NDEBIT { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SMANUALMOV { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long? NPOLICY { get; set; }
    public long? NRECEIPT { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NTRANSAC { get; set; }
    public int? NTRANSACTIO { get; set; }
    public int NTYPE_MOVE { get; set; }

    [ForeignKey("NTYPE_MOVE")]
    public Insudb.TABLE401? TABLE401 { get; set; }
    public int NTYPE_PAY { get; set; }

    [ForeignKey("NTYPE_PAY")]
    public Insudb.TABLE137? TABLE137 { get; set; }
    public int NTYPE_TRAN { get; set; }

    [ForeignKey("NTYPE_TRAN")]
    public Insudb.TABLE6? TABLE6 { get; set; }
    public int? NUSERCODE { get; set; }
    public int NPROVINCE { get; set; }

    [ForeignKey("NPROVINCE")]
    public Insudb.PROVINCE? PROVINCE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long? NIDDOCUMENT { get; set; }
    public long? NREQUEST_NU { get; set; }
    public long NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public string? SPROCESS { get; set; }
    public string? SNUMFORM { get; set; }
    public int? NORIGCURR { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public string? SAUTORIZA { get; set; }
    public DateTime? DVALUEDATE { get; set; }
    public int? NPRODUCT { get; set; }
    public string? SNULL_RECOR { get; set; }
    public int? NCASHNUM { get; set; }
    public decimal? NAMOAFECT { get; set; }
    public decimal? NAMOEXEN { get; set; }
    public long? NPAY_COMM { get; set; }
    public long? NCURR_ACC { get; set; }
    public DateTime? DPOSTED { get; set; }
    public string? SPROCESS_IND { get; set; }
    public long? NPROPONUM { get; set; }
    public long NBULLETINS { get; set; }
    public long? NNOTENUM { get; set; }
    public long NID { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
    public long? NOBLIGATION { get; set; }
    public long? NSERV_ORDER { get; set; }
    public int? NTYPESUPPORT { get; set; }
    public long? NDOCUMENT { get; set; }
    public decimal? NAMOUNT_LOC { get; set; }
    public decimal? NBALANCE { get; set; }
    public string? SCLIENT_REL { get; set; }
    public string? SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE182? TABLE182 { get; set; }
    public int? NCOD_AGREE { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SDEP_NUMBER { get; set; }
    public int? NTODAYSDEPOSIT { get; set; }
    public int? NRETENTIONTAXCODE { get; set; }
    public int? NRETENTIONCODE { get; set; }
    public string? NRETENTIONSERIES { get; set; }
    public DateTime? DENDINGDATE { get; set; }
    public decimal? NRETENTION { get; set; }
    public decimal? NTAXRETENTION { get; set; }
    public decimal? NRETENTIONBASE { get; set; }
    public string? NAUTORIZATIONNUMBER { get; set; }
    public DateTime? DAUTORIZATIONDATE { get; set; }
    public DateTime? DCTB_DATE { get; set; }
    public string? SPOSTEDSEQUENCE { get; set; }
    public decimal? NORI_AMOUNT { get; set; }
    public string? SSCAB { get; set; }
    public DateTime? DDATE_SCAB { get; set; }
    public long? NSEQ { get; set; }
}
