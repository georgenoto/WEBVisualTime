#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_ROUTINE
{
    public string SROUTINE { get; set; }
    public int NROUTINETYPE { get; set; }

    [ForeignKey("NROUTINETYPE")]
    public Insudb.TABLE9105? TABLE9105 { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
