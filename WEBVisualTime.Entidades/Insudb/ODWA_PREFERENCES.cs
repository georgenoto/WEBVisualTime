#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ODWA_PREFERENCES
{
    public string PREFERENCE_NAME { get; set; }
    public string? PREFERENCE_VALUE { get; set; }
    public string? PREFERENCE_DESCRIPTION { get; set; }
}
