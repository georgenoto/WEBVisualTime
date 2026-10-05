#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REP_ERROR
{
    public string? SPROCESS_NAME { get; set; }
    public int? SSQLCODE { get; set; }
    public string? SSQLERRM { get; set; }
    public string? SDESCRIPTION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NORDER { get; set; }
}
