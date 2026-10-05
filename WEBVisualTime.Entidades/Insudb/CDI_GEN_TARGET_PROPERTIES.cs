#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_GEN_TARGET_PROPERTIES
{
    public string TARGET_NAME { get; set; }
    public string TYPE { get; set; }
    public string NAME { get; set; }
    public string? VALUE { get; set; }
}
