#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_DFLT_USER_PREFS
{
    public string P_SNAME { get; set; }
    public string P_CGVERSION { get; set; }
    public string SNAME { get; set; }
    public string NAME { get; set; }
    public string? VALUE { get; set; }
    public string INTERNAL { get; set; }
    public string? TYPE { get; set; }
    public string DESCRIPTION { get; set; }
}
