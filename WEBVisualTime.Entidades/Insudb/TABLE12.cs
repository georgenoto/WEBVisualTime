#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLE12
{
    public int NROLE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NTABLE9269 { get; set; }

    [ForeignKey("NTABLE9269")]
    public Insudb.TABLE9269? TABLE9269 { get; set; }
}
