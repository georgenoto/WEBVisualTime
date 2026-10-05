#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_SHORT_G
{
    public int NMONTHMAX { get; set; }
    public int NDAYSMAX { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NRATEDEVO { get; set; }
    public decimal? NRATEPREM { get; set; }
    public int? NUSERCODE { get; set; }
}
