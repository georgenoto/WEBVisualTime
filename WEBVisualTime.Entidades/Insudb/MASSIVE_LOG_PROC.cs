#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASSIVE_LOG_PROC
{
    public string SKEY { get; set; }

    [ForeignKey("SKEY")]
    public Insudb.MASS_PROC_SPONSOR? MASS_PROC_SPONSORSKEY { get; set; }
    public long NKEY { get; set; }
    public string? SCERTYPE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NCLAIM { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NDIGIT { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long NSEQ { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NDECLAREDCLAIM { get; set; }
    public decimal? NCLAIMSPAID { get; set; }
    public decimal? NRECEIPTPAID { get; set; }
    public string? SCANCELEDCLAIMS { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NROLE { get; set; }
    public string? SCLIENT { get; set; }
    public string SITEM { get; set; }
    public long NROW { get; set; }
    public long? NCOMBPOLICY { get; set; }
    public decimal? NCOMMISION { get; set; }
    public decimal? NSTIPEND_AMOUNT { get; set; }
    public long NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.MASS_PROC_SPONSOR? MASS_PROC_SPONSORNCOD_AGREE { get; set; }
    public decimal? NAMOUNT_ORI { get; set; }
    public decimal? NAMOUNT_LOC { get; set; }
    public int? NACTION { get; set; }
    public string? SLOT { get; set; }
    public string? SCOMERPRODUCT { get; set; }
    public string? SOFFICIALPOL { get; set; }
    public decimal? NPREMIUMN { get; set; }
    public int? NPAYFREQ { get; set; }
    public int? NWAY_PAY { get; set; }
    public string? SPREVNUMPOL { get; set; }
    public DateTime? DDATEORIGINCERT { get; set; }
}
