#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BOOK_PRODUCTION
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NRECEIPT { get; set; }
    public long NTRANSAC { get; set; }
    public string SKEY { get; set; }
    public string? SCLIENTSPONSOR { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int NCERTIF { get; set; }
    public DateTime? DDATE_ACCEPT { get; set; }
    public string? SCLIENT_ASEG { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NPREMIUME_MO { get; set; }
    public decimal? NPREMIUMA_MO { get; set; }
    public decimal? NPREMIUM_MO { get; set; }
    public decimal? NPREMIUME { get; set; }
    public decimal? NPREMIUMA { get; set; }
    public string? SCLIENT_AGEN { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NCOMAMOU_MO { get; set; }
    public decimal? NCOMAMOU_PES { get; set; }
    public DateTime? DPOSTED { get; set; }
    public int NBRANCH_LED { get; set; }
    public int? NCOMPANY { get; set; }
    public int? NINSUR_AREA { get; set; }
    public DateTime? DSTARTDATE_REP { get; set; }
    public DateTime? DEXPIRDATE_REP { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public long? NPROPONUM { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE5555? TABLE5555 { get; set; }
    public int NTRATYPEI { get; set; }

    [ForeignKey("NTRATYPEI")]
    public Insudb.TABLE24? TABLE24 { get; set; }
    public int? NTYPE { get; set; }
    public int NTYPE_TRAN { get; set; }

    [ForeignKey("NTYPE_TRAN")]
    public Insudb.TABLE6? TABLE6 { get; set; }
    public decimal? NTAXAMOUNT_MO { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public int? NACCCRITERION { get; set; }
}
