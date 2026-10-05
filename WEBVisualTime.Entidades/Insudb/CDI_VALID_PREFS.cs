#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_VALID_PREFS
{
    public string VP_DOMAIN { get; set; }
    public string VP_VALUE { get; set; }
    public string? VP_MEANING { get; set; }
    public string? VP_ABBREVIATION { get; set; }
    public string NLS_LANG { get; set; }
}
