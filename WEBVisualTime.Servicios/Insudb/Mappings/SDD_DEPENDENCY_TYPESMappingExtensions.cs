using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SDD_DEPENDENCY_TYPESMappingExtensions
{
    public static SDD_DEPENDENCY_TYPESDto ToDto(this SDD_DEPENDENCY_TYPES entity)
    {
        if (entity == null) return null!;
        return new SDD_DEPENDENCY_TYPESDto
        {
            IRID = entity.IRID,
            IVID = entity.IVID,
            TYPE = entity.TYPE,
            SYSTEM_FLAG = entity.SYSTEM_FLAG,
            TRANSITIVE = entity.TRANSITIVE,
            NUMBER_OF_TIMES_MODIFIED = entity.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = entity.DATE_CREATED,
            CREATED_BY = entity.CREATED_BY,
            DATE_CHANGED = entity.DATE_CHANGED,
            CHANGED_BY = entity.CHANGED_BY,
            SUBTYPE = entity.SUBTYPE,
        };
    }

    public static SDD_DEPENDENCY_TYPES ToEntity(this CreateSDD_DEPENDENCY_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new SDD_DEPENDENCY_TYPES
        {
            IVID = dto.IVID,
            TYPE = dto.TYPE,
            SYSTEM_FLAG = dto.SYSTEM_FLAG,
            TRANSITIVE = dto.TRANSITIVE,
            NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = dto.DATE_CREATED,
            CREATED_BY = dto.CREATED_BY,
            DATE_CHANGED = dto.DATE_CHANGED,
            CHANGED_BY = dto.CHANGED_BY,
            SUBTYPE = dto.SUBTYPE,
        };
    }

    public static void UpdateEntity(this SDD_DEPENDENCY_TYPES entity, UpdateSDD_DEPENDENCY_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.IVID = dto.IVID;
        entity.TYPE = dto.TYPE;
        entity.SYSTEM_FLAG = dto.SYSTEM_FLAG;
        entity.TRANSITIVE = dto.TRANSITIVE;
        entity.NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED;
        entity.DATE_CREATED = dto.DATE_CREATED;
        entity.CREATED_BY = dto.CREATED_BY;
        entity.DATE_CHANGED = dto.DATE_CHANGED;
        entity.CHANGED_BY = dto.CHANGED_BY;
        entity.SUBTYPE = dto.SUBTYPE;
    }
}
