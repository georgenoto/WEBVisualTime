#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RM_REG_TYPES
{
    public string TABLE_NAME { get; set; }
    public string PRODUCT { get; set; }
    public string NAME { get; set; }
    public string SHORT_NAME { get; set; }
    public string PLURAL_NAME { get; set; }
    public string NLS_NAME { get; set; }
    public string NLS_PLURAL_NAME { get; set; }
    public string? USER_EXTENSION { get; set; }
    public string? HELP_TAG { get; set; }
}
