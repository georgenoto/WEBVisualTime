#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class WIN_FILE_G
{
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NBRANCH_GEN { get; set; }

    [ForeignKey("NBRANCH_GEN")]
    public Insudb.TABLE634? TABLE634 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? STABNAME { get; set; }
    public int? NUSERCODE { get; set; }
}
