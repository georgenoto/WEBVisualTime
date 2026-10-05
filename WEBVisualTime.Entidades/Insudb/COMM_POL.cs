#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMM_POL
{
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int NCURRENCY { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public int NID { get; set; }
    public int NTYPMOV_COMM { get; set; }

    [ForeignKey("NTYPMOV_COMM")]
    public Insudb.TABLE5567? TABLE5567 { get; set; }
    public string? STYP_COMM { get; set; }
    public decimal NTOTAL_COM { get; set; }
    public int NINSTALLMENTS { get; set; }
    public int NPEN_INSTALL { get; set; }
    public decimal NINSTALL_AMO { get; set; }
    public long? NPAY_COMM { get; set; }
    public long? NCURR_ACC { get; set; }
    public decimal NAVAILABLE { get; set; }
    public decimal? NAVAIL_AFEC { get; set; }
    public decimal? NAVAIL_EXEN { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NSTATUS_COMM { get; set; }

    [ForeignKey("NSTATUS_COMM")]
    public Insudb.TABLE5568? TABLE5568 { get; set; }
    public string? STYPEDOCU { get; set; }
    public long? NDOCUMENT { get; set; }
    public int? NDRAFT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NTRATYPEI { get; set; }

    [ForeignKey("NTRATYPEI")]
    public Insudb.TABLE24? TABLE24 { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.TABLE6? TABLE6 { get; set; }
    public long? NTRANSAC { get; set; }
    public int? NMAINYEAR_COMM { get; set; }
    public long? NRECEIPT { get; set; }
    public decimal? NPERCADV_PAY { get; set; }
    public DateTime? DACCRUALDATE { get; set; }
    public decimal? NPREMIUMN_AN { get; set; }
    public decimal? NPREMIUM_AN { get; set; }
    public decimal? NBALANCE { get; set; }
    public string? SIND_DESC { get; set; }
    public string? SIND_BALANCE { get; set; }
    public int NCOD_SALDIS { get; set; }
    public int? NCATEGORY { get; set; }
    public int NID_CAMPAIGN { get; set; }
    public DateTime? DDATEEND_CAMP { get; set; }
}
