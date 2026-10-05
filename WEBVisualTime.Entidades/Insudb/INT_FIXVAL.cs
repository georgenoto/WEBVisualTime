#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class INT_FIXVAL
{
    public int NCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NRATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
