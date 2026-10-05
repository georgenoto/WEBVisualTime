#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_WINCLI
{
    public string STYPE_CLIE { get; set; }
    public string STYPE_SEQ { get; set; }
    public int NSEQUENCE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SREQUIRE { get; set; }
    public int? NUSERCODE { get; set; }
}
