#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_FORMS
{
    public string? FRM_FNAME { get; set; }
    public int? FRM_SEQ { get; set; }
    public string? FRM_DISP_NAME { get; set; }
    public string? FRM_DESC { get; set; }
}
