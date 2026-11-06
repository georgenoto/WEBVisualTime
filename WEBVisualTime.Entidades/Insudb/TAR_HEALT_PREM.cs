#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAR_HEALT_PREM
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NBRANCH, NPRODUCT")]
    public Insudb.PRODMASTER? PRODMASTER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NROLE { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NGEOGRAPHAREA { get; set; }

    [ForeignKey("NGEOGRAPHAREA")]
    public Insudb.TABLE9214? TABLE9214 { get; set; }
    public int NATTENSYSTEM { get; set; }

    [ForeignKey("NATTENSYSTEM")]
    public Insudb.TABLE9215? TABLE9215 { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public decimal NCAPITAL_INIT { get; set; }
    public decimal NCAPITAL_END { get; set; }
    public int NPOLICY_YEAR_INIT { get; set; }
    public int NPOLICY_YEAR_END { get; set; }
    public int NCURRENCY { get; set; }
    public int NAGE_INIT { get; set; }
    public int NAGE_END { get; set; }
    public decimal? NAMOUNTF { get; set; }
    public decimal? NAMOUNTM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
