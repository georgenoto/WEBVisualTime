#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class APV_LED_ACC
{
    public int NTYPE_MOVE { get; set; }
    public int NTYP_PROFITWORKER { get; set; }
    public string? SLEDACC { get; set; }
    public string? SDESCLED { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
}
