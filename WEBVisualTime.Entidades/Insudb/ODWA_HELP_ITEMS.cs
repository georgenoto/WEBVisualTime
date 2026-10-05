#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ODWA_HELP_ITEMS
{
    public int ID { get; set; }
    public string DESCRIPTION { get; set; }
    public string? DOCUMENT { get; set; }
    public string? KEYWORDS { get; set; }
}
