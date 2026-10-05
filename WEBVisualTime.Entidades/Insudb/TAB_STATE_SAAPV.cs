#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_STATE_SAAPV
{
    public int NTYPE_SAAPV { get; set; }
    public int NTYPE_STATE_ORIGI { get; set; }
    public int NTYPE_STATE_END { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
}
