#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CERTIFICAT
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.SITUATION? SITUATIONSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.SITUATION? SITUATIONNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.SITUATION? SITUATIONNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.SITUATION? SITUATIONNPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SCUMUL_CODE { get; set; }
    public DateTime? DDAT_NO_CON { get; set; }
    public DateTime? DDATE_ORIGI { get; set; }
    public DateTime? DCHANGDAT { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NGROUP { get; set; }
    public DateTime? DISSUEDAT { get; set; }
    public DateTime? DMAXIMUM_DA { get; set; }
    public int NNO_CONVERS { get; set; }

    [ForeignKey("NNO_CONVERS")]
    public Insudb.NOCONVERS? NOCONVERS { get; set; }
    public long? NNOTE_BENEF { get; set; }
    public long? NNOTE_DRISK { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE13? TABLE13 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NPAYFREQ { get; set; }

    [ForeignKey("NPAYFREQ")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public decimal? NPREMIUM { get; set; }
    public DateTime? DPROPODAT { get; set; }
    public string? SRENEWAL { get; set; }
    public int NSITUATION { get; set; }

    [ForeignKey("NSITUATION")]
    public Insudb.SITUATION? SITUATIONNSITUATION { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public string? SSTATUSVA { get; set; }

    [ForeignKey("SSTATUSVA")]
    public Insudb.TABLE181? TABLE181 { get; set; }
    public int? NUSER_AMEND { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NSUS_BRANCH { get; set; }
    public int NWAIT_CODE { get; set; }

    [ForeignKey("NWAIT_CODE")]
    public Insudb.TAB_WAITPO? TAB_WAITPO { get; set; }
    public int? NSUS_PRODUCT { get; set; }
    public long? NSUS_POLICY { get; set; }
    public long? NSUS_CERTIF { get; set; }
    public DateTime? DNEXTRECEIP { get; set; }
    public long? NPROPONUM { get; set; }
    public int? NQUOTA { get; set; }
    public int? NDAYSFQ { get; set; }
    public string? SPRORSHORT { get; set; }
    public int? NDAYSSQ { get; set; }
    public string? SNUMFORM { get; set; }
    public string? SREINSURA { get; set; }
    public string? SCLAIMIND { get; set; }
    public string? SEXCEPTION { get; set; }
    public int? NEXCCAUSE { get; set; }
    public string? SPROPERUSE { get; set; }
    public string? SEXEMPTION { get; set; }
    public long? NIMAGENUM { get; set; }
    public string? SDIRIND { get; set; }
    public int NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public int? NBILL_DAY { get; set; }
    public int? NSENDADDR { get; set; }
    public string? SAUT_GUARVAL { get; set; }
    public int NSELLCHANNEL { get; set; }

    [ForeignKey("NSELLCHANNEL")]
    public Insudb.TABLE5532? TABLE5532 { get; set; }
    public DateTime? DCOLLSUS_INI { get; set; }
    public DateTime? DFER { get; set; }
    public DateTime? DCOLLSUS_END { get; set; }
    public int? NDAYS_QUOT { get; set; }
    public int NSUS_REASON { get; set; }

    [ForeignKey("NSUS_REASON")]
    public Insudb.TABLE5566? TABLE5566 { get; set; }
    public long? NPOL_QUOT { get; set; }
    public string? SSUS_ORIGI { get; set; }
    public DateTime? DDATE_ACCEPT { get; set; }
    public string? SANULLETTER { get; set; }
    public string? SBILL_IND { get; set; }
    public string? SREFUNDPREM { get; set; }
    public int NSTATQUOTA { get; set; }

    [ForeignKey("NSTATQUOTA")]
    public Insudb.TABLE5526? TABLE5526 { get; set; }
    public string? SPENDINFO { get; set; }
    public int? NRENEWALNUM { get; set; }
    public int? NDIGIT { get; set; }
    public long? NPROP_REG { get; set; }
    public int? NDAY_PAY { get; set; }
    public int? NDURATION { get; set; }
    public decimal? NAFP_COMMISS { get; set; }
    public int? NAFP_COMM_CURR { get; set; }
    public int? NORIGIN { get; set; }
    public long NCOLLECTOR { get; set; }

    [ForeignKey("NCOLLECTOR")]
    public Insudb.COLLECTOR? COLLECTOR { get; set; }
    public string? SFRACRECEIP { get; set; }
    public int NGROUP_AGREE { get; set; }

    [ForeignKey("NGROUP_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public int NMAILINGPREF { get; set; }
    public string? SRETARIF { get; set; }
    public DateTime? DLAST_TARIF { get; set; }
    public string? SOPERATION { get; set; }
    public DateTime? DTARIFFDATE { get; set; }
    public DateTime? DRECEPINT { get; set; }
    public DateTime? DRECEPINT_COMP { get; set; }
    public DateTime? DRECEPINSU { get; set; }
    public DateTime? DRECEPINSU_COMP { get; set; }
    public string? SAPPLYCOSTFP { get; set; }
    public string? SDETAILED_ENTRY_PRINTED { get; set; }
    public DateTime? DSALD_DATE { get; set; }
    public decimal? NRATE_BASE { get; set; }
    public long? NFOLIO { get; set; }
    public string? SFACULTATIV { get; set; }
    public string? SOFFICIALPOL { get; set; }
    public string? SOFFICIALCER { get; set; }
    public int? NSUS_OFFICE { get; set; }
    public int NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.SITUATION? SITUATIONNCOD_AGREE { get; set; }
    public int NTYPEEXC { get; set; }

    [ForeignKey("NTYPEEXC")]
    public Insudb.TABLE2? TABLE2 { get; set; }
    public string? SFILENUMBER { get; set; }
    public int NSYSTEM { get; set; }

    [ForeignKey("NSYSTEM")]
    public Insudb.TABLE9781? TABLE9781 { get; set; }
    public long? NCOVERAGECERTIFICATE { get; set; }
    public int? NSTATUSCOVERAGECERTIFICATE { get; set; }
    public DateTime? DRISKACCEPTED { get; set; }
    public string? SRECTYPE { get; set; }
    public string? SIND_MULTIANNUAL { get; set; }
    public int? NDEPRECIATIONTABLE { get; set; }
    public int? NPROMISSORY_NOTE { get; set; }
    public long? NPHONEID { get; set; }
    public long? NADDRESSID { get; set; }
    public string? SIND_IFI { get; set; }
    public int? NEXTRADAY { get; set; }
    public long? NPOLICY_TRANSFER { get; set; }
    public int? NCERTIF_TRANSFER { get; set; }
    public string? SCODBRANCH_TRANSFER { get; set; }
    public int? NFORMPAY { get; set; }
    public string? SCONTROL { get; set; }
    public DateTime? DPREVIUS_EXPIRDATE { get; set; }
    public string? SINDQSAMEVALUE { get; set; }
    public int? NCERTIF_ASSOCIATED { get; set; }
    public long? NPOLICY_ASSOCIATED { get; set; }
    public int? NOFFICE_ASSOCIATED { get; set; }
    public int? NOFFICEAGEN_ASSOCIATED { get; set; }
    public int? NAGENCY_ASSOCIATED { get; set; }
    public int? NBRANCH_ASSOCIATED { get; set; }
    public int? NPRODUCT_ASSOCIATED { get; set; }
    public int? NNOTCANCELDAY { get; set; }
    public string? SCLIENTSPONSOR { get; set; }
    public string? SCOMERPRODUCT { get; set; }
    public long? NCOMBPOLICY { get; set; }
    public long? NCAMP_RELEASE { get; set; }
    public long? NCAMPAIGN { get; set; }
    public string? SEXCEP_RANDOM { get; set; }
    public int? NSPECI_RANDOM { get; set; }
    public DateTime? DSUGGESTEDSTART { get; set; }
    public string? SISUGSTART { get; set; }
    public string? SPREVPOLNUM { get; set; }
}
