#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RM_LINK_CUSTOMIZED_QUERY_BIND
{
    public string QUERY_NAME { get; set; }
    public string BIND_NAME { get; set; }
    public string BIND_PROPERTY_NAME { get; set; }
    public int BIND_SEQUENCE { get; set; }
}
