#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CDI_PRODUCT_FLAVOURS
{
    public string P_SNAME { get; set; }
    public string P_CGVERSION { get; set; }
    public int SEQ { get; set; }
    public string? DESCRIPTION { get; set; }
}
