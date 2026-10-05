using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RM_LINK_CUSTOMIZED_QUERYMappingExtensions
{
    public static RM_LINK_CUSTOMIZED_QUERYDto ToDto(this RM_LINK_CUSTOMIZED_QUERY entity)
    {
        if (entity == null) return null!;
        return new RM_LINK_CUSTOMIZED_QUERYDto
        {
            QUERY_NAME = entity.QUERY_NAME,
            QUERY_TEXT = entity.QUERY_TEXT,
            ALIAS = entity.ALIAS,
            NUMBER_OF_PROPERTIES = entity.NUMBER_OF_PROPERTIES,
            FOLDER_CONTEXT = entity.FOLDER_CONTEXT,
            OBJECT_CONTEXT = entity.OBJECT_CONTEXT,
        };
    }

    public static RM_LINK_CUSTOMIZED_QUERY ToEntity(this CreateRM_LINK_CUSTOMIZED_QUERYDto dto)
    {
        if (dto == null) return null!;
        return new RM_LINK_CUSTOMIZED_QUERY
        {
            QUERY_NAME = dto.QUERY_NAME,
            QUERY_TEXT = dto.QUERY_TEXT,
            ALIAS = dto.ALIAS,
            NUMBER_OF_PROPERTIES = dto.NUMBER_OF_PROPERTIES,
            FOLDER_CONTEXT = dto.FOLDER_CONTEXT,
            OBJECT_CONTEXT = dto.OBJECT_CONTEXT,
        };
    }

    public static void UpdateEntity(this RM_LINK_CUSTOMIZED_QUERY entity, UpdateRM_LINK_CUSTOMIZED_QUERYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.QUERY_NAME = dto.QUERY_NAME;
        entity.QUERY_TEXT = dto.QUERY_TEXT;
        entity.ALIAS = dto.ALIAS;
        entity.NUMBER_OF_PROPERTIES = dto.NUMBER_OF_PROPERTIES;
        entity.FOLDER_CONTEXT = dto.FOLDER_CONTEXT;
        entity.OBJECT_CONTEXT = dto.OBJECT_CONTEXT;
    }
}
