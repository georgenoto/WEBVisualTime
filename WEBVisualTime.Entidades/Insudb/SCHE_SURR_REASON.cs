#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SCHE_SURR_REASON
{
    public string? SSCHE_CODE { get; set; }
    public int? NSURR_REASON { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
