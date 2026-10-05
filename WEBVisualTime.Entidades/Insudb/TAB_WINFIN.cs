#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_WINFIN
{
    public int NTRATYPEC { get; set; }
    public int NSEQUENCE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SREQUIRE { get; set; }
    public int NUSERCODE { get; set; }
}
