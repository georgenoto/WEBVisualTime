using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY_BIND;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RM_LINK_CUSTOMIZED_QUERY_BINDMappingExtensions
{
    public static RM_LINK_CUSTOMIZED_QUERY_BINDDto ToDto(this RM_LINK_CUSTOMIZED_QUERY_BIND entity)
    {
        if (entity == null) return null!;
        return new RM_LINK_CUSTOMIZED_QUERY_BINDDto
        {
            QUERY_NAME = entity.QUERY_NAME,
            BIND_NAME = entity.BIND_NAME,
            BIND_PROPERTY_NAME = entity.BIND_PROPERTY_NAME,
            BIND_SEQUENCE = entity.BIND_SEQUENCE,
        };
    }

    public static RM_LINK_CUSTOMIZED_QUERY_BIND ToEntity(this CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto dto)
    {
        if (dto == null) return null!;
        return new RM_LINK_CUSTOMIZED_QUERY_BIND
        {
            QUERY_NAME = dto.QUERY_NAME,
            BIND_NAME = dto.BIND_NAME,
            BIND_PROPERTY_NAME = dto.BIND_PROPERTY_NAME,
            BIND_SEQUENCE = dto.BIND_SEQUENCE,
        };
    }

    public static void UpdateEntity(this RM_LINK_CUSTOMIZED_QUERY_BIND entity, UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.QUERY_NAME = dto.QUERY_NAME;
        entity.BIND_NAME = dto.BIND_NAME;
        entity.BIND_PROPERTY_NAME = dto.BIND_PROPERTY_NAME;
        entity.BIND_SEQUENCE = dto.BIND_SEQUENCE;
    }
}
