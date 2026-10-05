#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class STATUS_CLAIM
{
    public int NIDSTATUSCLAIM { get; set; }
    public string? SNAME { get; set; }
    public string? SENABLE { get; set; }
}
