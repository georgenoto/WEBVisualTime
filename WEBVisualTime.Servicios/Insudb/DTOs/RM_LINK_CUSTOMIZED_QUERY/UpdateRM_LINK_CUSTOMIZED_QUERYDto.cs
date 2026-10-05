namespace WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY;

public class UpdateRM_LINK_CUSTOMIZED_QUERYDto
{
    public string QUERY_NAME { get; set; }
    public string QUERY_TEXT { get; set; }
    public string? ALIAS { get; set; }
    public int? NUMBER_OF_PROPERTIES { get; set; }
    public string? FOLDER_CONTEXT { get; set; }
    public string? OBJECT_CONTEXT { get; set; }
}
