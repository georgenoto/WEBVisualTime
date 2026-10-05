#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_WINPOL
{
    public string SBUSSITYP { get; set; }
    public string SPOLITYPE { get; set; }
    public string SCOMPON { get; set; }
    public int NSEQUENCE { get; set; }
    public int NTRATYPEP { get; set; }

    [ForeignKey("NTRATYPEP")]
    public Insudb.TABLE5588? TABLE5588 { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SREQUIRE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SAUTOMATIC { get; set; }
    public int NTYPE_AMEND { get; set; }
    public string SBRANCHT { get; set; }
}
