using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_AM_ILLMappingExtensions
{
    public static TAB_AM_ILLDto ToDto(this TAB_AM_ILL entity)
    {
        if (entity == null) return null!;
        return new TAB_AM_ILLDto
        {
            SILLNESS = entity.SILLNESS,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SILL_OMS = entity.SILL_OMS,
            TABLE8602SDESCRIPT = entity.TABLE8602?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SIND_SEVERITY = entity.SIND_SEVERITY,
            SIND_FRECUENCY = entity.SIND_FRECUENCY,
        };
    }

    public static TAB_AM_ILL ToEntity(this CreateTAB_AM_ILLDto dto)
    {
        if (dto == null) return null!;
        return new TAB_AM_ILL
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SILL_OMS = dto.SILL_OMS,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SIND_SEVERITY = dto.SIND_SEVERITY,
            SIND_FRECUENCY = dto.SIND_FRECUENCY,
        };
    }

    public static void UpdateEntity(this TAB_AM_ILL entity, UpdateTAB_AM_ILLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SILL_OMS = dto.SILL_OMS;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SIND_SEVERITY = dto.SIND_SEVERITY;
        entity.SIND_FRECUENCY = dto.SIND_FRECUENCY;
    }
}
