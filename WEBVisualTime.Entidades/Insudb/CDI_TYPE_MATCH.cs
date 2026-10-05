#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_TYPE_MATCH
{
    public string TYPE_SHORT_NAME { get; set; }
    public string EL_TYPE_OF { get; set; }
    public string? EL_OCCUR_TYPE { get; set; }
}
