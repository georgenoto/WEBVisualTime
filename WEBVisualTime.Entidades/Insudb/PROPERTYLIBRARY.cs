#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PROPERTYLIBRARY
{
    public int NIDPROPERTY { get; set; }
    public string SPROPERTY { get; set; }
    public string? SFORMAT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
