#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DETAIL_PRE
{
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.PREMIUM? PREMIUMNPRODUCT { get; set; }
    public long NRECEIPT { get; set; }

    [ForeignKey("NRECEIPT")]
    public Insudb.PREMIUM? PREMIUMNRECEIPT { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.PREMIUM? PREMIUMNBRANCH { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.PREMIUM? PREMIUMSCERTYPE { get; set; }
    public int NDIGIT { get; set; }

    [ForeignKey("NDIGIT")]
    public Insudb.PREMIUM? PREMIUMNDIGIT { get; set; }
    public int NPAYNUMBE { get; set; }

    [ForeignKey("NPAYNUMBE")]
    public Insudb.PREMIUM? PREMIUMNPAYNUMBE { get; set; }
    public int NID_BILL { get; set; }
    public string? SADDSUINI { get; set; }
    public string STYPE_DETAI { get; set; }
    public int? NDET_CODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOMMI_RATE { get; set; }
    public decimal? NCOMMISION { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NTAX { get; set; }
    public int? NBILL_ITEM { get; set; }
    public int NBRANCH_EST { get; set; }

    [ForeignKey("NBRANCH_EST")]
    public Insudb.TABLE71? TABLE71 { get; set; }
    public int NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPREMANUAL { get; set; }
    public string? SADDTAX { get; set; }
    public decimal? NCOMANUAL { get; set; }
    public decimal? NPREMIUMA { get; set; }
    public decimal? NPREMIUME { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NRECAMOUNT { get; set; }
    public decimal? NDESCAMOUNT { get; set; }
    public int? NREL_IDBILL { get; set; }
    public string? SCLIENT { get; set; }
    public int? NREL_IDCODE { get; set; }
    public decimal? NSTIPEND_AMOUNT { get; set; }
    public decimal? NSTIPEND_ANNUAL { get; set; }
    public decimal? NTAXRATE { get; set; }
    public int NDISSUR_TYPE { get; set; }

    [ForeignKey("NDISSUR_TYPE")]
    public Insudb.TABLE9207? TABLE9207 { get; set; }
    public decimal? NCOM_SUPER { get; set; }
    public decimal? NCOMANUAL_SUPER { get; set; }
    public decimal? NCOMSUP_RATE { get; set; }
}
