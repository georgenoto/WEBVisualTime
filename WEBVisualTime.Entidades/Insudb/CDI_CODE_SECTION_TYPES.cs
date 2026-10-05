#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_CODE_SECTION_TYPES
{
    public string LANGUAGE_NAME { get; set; }
    public string TYPE_NAME { get; set; }
    public string GEN_TEMPLATE_FILE { get; set; }
    public string REGEN_TEMPLATE_FILE { get; set; }
    public string OPEN_BEGIN_MARKER { get; set; }
    public string? CLOSE_BEGIN_MARKER { get; set; }
    public string END_MARKER { get; set; }
    public string FILE_FILTER { get; set; }
    public int SEQ { get; set; }
    public string REGISTRY_NAME { get; set; }
    public string DEFAULT_FILE_NAME { get; set; }
    public string CLOSE_END_MARKER { get; set; }
    public string SECTION_TYPE { get; set; }
    public string FILE_TYPE { get; set; }
    public string NLS_LANG { get; set; }
}
