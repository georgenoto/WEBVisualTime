#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TRACE
{
    public long ID { get; set; }
    public string? PROC { get; set; }
    public int? NUSERCODE { get; set; }
    public string? TEXT { get; set; }
}
