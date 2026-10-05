using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GEN_TARGET_PROPERTIES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_GEN_TARGET_PROPERTIESMappingExtensions
{
    public static CDI_GEN_TARGET_PROPERTIESDto ToDto(this CDI_GEN_TARGET_PROPERTIES entity)
    {
        if (entity == null) return null!;
        return new CDI_GEN_TARGET_PROPERTIESDto
        {
            TARGET_NAME = entity.TARGET_NAME,
            TYPE = entity.TYPE,
            NAME = entity.NAME,
            VALUE = entity.VALUE,
        };
    }

    public static CDI_GEN_TARGET_PROPERTIES ToEntity(this CreateCDI_GEN_TARGET_PROPERTIESDto dto)
    {
        if (dto == null) return null!;
        return new CDI_GEN_TARGET_PROPERTIES
        {
            TARGET_NAME = dto.TARGET_NAME,
            TYPE = dto.TYPE,
            NAME = dto.NAME,
            VALUE = dto.VALUE,
        };
    }

    public static void UpdateEntity(this CDI_GEN_TARGET_PROPERTIES entity, UpdateCDI_GEN_TARGET_PROPERTIESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.TARGET_NAME = dto.TARGET_NAME;
        entity.TYPE = dto.TYPE;
        entity.NAME = dto.NAME;
        entity.VALUE = dto.VALUE;
    }
}
