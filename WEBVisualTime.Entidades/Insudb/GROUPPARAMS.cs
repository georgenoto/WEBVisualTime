#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class GROUPPARAMS
{
    public int NLETT_GROUP { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public string? SPARAMETERS { get; set; }
}
