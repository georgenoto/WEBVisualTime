#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PRODUCT
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NCANCNOTI { get; set; }
    public string? SCOLINVOT { get; set; }

    [ForeignKey("SCOLINVOT")]
    public Insudb.TABLE50? TABLE50 { get; set; }
    public int? NCLAIM_PRES { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCOPIES { get; set; }
    public string? SCUMREINT { get; set; }

    [ForeignKey("SCUMREINT")]
    public Insudb.TABLE90? TABLE90 { get; set; }
    public long? NQ_CERTIF { get; set; }
    public string? SCUMULTYP { get; set; }

    [ForeignKey("SCUMULTYP")]
    public Insudb.TABLE79? TABLE79 { get; set; }
    public string? SDECLAAUT { get; set; }
    public string? STYP_CLAUSE { get; set; }

    [ForeignKey("STYP_CLAUSE")]
    public Insudb.TABLE92? TABLE92STYP_CLAUSE { get; set; }
    public string? STYP_DISCXP { get; set; }

    [ForeignKey("STYP_DISCXP")]
    public Insudb.TABLE92? TABLE92STYP_DISCXP { get; set; }
    public string? STYP_MODULE { get; set; }

    [ForeignKey("STYP_MODULE")]
    public Insudb.TABLE92? TABLE92STYP_MODULE { get; set; }
    public int? NDURATION { get; set; }
    public string? SGROUPIND { get; set; }
    public string? SINDIVIND { get; set; }
    public string? SMULTIIND { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NPAYFREQ { get; set; }

    [ForeignKey("NPAYFREQ")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public string? SPOLITYPE { get; set; }
    public int? NQMAXCURR { get; set; }
    public string? SREINTYPE { get; set; }

    [ForeignKey("SREINTYPE")]
    public Insudb.TABLE8? TABLE8 { get; set; }
    public string? SRENEWAL { get; set; }
    public string? SREVALAPL { get; set; }

    [ForeignKey("SREVALAPL")]
    public Insudb.TABLE154? TABLE154 { get; set; }
    public decimal? NREVALRAT { get; set; }
    public string? SREVALTYP { get; set; }

    [ForeignKey("SREVALTYP")]
    public Insudb.TABLE46? TABLE46 { get; set; }
    public string? SSTYLE_COMM { get; set; }

    [ForeignKey("SSTYLE_COMM")]
    public Insudb.TABLE161? TABLE161SSTYLE_COMM { get; set; }
    public string? SSTYLE_PREM { get; set; }

    [ForeignKey("SSTYLE_PREM")]
    public Insudb.TABLE161? TABLE161SSTYLE_PREM { get; set; }
    public string? SSTYLE_TAX { get; set; }

    [ForeignKey("SSTYLE_TAX")]
    public Insudb.TABLE161? TABLE161SSTYLE_TAX { get; set; }
    public int? NTARIFF { get; set; }
    public string? STIMEREN { get; set; }

    [ForeignKey("STIMEREN")]
    public Insudb.TABLE25? TABLE25 { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SWIN_DECLAR { get; set; }
    public long? NINSMAXIQ { get; set; }
    public long? NINSMINIQ { get; set; }
    public string? SHOLDER { get; set; }

    [ForeignKey("SHOLDER")]
    public Insudb.TABLE45? TABLE45 { get; set; }
    public int? NQDAYS_PRO { get; set; }
    public int? NQUOTA { get; set; }
    public string? SGROUPSI { get; set; }
    public int? NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public int? NBILL_DAY { get; set; }
    public int? NREHABPERIOD { get; set; }
    public string? STYP_DOM { get; set; }
    public string? SLEG { get; set; }
    public int? NNOTCANCELDAY { get; set; }
    public string? SREINST { get; set; }
    public string? SDATECOLL { get; set; }
    public int? NCLAIM_NOTICE { get; set; }
    public int? NQDAYS_QUO { get; set; }
    public int? NCLAIM_PAY { get; set; }
    public int? NMONTH_SURR { get; set; }
    public string? SFIRST_PAY { get; set; }
    public string? SROUTAUT_R { get; set; }
    public string? SNUMPROP { get; set; }
    public string? SFRACRECEIP { get; set; }
    public string? SCONDSVS { get; set; }
    public string? SAUTO_SUSC { get; set; }
    public int? NREPINSURED { get; set; }

    [ForeignKey("NREPINSURED")]
    public Insudb.TABLE5677? TABLE5677 { get; set; }
    public int? NQDAYS_DIFQUO { get; set; }
    public int? NREHABPERIOD_AUT { get; set; }
    public string? SRECSEC { get; set; }
    public string? SRETARIF { get; set; }
    public int? NMONTH_SETPR { get; set; }
    public string? SSETPREM { get; set; }
    public string? SLETTER { get; set; }
    public string? SMASSIVE { get; set; }
    public string? STARQUO_IND { get; set; }
    public int? NPAYABLE { get; set; }
    public int? NADVANCE { get; set; }
    public int? NREACTPERIOD_AUT { get; set; }
    public string? SREACTIVATION { get; set; }
    public int? NREACTPERIOD { get; set; }
    public string? SROUTREACT { get; set; }
    public int? NCHUSERLEV { get; set; }
    public string? SNAME_REPORT { get; set; }
    public string? SRATINGSERVICEUSING { get; set; }
    public string? SROU_WARNING_CHARG { get; set; }
    public string? SROU_COVER { get; set; }
    public int? NCURR_RECEIPT { get; set; }
    public string? SRESOLUTIONSBS { get; set; }
    public string? SAUTOMATICBILL { get; set; }
    public int? NMODULEMIN { get; set; }
    public int? NTYPEACCOUNT { get; set; }
    public int? NASSOCIATEDBRANCH { get; set; }
    public string? SASSOCIATED_POLICY_REQUIRED { get; set; }
    public int? NPERBASIC { get; set; }
    public string? SPREMIUMZEROIND { get; set; }
    public string? SNOTGENRECEIPT { get; set; }
    public string? SCOMERPRODUCT { get; set; }
    public string? SCLIENT { get; set; }
    public int? NSELLCHANNEL { get; set; }
    public string? SNATIONALS { get; set; }
    public int? NCLASSIFICATION { get; set; }

    [ForeignKey("NCLASSIFICATION")]
    public Insudb.TABLE9223? TABLE9223 { get; set; }
    public string? SRESOLUTION { get; set; }
    public string? SGOVAPRNAME { get; set; }
    public DateTime? DRESDATE { get; set; }
}
