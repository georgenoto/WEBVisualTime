#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class APPUSER
{
    public long NIDUSER { get; set; }
    public string? SUSERNAME { get; set; }
    public string? SNAME { get; set; }
}
