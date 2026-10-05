#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REP_CLEAR_VTIME
{
    public string? STABLE { get; set; }
    public int? NCOUNT { get; set; }
    public int? NCOUNT_BD { get; set; }
    public int? NCOUNT_DEP { get; set; }
    public int? NERASE { get; set; }
    public int? NDROP { get; set; }
    public string? SCOMMENTS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
}
