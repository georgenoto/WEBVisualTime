#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PREMIUM
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public long NRECEIPT { get; set; }
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
    public int NDIGIT { get; set; }
    public int NPAYNUMBE { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public string? SCESSIONS { get; set; }
    public long? NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public string? SDIRDEBIT { get; set; }
    public string? SLEADINVO { get; set; }
    public string? SMANAUTI { get; set; }
    public string? SRENEWAL { get; set; }
    public string? SSUBSTITI { get; set; }
    public int? NSTATUS_PRE { get; set; }

    [ForeignKey("NSTATUS_PRE")]
    public Insudb.TABLE19? TABLE19 { get; set; }
    public string? SCONCOLL { get; set; }
    public string? SSTATUSVA { get; set; }

    [ForeignKey("SSTATUSVA")]
    public Insudb.TABLE181? TABLE181 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public DateTime? DISSUEDAT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DPAYDATE { get; set; }
    public DateTime? DSTATDATE { get; set; }
    public decimal? NBALANCE { get; set; }
    public decimal? NCOMAMOU { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public decimal? NINTAMMOU { get; set; }
    public decimal? NPARTICIP { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NPREMIUML { get; set; }
    public decimal? NPREMIUMN { get; set; }
    public decimal? NPREMIUMS { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NTAXAMOU { get; set; }
    public long? NCOLLECTO { get; set; }
    public long? NCONTRAT { get; set; }
    public long? NINSPECTO { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public long? NSUSTIT { get; set; }
    public long? NTRANSACTIO { get; set; }
    public int? NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE95? TABLE95 { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NNOTENUM { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int? NTYPE { get; set; }
    public int? NTRATYPEI { get; set; }

    [ForeignKey("NTRATYPEI")]
    public Insudb.TABLE24? TABLE24 { get; set; }
    public int NUSERCODE { get; set; }
    public int? NPERIOD { get; set; }
    public int? NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public string? SORIGRECEIPT { get; set; }
    public int? NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public DateTime? DLIMITDATE { get; set; }
    public int? NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public int? NINDRECDEP { get; set; }

    [ForeignKey("NINDRECDEP")]
    public Insudb.TABLE5600? TABLE5600 { get; set; }
    public DateTime? DCOLLSUS_INI { get; set; }
    public DateTime? DCOLLSUS_END { get; set; }
    public int? NSUS_REASON { get; set; }

    [ForeignKey("NSUS_REASON")]
    public Insudb.TABLE5566? TABLE5566 { get; set; }
    public string? SSUS_ORIGI { get; set; }
    public string? SREJECT { get; set; }
    public long? NCOLLECTOR { get; set; }

    [ForeignKey("NCOLLECTOR")]
    public Insudb.COLLECTOR? COLLECTOR { get; set; }
    public long? NIDLOANS { get; set; }
    public int? NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public string? SBILLTYPE { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SINDCHEQUE { get; set; }
    public string? SIND_CAP { get; set; }
    public long? NBULLETINS { get; set; }
    public string? SINDMARGIN { get; set; }
    public string? SIND_RESERV { get; set; }
    public int? NYEARMONTHDESC { get; set; }
    public int? NBILL_DAY { get; set; }
    public int? NPAYFREQ { get; set; }
    public string? SDOCUMENT { get; set; }
    public long? NBANK_CODE { get; set; }
    public int? NSITUATION { get; set; }
    public decimal? NSTIPEND_AMOUNT { get; set; }
    public long? NCOLLECTOR_ASSIG { get; set; }
    public decimal? NPREMIUMTEC { get; set; }
    public string? SCLINUMDOCU { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
    public int? NCLASSTYPDOC { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
