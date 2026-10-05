#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class HEALTHCLAIMFORM
{
    public string? CLIENTE { get; set; }
    public long? IDRECLAMACION { get; set; }
    public long? NCASENUM { get; set; }
    public string? FORMULARIO { get; set; }
    public DateTime? FECHACOMPUTADOR { get; set; }
    public string FORMID { get; set; }
    public string MODELID { get; set; }
    public string USERID { get; set; }
    public string? CONTENT { get; set; }
}
