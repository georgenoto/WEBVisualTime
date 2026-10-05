#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_BILL_I
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NBILL_ITEM { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SSHORT_DES { get; set; }
    public int? NUSERCODE { get; set; }
}
