#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_WINPRO
{
    public string SBRANCHT { get; set; }

    [ForeignKey("SBRANCHT")]
    public Insudb.TABLE37? TABLE37 { get; set; }
    public int NSEQUENCE { get; set; }
    public string? SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SREQUIRE { get; set; }
    public int? NUSERCODE { get; set; }
}
