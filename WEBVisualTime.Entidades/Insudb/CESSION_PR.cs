#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CESSION_PR
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NCESSION_NU { get; set; }
    public int NNUM_CESS { get; set; }
    public int NNUMBER { get; set; }

    [ForeignKey("NNUMBER, NBRANCH_REI, DEFD_CONTRPROC, NTYPE")]
    public Insudb.CONTRPROC? CONTRPROCNNUMBER { get; set; }
    public int NID { get; set; }
    public int? NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public decimal? NCAPITAL { get; set; }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public decimal NCOMMISSION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE533? TABLE533 { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NINTER_RATE { get; set; }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public decimal NPREMIUM { get; set; }
    public string? SPRINT_CE { get; set; }
    public decimal? NRESER_PREM { get; set; }
    public string? SRETENTION { get; set; }
    public decimal? NSHARE { get; set; }
    public long? NTYPE_CESSI { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NEXPENSIV { get; set; }
    public int? NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public int? NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public int? NGROUP_INSU { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DEFD_CONTRPROC { get; set; }

    [NotMapped]
    public Insudb.CONTRPROC? CONTRPROCDEFD_CONTRPROC
    {
        get => CONTRPROCNNUMBER;
        set => CONTRPROCNNUMBER = value;
    }
    public int NYEARMONTH { get; set; }
    public decimal? NCAPCESS { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public decimal NCESSPREM { get; set; }
    public decimal NCESSEXTRAPR { get; set; }
    public int NTYPE { get; set; }

    [NotMapped]
    public Insudb.CONTRPROC? CONTRPROCNTYPE
    {
        get => CONTRPROCNNUMBER;
        set => CONTRPROCNNUMBER = value;
    }
    public DateTime? DEFFECDATE { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NDIGIT { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long? NTRANSAC { get; set; }
    public decimal? NRATE_TAR { get; set; }
    public decimal? NPREM_TAR { get; set; }
    public int? NINSUAGE { get; set; }
    public string? SSMOKING { get; set; }
    public DateTime? DBIRTHDATE { get; set; }
    public string? SSEXCLIEN { get; set; }
    public int? NTYPERISK { get; set; }
    public decimal? NRESERVE { get; set; }
    public DateTime? DSTART_PROC { get; set; }
    public DateTime? DEND_PROC { get; set; }
    public decimal? NTAXRATE { get; set; }
    public decimal? NFACTOR { get; set; }
    public decimal? NRATE_FAC { get; set; }
    public decimal? NRATE_REA { get; set; }
    public string? SEXTRAPREM { get; set; }
    public DateTime? DINIEXPR { get; set; }
    public DateTime? DENDEXPR { get; set; }
    public decimal? NFACTOREXT { get; set; }
    public decimal? NCODEXTRA { get; set; }
    public int? NPOLYEAR { get; set; }
    public DateTime? DPOSTED { get; set; }
    public string? SKEY { get; set; }
    public DateTime? DCTB_DATE { get; set; }
    public string? SPOSTEDSEQUENCE { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SINDPROCESS { get; set; }
    public decimal? NCTA_X_PAGAR { get; set; }
    public decimal? NVALUE_BASERETENCOMM { get; set; }
    public decimal? NVALUE_PREMCED { get; set; }
    public decimal? NVALUE_RETENTAXPRE { get; set; }
    public decimal? NVALUE_BASERETENPRECED { get; set; }
    public decimal? NVALUE_RETENCOMM { get; set; }
    public decimal? NCOMISSION_IVA { get; set; }
    public decimal? NUN_PER_REM { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
}
