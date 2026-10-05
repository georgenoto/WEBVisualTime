#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ODWA_HELP_TEXT
{
    public long HIM_ID { get; set; }

    [ForeignKey("HIM_ID")]
    public Insudb.ODWA_HELP_ITEMS? ODWA_HELP_ITEMS { get; set; }
    public int SEQ { get; set; }
    public string? TXT { get; set; }
}
