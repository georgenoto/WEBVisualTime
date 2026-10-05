#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PREMIUM_CE
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.PREMIUM? PREMIUMSCERTYPE { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.PREMIUM? PREMIUMNPRODUCT { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.PREMIUM? PREMIUMNBRANCH { get; set; }
    public long NRECEIPT { get; set; }

    [ForeignKey("NRECEIPT")]
    public Insudb.PREMIUM? PREMIUMNRECEIPT { get; set; }
    public int NDIGIT { get; set; }

    [ForeignKey("NDIGIT")]
    public Insudb.PREMIUM? PREMIUMNDIGIT { get; set; }
    public int NPAYNUMBE { get; set; }

    [ForeignKey("NPAYNUMBE")]
    public Insudb.PREMIUM? PREMIUMNPAYNUMBE { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public string STYPE_DETAI { get; set; }
    public int NID_BILL { get; set; }
    public int NCODE_DETAI { get; set; }
    public int? NBILL_ITEM { get; set; }
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NPREMIUMN { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public int NTRATYPEI { get; set; }

    [ForeignKey("NTRATYPEI")]
    public Insudb.TABLE24? TABLE24 { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPREMANUAL { get; set; }
    public decimal? NCOMANUAL { get; set; }
    public string? SADDTAX { get; set; }
    public decimal? NPREMIUMA { get; set; }
    public decimal? NPREMIUME { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NRECAMOUNT { get; set; }
    public decimal? NDESCAMOUNT { get; set; }
    public int? NORIGI { get; set; }
    public int? NREL_IDBILL { get; set; }
    public string? SCLIENT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOMMI_RATE { get; set; }
    public decimal? NCOMMISION { get; set; }
    public int? NDISSUR_TYPE { get; set; }
}
