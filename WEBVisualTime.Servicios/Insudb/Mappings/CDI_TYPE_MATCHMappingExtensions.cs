using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_TYPE_MATCH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_TYPE_MATCHMappingExtensions
{
    public static CDI_TYPE_MATCHDto ToDto(this CDI_TYPE_MATCH entity)
    {
        if (entity == null) return null!;
        return new CDI_TYPE_MATCHDto
        {
            TYPE_SHORT_NAME = entity.TYPE_SHORT_NAME,
            EL_TYPE_OF = entity.EL_TYPE_OF,
            EL_OCCUR_TYPE = entity.EL_OCCUR_TYPE,
        };
    }

    public static CDI_TYPE_MATCH ToEntity(this CreateCDI_TYPE_MATCHDto dto)
    {
        if (dto == null) return null!;
        return new CDI_TYPE_MATCH
        {
            TYPE_SHORT_NAME = dto.TYPE_SHORT_NAME,
            EL_TYPE_OF = dto.EL_TYPE_OF,
            EL_OCCUR_TYPE = dto.EL_OCCUR_TYPE,
        };
    }

    public static void UpdateEntity(this CDI_TYPE_MATCH entity, UpdateCDI_TYPE_MATCHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.TYPE_SHORT_NAME = dto.TYPE_SHORT_NAME;
        entity.EL_TYPE_OF = dto.EL_TYPE_OF;
        entity.EL_OCCUR_TYPE = dto.EL_OCCUR_TYPE;
    }
}
