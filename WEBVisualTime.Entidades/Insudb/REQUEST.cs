#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REQUEST
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NORIGIN { get; set; }

    [ForeignKey("NORIGIN")]
    public Insudb.TABLE5580? TABLE5580 { get; set; }
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
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? STYP_SURR { get; set; }
    public string? SPAYORDER { get; set; }

    [ForeignKey("SPAYORDER")]
    public Insudb.TABLE193? TABLE193 { get; set; }
    public string? SNULL_REC { get; set; }
    public decimal? NAMOUNT { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE13? TABLE13 { get; set; }
    public int? NTYP_REC { get; set; }
    public string? SREH_LREC { get; set; }
    public decimal? NINTERESTRATE { get; set; }
    public int? NTYPEPAY { get; set; }

    [ForeignKey("NTYPEPAY")]
    public Insudb.TABLE5527? TABLE5527 { get; set; }
    public DateTime? DMOVDATE { get; set; }
    public long? NREQUEST_NU { get; set; }
    public string? SCLIPAYSURR { get; set; }

    [ForeignKey("SCLIPAYSURR")]
    public Insudb.CLIENT? CLIENTSCLIPAYSURR { get; set; }
    public string? SCERTPAYSURR { get; set; }

    [ForeignKey("SCERTPAYSURR, NBRAPAYSURR, NPROPAYSURR, NPOLPAYSURR, NCERPAYSURR")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTPAYSURR { get; set; }
    public int? NBRAPAYSURR { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRAPAYSURR
    {
        get => CERTIFICATSCERTPAYSURR;
        set => CERTIFICATSCERTPAYSURR = value;
    }
    public int? NPROPAYSURR { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPROPAYSURR
    {
        get => CERTIFICATSCERTPAYSURR;
        set => CERTIFICATSCERTPAYSURR = value;
    }
    public long? NPOLPAYSURR { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLPAYSURR
    {
        get => CERTIFICATSCERTPAYSURR;
        set => CERTIFICATSCERTPAYSURR = value;
    }
    public long? NCERPAYSURR { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERPAYSURR
    {
        get => CERTIFICATSCERTPAYSURR;
        set => CERTIFICATSCERTPAYSURR = value;
    }
    public int? NAGENCY { get; set; }
    public int? NSURR_REASON { get; set; }

    [ForeignKey("NSURR_REASON")]
    public Insudb.TABLE5635? TABLE5635 { get; set; }
    public int? NTYPE_PAYMENT { get; set; }

    [ForeignKey("NTYPE_PAYMENT")]
    public Insudb.TABLE5636? TABLE5636 { get; set; }
    public int? NINSTITUTION { get; set; }

    [ForeignKey("NINSTITUTION")]
    public Insudb.TAB_FN_INSTITUTION? TAB_FN_INSTITUTION { get; set; }
    public string? SCLIENTINSTITUTION { get; set; }

    [ForeignKey("SCLIENTINSTITUTION")]
    public Insudb.CLIENT? CLIENTSCLIENTINSTITUTION { get; set; }
    public string? SRETURN_IND { get; set; }
    public decimal? NRETURN_RAT { get; set; }
    public int? NORIGIN_APV { get; set; }
    public decimal? NCOSTAMOUNT { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NTAX_RENT { get; set; }
    public int NFUNDS { get; set; }
    public int? NSIGNAL { get; set; }
    public decimal? NUNITSCHANGE { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NSELL_COST { get; set; }
    public decimal? NBUY_COST { get; set; }
    public decimal? NSWI_COST { get; set; }
    public decimal? NVALUECHANGE { get; set; }
    public int? NSWITCHORIGIN { get; set; }
    public string? SSWITCHSTATUS { get; set; }
    public string? SIND_INSUR { get; set; }
    public DateTime? DPAYMENTDATE { get; set; }
    public long? NTYP_PROFITWORKER { get; set; }
    public decimal? NCOST_COV_DEV { get; set; }
    public decimal? NRENTABILITY { get; set; }
    public decimal? NAMOUNT_REC_DEV { get; set; }
    public decimal? NAMOUNT_DEV { get; set; }
    public string? SSWITCHORIGIN { get; set; }
    public long? NPROPONUM { get; set; }
}
