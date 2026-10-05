#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class WORKSHEET
{
    public int? NBRANCH { get; set; }
    public int NID { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public string? SVALUESLIST { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SDESCRIPT { get; set; }
}
