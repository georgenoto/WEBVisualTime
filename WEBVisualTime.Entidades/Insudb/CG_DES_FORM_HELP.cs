#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CG_DES_FORM_HELP
{
    public string HLP_APPLN { get; set; }
    public string HLP_INDEX { get; set; }
    public string? HLP_MODTAB_NAME { get; set; }
    public string? HLP_GENERATED { get; set; }
    public int HLP_SEQ { get; set; }
    public string? HLP_TEXT { get; set; }
    public string HLP_TYPE { get; set; }
}
