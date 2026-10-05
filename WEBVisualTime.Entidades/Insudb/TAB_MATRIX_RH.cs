#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_MATRIX_RH
{
    public int NTYPE_MOVE { get; set; }
    public int NORIGIN { get; set; }
    public int NTYP_PROFITWORKER { get; set; }
    public int? NTRANSAC { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
}
