#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class POLICY
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.TABLE5632? TABLE5632 { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public string? SACCOUNTI { get; set; }
    public string? SBUSSITYP { get; set; }
    public string? SCOINSURI { get; set; }
    public string? SCOLINVOT { get; set; }

    [ForeignKey("SCOLINVOT")]
    public Insudb.TABLE50? TABLE50 { get; set; }
    public string? SCOLREINT { get; set; }

    [ForeignKey("SCOLREINT")]
    public Insudb.TABLE49? TABLE49 { get; set; }
    public string? SCOLTIMRE { get; set; }

    [ForeignKey("SCOLTIMRE")]
    public Insudb.TABLE25? TABLE25 { get; set; }
    public string? SCOMMITYP { get; set; }

    [ForeignKey("SCOMMITYP")]
    public Insudb.TABLE47? TABLE47 { get; set; }
    public string? SDECLARI { get; set; }
    public string? SDIRDEBIT { get; set; }
    public string? SINDEXTYP { get; set; }

    [ForeignKey("SINDEXTYP")]
    public Insudb.TABLE46? TABLE46 { get; set; }
    public string? SLEADINVO { get; set; }
    public string? SLEADNOTI { get; set; }
    public string? SLEADPOLI { get; set; }
    public string? SPOLITYPE { get; set; }
    public string? SPROPO_CERT { get; set; }
    public string? SRENEWAL { get; set; }
    public string? SREVALAPL { get; set; }

    [ForeignKey("SREVALAPL")]
    public Insudb.TABLE154? TABLE154 { get; set; }
    public string? SSTATUS_POL { get; set; }

    [ForeignKey("SSTATUS_POL")]
    public Insudb.TABLE181? TABLE181 { get; set; }
    public string? SSUBSTITI { get; set; }
    public string? STYP_CLAUSE { get; set; }

    [ForeignKey("STYP_CLAUSE")]
    public Insudb.TABLE92? TABLE92STYP_CLAUSE { get; set; }
    public string? STYP_DISCXP { get; set; }

    [ForeignKey("STYP_DISCXP")]
    public Insudb.TABLE92? TABLE92STYP_DISCXP { get; set; }
    public string? STYP_MODULE { get; set; }

    [ForeignKey("STYP_MODULE")]
    public Insudb.TABLE92? TABLE92STYP_MODULE { get; set; }
    public string? SNONULL { get; set; }
    public string? SCONCOLL { get; set; }
    public string? SNUMFORM { get; set; }
    public DateTime? DCHANGDAT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DDAT_NO_CON { get; set; }
    public DateTime? DDATE_ORIGI { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public DateTime? DISSUEDAT { get; set; }
    public DateTime? DMAXIMUM_DA { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DPROPODAT { get; set; }
    public DateTime? DNEXTRECEIP { get; set; }
    public decimal? NAMOUCOMM { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOLCLADI { get; set; }
    public decimal? NCOMMISSI { get; set; }
    public decimal? NINDEXFAC { get; set; }
    public decimal? NLEADCOMI { get; set; }
    public decimal? NLEADEXPE { get; set; }
    public decimal? NLEADSHARE { get; set; }
    public decimal? NPARTICIP { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NSHARE { get; set; }
    public int NPAYFREQ { get; set; }

    [ForeignKey("NPAYFREQ")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public long? NLAST_CERTI { get; set; }
    public long? NNOTE_ADEND { get; set; }
    public long? NNOTE_BENEF { get; set; }
    public long? NNOTE_COMME { get; set; }
    public long? NNOTE_CONDI { get; set; }
    public long? NNOTE_COVER { get; set; }
    public long? NPROPONUM { get; set; }
    public long? NQ_CERTIF { get; set; }
    public long? NTRANSACTIO { get; set; }
    public long? NMOV_HISTOR { get; set; }
    public long? NOFICIAL_P { get; set; }
    public int? NCOPIES { get; set; }
    public int NLEADCOMP { get; set; }

    [ForeignKey("NLEADCOMP")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public int NNO_CONVERS { get; set; }

    [ForeignKey("NNO_CONVERS")]
    public Insudb.NOCONVERS? NOCONVERS { get; set; }
    public int? NNOTICE { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE13? TABLE13 { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int? NOFFICE_OWN { get; set; }
    public int? NTARIFF { get; set; }
    public int? NUSER_AMEND { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NQUOTA { get; set; }
    public string? STYPE_PROP { get; set; }
    public string? SPRORSHORT { get; set; }
    public int? NDAYSFQ { get; set; }
    public int? NDAYSSQ { get; set; }
    public int NCOMPANY { get; set; }
    public int NOFFICEINS { get; set; }
    public string? SORIGINAL { get; set; }
    public int NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public string? STYPENOM { get; set; }
    public string? SNOPAYROLL { get; set; }
    public string? SINSUBANK { get; set; }
    public decimal? NLEGAMOUNT { get; set; }
    public string? SLEG { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE5555? TABLE5555 { get; set; }
    public int NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public string? SCOLTPRES { get; set; }

    [ForeignKey("SCOLTPRES")]
    public Insudb.TABLE92? TABLE92SCOLTPRES { get; set; }
    public string? SIND_COMM { get; set; }
    public string? SCURRACC { get; set; }
    public int NREPINSURED { get; set; }

    [ForeignKey("NREPINSURED")]
    public Insudb.TABLE5677? TABLE5677 { get; set; }
    public int? NLOCAL { get; set; }
    public DateTime? DDATERENOVA { get; set; }
    public int? NCLAIM_NOTICE { get; set; }
    public string? SMASSIVE { get; set; }
    public string? SREPPRINTCOV { get; set; }
    public string? SRECEIPT_IND { get; set; }
    public string? SDOCUTYP { get; set; }
    public int? NTERM_GRACE { get; set; }
    public long? NPRODCLAS { get; set; }
    public int? NAGREEMENT { get; set; }
    public string? SACCHSEND_IND { get; set; }
    public int? NTYPEACCOUNT { get; set; }
    public DateTime? DPREVIUS_EXPIRDATE { get; set; }
    public int NSPECIALBUSINESS { get; set; }

    [ForeignKey("NSPECIALBUSINESS")]
    public Insudb.TABLE5770? TABLE5770 { get; set; }
    public int? NLEADYM { get; set; }
    public DateTime? DEXPIRDATANT { get; set; }
    public string? STYPCALC_FLATPREM { get; set; }

    [ForeignKey("STYPCALC_FLATPREM")]
    public Insudb.TABLE9233? TABLE9233 { get; set; }
    public string? STYPDIS_PAYPERCEN { get; set; }

    [ForeignKey("STYPDIS_PAYPERCEN")]
    public Insudb.TABLE9235? TABLE9235 { get; set; }
    public decimal? NPARTICIP_POLEMP { get; set; }
    public decimal? NPARTICIP_POLCO { get; set; }
    public string? SPREVPOLNUM { get; set; }
}
