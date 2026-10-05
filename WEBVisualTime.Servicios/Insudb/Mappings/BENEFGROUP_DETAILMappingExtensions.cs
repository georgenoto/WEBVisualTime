using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFGROUP_DETAIL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BENEFGROUP_DETAILMappingExtensions
{
    public static BENEFGROUP_DETAILDto ToDto(this BENEFGROUP_DETAIL entity)
    {
        if (entity == null) return null!;
        return new BENEFGROUP_DETAILDto
        {
            SBENEFITGROUP = entity.SBENEFITGROUP,
            SIDDETAIL = entity.SIDDETAIL,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static BENEFGROUP_DETAIL ToEntity(this CreateBENEFGROUP_DETAILDto dto)
    {
        if (dto == null) return null!;
        return new BENEFGROUP_DETAIL
        {
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this BENEFGROUP_DETAIL entity, UpdateBENEFGROUP_DETAILDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
