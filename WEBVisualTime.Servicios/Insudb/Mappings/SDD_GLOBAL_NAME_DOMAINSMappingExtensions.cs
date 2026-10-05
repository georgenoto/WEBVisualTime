using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SDD_GLOBAL_NAME_DOMAINSMappingExtensions
{
    public static SDD_GLOBAL_NAME_DOMAINSDto ToDto(this SDD_GLOBAL_NAME_DOMAINS entity)
    {
        if (entity == null) return null!;
        return new SDD_GLOBAL_NAME_DOMAINSDto
        {
            IRID = entity.IRID,
            IVID = entity.IVID,
            NAME = entity.NAME,
            SYSTEM_FLAG = entity.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = entity.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = entity.DATE_CREATED,
            CREATED_BY = entity.CREATED_BY,
            DATE_CHANGED = entity.DATE_CHANGED,
            CHANGED_BY = entity.CHANGED_BY,
        };
    }

    public static SDD_GLOBAL_NAME_DOMAINS ToEntity(this CreateSDD_GLOBAL_NAME_DOMAINSDto dto)
    {
        if (dto == null) return null!;
        return new SDD_GLOBAL_NAME_DOMAINS
        {
            IVID = dto.IVID,
            NAME = dto.NAME,
            SYSTEM_FLAG = dto.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = dto.DATE_CREATED,
            CREATED_BY = dto.CREATED_BY,
            DATE_CHANGED = dto.DATE_CHANGED,
            CHANGED_BY = dto.CHANGED_BY,
        };
    }

    public static void UpdateEntity(this SDD_GLOBAL_NAME_DOMAINS entity, UpdateSDD_GLOBAL_NAME_DOMAINSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.IVID = dto.IVID;
        entity.NAME = dto.NAME;
        entity.SYSTEM_FLAG = dto.SYSTEM_FLAG;
        entity.NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED;
        entity.DATE_CREATED = dto.DATE_CREATED;
        entity.CREATED_BY = dto.CREATED_BY;
        entity.DATE_CHANGED = dto.DATE_CHANGED;
        entity.CHANGED_BY = dto.CHANGED_BY;
    }
}
