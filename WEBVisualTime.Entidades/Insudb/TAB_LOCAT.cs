#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_LOCAT
{
    public int NLOCAL { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NPROVINCE { get; set; }

    [ForeignKey("NPROVINCE")]
    public Insudb.PROVINCE? PROVINCE { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SLEGAL_LOC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
