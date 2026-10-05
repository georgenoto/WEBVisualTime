namespace WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;

public class ODWA_HELP_NODESDto
{
    public int ID { get; set; }
    public int? PARENT_NODE { get; set; }
    public int SEQ_IN_PARENT { get; set; }
    public int TREE_LEVEL { get; set; }
    public string DISPLAY_LABEL { get; set; }
    public long? HIM_ID { get; set; }
}
