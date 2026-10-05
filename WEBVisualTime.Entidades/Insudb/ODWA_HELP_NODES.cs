#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ODWA_HELP_NODES
{
    public int ID { get; set; }
    public int? PARENT_NODE { get; set; }
    public int SEQ_IN_PARENT { get; set; }
    public int TREE_LEVEL { get; set; }
    public string DISPLAY_LABEL { get; set; }
    public long? HIM_ID { get; set; }
}
