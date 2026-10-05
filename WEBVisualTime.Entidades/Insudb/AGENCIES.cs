#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class AGENCIES
{
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE5555? TABLE5555 { get; set; }
    public int NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public int NBRAN_OFF { get; set; }

    [ForeignKey("NBRAN_OFF")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SPAY { get; set; }
}
