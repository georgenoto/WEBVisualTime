#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BENEFGROUP_DETAIL
{
    public string SBENEFITGROUP { get; set; }
    public string SIDDETAIL { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
