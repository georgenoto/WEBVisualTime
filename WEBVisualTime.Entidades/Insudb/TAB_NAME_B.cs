#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_NAME_B
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? STABNAME { get; set; }
    public int? NUSERCODE { get; set; }
}
