#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLE5633
{
    public int NORIGIN { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTABLE6071 { get; set; }

    [ForeignKey("NTABLE6071")]
    public Insudb.TABLE6071? TABLE6071 { get; set; }
}
