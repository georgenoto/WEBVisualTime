#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMISS_PR
{
    public long NRECEIPT { get; set; }

    [ForeignKey("SCERTYPE, NRECEIPT, NBRANCH, NPRODUCT, NDIGIT, NPAYNUMBE")]
    public Insudb.PREMIUM? PREMIUMNRECEIPT { get; set; }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.PREMIUM? PREMIUMNPRODUCT
    {
        get => PREMIUMNRECEIPT;
        set => PREMIUMNRECEIPT = value;
    }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.PREMIUM? PREMIUMNBRANCH
    {
        get => PREMIUMNRECEIPT;
        set => PREMIUMNRECEIPT = value;
    }
    public string SCERTYPE { get; set; }

    [NotMapped]
    public Insudb.PREMIUM? PREMIUMSCERTYPE
    {
        get => PREMIUMNRECEIPT;
        set => PREMIUMNRECEIPT = value;
    }
    public int NDIGIT { get; set; }

    [NotMapped]
    public Insudb.PREMIUM? PREMIUMNDIGIT
    {
        get => PREMIUMNRECEIPT;
        set => PREMIUMNRECEIPT = value;
    }
    public int NPAYNUMBE { get; set; }

    [NotMapped]
    public Insudb.PREMIUM? PREMIUMNPAYNUMBE
    {
        get => PREMIUMNRECEIPT;
        set => PREMIUMNRECEIPT = value;
    }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int? NPROVINCE { get; set; }

    [ForeignKey("NPROVINCE")]
    public Insudb.PROVINCE? PROVINCE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public int? NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NCOM_AFEC { get; set; }
    public decimal? NCOM_EXEN { get; set; }
    public decimal? NDISC_AMOUNT { get; set; }
    public int? NCATEGORY { get; set; }
    public int? NID_CAMPAIGN { get; set; }
}
