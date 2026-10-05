#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class OUT_MOVEME
{
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
    public long NMOVNUMBE { get; set; }
    public int NDIGIT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal? NPREMIUM { get; set; }
    public string? SSTATUS_MOV { get; set; }
    public decimal? NTAXAMOU { get; set; }
    public int? NTRATYPEI { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NYEAR_MONTH { get; set; }
    public int? SZONE { get; set; }
    public int? NPROVINCE { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public int? NINSUR_AREA { get; set; }
    public int NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public int? NORIGI { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NSITUATION { get; set; }
    public string? SCLIENT { get; set; }
    public int? NGROUP { get; set; }
    public long? NMOVNUMBE_REL { get; set; }
    public decimal? NPREMIUMTEC { get; set; }
    public long? NMOVEMENT { get; set; }
}
