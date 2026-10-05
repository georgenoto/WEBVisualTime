#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_GENERATION_TARGETS
{
    public string NAME { get; set; }
    public int SEQ { get; set; }
    public string LANGUAGE { get; set; }
    public string REGISTRY_NAME { get; set; }
    public string MEMBER_BEGIN_MARKER { get; set; }
    public string CLOSE_MEMBER_MARKER { get; set; }
    public string MEMBER_END_MARKER { get; set; }
    public string NLS_LANG { get; set; }
}
