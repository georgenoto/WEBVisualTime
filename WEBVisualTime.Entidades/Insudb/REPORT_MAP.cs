#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REPORT_MAP
{
    public int NORDER { get; set; }
    public long? NCODIG { get; set; }
    public int? NORIGIN { get; set; }
    public int? NTYPE { get; set; }
}
