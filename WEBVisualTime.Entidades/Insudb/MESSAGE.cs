#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MESSAGE
{
    public long NERRORNUM { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SMESSAGED { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
}
