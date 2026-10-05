using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_NLS_GLOBAL_NAME_DOMAINS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SDD_NLS_GLOBAL_NAME_DOMAINSMappingExtensions
{
    public static SDD_NLS_GLOBAL_NAME_DOMAINSDto ToDto(this SDD_NLS_GLOBAL_NAME_DOMAINS entity)
    {
        if (entity == null) return null!;
        return new SDD_NLS_GLOBAL_NAME_DOMAINSDto
        {
            IRID = entity.IRID,
            IVID = entity.IVID,
            NLS_NAME = entity.NLS_NAME,
            NLS_PLURAL_NAME = entity.NLS_PLURAL_NAME,
            NLS_LANG = entity.NLS_LANG,
            GND_IRID = entity.GND_IRID,
            SDD_GLOBAL_NAME_DOMAINSNAME = entity.SDD_GLOBAL_NAME_DOMAINS?.NAME,
            NUMBER_OF_TIMES_MODIFIED = entity.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = entity.DATE_CREATED,
            CREATED_BY = entity.CREATED_BY,
            DATE_CHANGED = entity.DATE_CHANGED,
            CHANGED_BY = entity.CHANGED_BY,
        };
    }

    public static SDD_NLS_GLOBAL_NAME_DOMAINS ToEntity(this CreateSDD_NLS_GLOBAL_NAME_DOMAINSDto dto)
    {
        if (dto == null) return null!;
        return new SDD_NLS_GLOBAL_NAME_DOMAINS
        {
            IVID = dto.IVID,
            NLS_NAME = dto.NLS_NAME,
            NLS_PLURAL_NAME = dto.NLS_PLURAL_NAME,
            NLS_LANG = dto.NLS_LANG,
            GND_IRID = dto.GND_IRID,
            NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = dto.DATE_CREATED,
            CREATED_BY = dto.CREATED_BY,
            DATE_CHANGED = dto.DATE_CHANGED,
            CHANGED_BY = dto.CHANGED_BY,
        };
    }

    public static void UpdateEntity(this SDD_NLS_GLOBAL_NAME_DOMAINS entity, UpdateSDD_NLS_GLOBAL_NAME_DOMAINSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.IVID = dto.IVID;
        entity.NLS_NAME = dto.NLS_NAME;
        entity.NLS_PLURAL_NAME = dto.NLS_PLURAL_NAME;
        entity.NLS_LANG = dto.NLS_LANG;
        entity.GND_IRID = dto.GND_IRID;
        entity.NUMBER_OF_TIMES_MODIFIED = dto.NUMBER_OF_TIMES_MODIFIED;
        entity.DATE_CREATED = dto.DATE_CREATED;
        entity.CREATED_BY = dto.CREATED_BY;
        entity.DATE_CHANGED = dto.DATE_CHANGED;
        entity.CHANGED_BY = dto.CHANGED_BY;
    }
}
