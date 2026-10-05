#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_NAV
{
    public string? NAV_TYPE { get; set; }
    public string? NAV_FNAME { get; set; }
    public string? NAV_NAME { get; set; }
    public string? NAV_BTNAME { get; set; }
    public string? NAV_CNAME { get; set; }
    public string? NAV_REF_BTNAME { get; set; }
    public string? NAV_REF_CNAME { get; set; }
    public int? NAV_SEQ { get; set; }
    public string? NAV_ASSOC_END { get; set; }
    public string? NAV_DESCRIPTION { get; set; }
}
