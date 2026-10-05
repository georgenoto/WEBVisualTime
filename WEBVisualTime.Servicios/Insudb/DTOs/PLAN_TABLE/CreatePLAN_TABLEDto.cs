namespace WEBVisualTime.Servicios.Insudb.DTOs.PLAN_TABLE;

public class CreatePLAN_TABLEDto
{
    public string? STATEMENT_ID { get; set; }
    public DateTime? TIMESTAMP { get; set; }
    public string? REMARKS { get; set; }
    public string? OPERATION { get; set; }
    public string? OPTIONS { get; set; }
    public string? OBJECT_NODE { get; set; }
    public string? OBJECT_OWNER { get; set; }
    public string? OBJECT_NAME { get; set; }
    public int? OBJECT_INSTANCE { get; set; }
    public string? OBJECT_TYPE { get; set; }
    public string? OPTIMIZER { get; set; }
    public int? SEARCH_COLUMNS { get; set; }
    public int ID { get; set; }
    public int? PARENT_ID { get; set; }
    public int? POSITION { get; set; }
    public int? COST { get; set; }
    public int? CARDINALITY { get; set; }
    public int? BYTES { get; set; }
    public string? OTHER_TAG { get; set; }
    public string? PARTITION_START { get; set; }
    public string? PARTITION_STOP { get; set; }
    public int? PARTITION_ID { get; set; }
    public string? OTHER { get; set; }
    public string? DISTRIBUTION { get; set; }
}
