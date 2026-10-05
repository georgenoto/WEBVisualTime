#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REJECTCAUSE_PRECLAIM
{
    public long NIDPRECLAIM { get; set; }

    [ForeignKey("NIDPRECLAIM")]
    public Insudb.PRECLAIM? PRECLAIM { get; set; }
    public int NREJECT_CAUSE { get; set; }

    [ForeignKey("NREJECT_CAUSE")]
    public Insudb.TABLE9239? TABLE9239 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SMESSAGE_REJECT { get; set; }
}
