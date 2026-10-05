#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SCHE_SURR_BRANCH
{
    public string? SSCHE_CODE { get; set; }
    public int? NBRANCH { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SLIFE { get; set; }
}
