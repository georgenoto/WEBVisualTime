#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_CLASS_SET_CODE_TYPES
{
    public string LANGUAGE_NAME { get; set; }
    public string TYPE_NAME { get; set; }
    public string GENERATE_FLAG { get; set; }
    public string TEMPLATE_FILE { get; set; }
    public string? FILE_FILTER { get; set; }
    public int SEQ { get; set; }
    public string DEFAULT_FILE_NAME { get; set; }
    public string OPEN_BEGIN_MARKER { get; set; }
    public string CLOSE_BEGIN_MARKER { get; set; }
    public string OPEN_END_MARKER { get; set; }
    public string CLOSE_END_MARKER { get; set; }
    public string FILE_TYPE { get; set; }
    public string NLS_LANG { get; set; }
}
