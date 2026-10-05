using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SDD_DEPEND_STATUSESMappingExtensions
{
    public static SDD_DEPEND_STATUSESDto ToDto(this SDD_DEPEND_STATUSES entity)
    {
        if (entity == null) return null!;
        return new SDD_DEPEND_STATUSESDto
        {
            STATUS = entity.STATUS,
            DESCRIPTION = entity.DESCRIPTION,
            SYSTEM_FLAG = entity.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = entity.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = entity.DATE_CREATED,
            CREATED_BY = entity.CREATED_BY,
            DATE_CHANGED = entity.DATE_CHANGED,
            CHANGED_BY = entity.CHANGED_BY,
        };
    }

    public static SDD_DEPEND_STATUSES ToEntity(this CreateSDD_DEPEND_STATUSESDto dto)
    {
        if (dto == null) return null!;
        return new SDD_DEPEND_STATUSES
        {
            DESCRIPTION = dto.DESCRIPTION,
            SYSTEM_FLAG = dto.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = dto.DATE_CREATED,
            CREATED_BY = dto.CREATED_BY,
            DATE_CHANGED = dto.DATE_CHANGED,
            CHANGED_BY = dto.CHANGED_BY,
        };
    }

    public static void UpdateEntity(this SDD_DEPEND_STATUSES entity, UpdateSDD_DEPEND_STATUSESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DESCRIPTION = dto.DESCRIPTION;
        entity.SYSTEM_FLAG = dto.SYSTEM_FLAG;
        entity.NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED;
        entity.DATE_CREATED = dto.DATE_CREATED;
        entity.CREATED_BY = dto.CREATED_BY;
        entity.DATE_CHANGED = dto.DATE_CHANGED;
        entity.CHANGED_BY = dto.CHANGED_BY;
    }
}
