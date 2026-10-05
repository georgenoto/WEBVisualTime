#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PACKAGE_TABLE_MAP
{
    public string? OWNER { get; set; }
    public string? PACKAGE_NAME { get; set; }
    public string? TABLE_NAME { get; set; }
}
