#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REP_TIMES
{
    public string? SPROCESS_NAME { get; set; }
    public string? SDESC { get; set; }
    public DateTime? DCOMPDATE { get; set; }
}
