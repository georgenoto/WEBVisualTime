using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_RESERVED_NAMES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SDD_RESERVED_NAMESMappingExtensions
{
    public static SDD_RESERVED_NAMESDto ToDto(this SDD_RESERVED_NAMES entity)
    {
        if (entity == null) return null!;
        return new SDD_RESERVED_NAMESDto
        {
            RN_RES_NAME = entity.RN_RES_NAME,
            RN_TYPE = entity.RN_TYPE,
            RN_COMMENT = entity.RN_COMMENT,
            RN_GLOBAL = entity.RN_GLOBAL,
            RN_TEMPORARY = entity.RN_TEMPORARY,
            RN_ENABLED = entity.RN_ENABLED,
            RN_USR_ACCESS = entity.RN_USR_ACCESS,
            RN_CDAPI = entity.RN_CDAPI,
            RN_OBJECT_IRID = entity.RN_OBJECT_IRID,
            RN_OBJECT_IVID = entity.RN_OBJECT_IVID,
        };
    }

    public static SDD_RESERVED_NAMES ToEntity(this CreateSDD_RESERVED_NAMESDto dto)
    {
        if (dto == null) return null!;
        return new SDD_RESERVED_NAMES
        {
            RN_RES_NAME = dto.RN_RES_NAME,
            RN_TYPE = dto.RN_TYPE,
            RN_COMMENT = dto.RN_COMMENT,
            RN_GLOBAL = dto.RN_GLOBAL,
            RN_TEMPORARY = dto.RN_TEMPORARY,
            RN_ENABLED = dto.RN_ENABLED,
            RN_USR_ACCESS = dto.RN_USR_ACCESS,
            RN_CDAPI = dto.RN_CDAPI,
            RN_OBJECT_IRID = dto.RN_OBJECT_IRID,
            RN_OBJECT_IVID = dto.RN_OBJECT_IVID,
        };
    }

    public static void UpdateEntity(this SDD_RESERVED_NAMES entity, UpdateSDD_RESERVED_NAMESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.RN_RES_NAME = dto.RN_RES_NAME;
        entity.RN_TYPE = dto.RN_TYPE;
        entity.RN_COMMENT = dto.RN_COMMENT;
        entity.RN_GLOBAL = dto.RN_GLOBAL;
        entity.RN_TEMPORARY = dto.RN_TEMPORARY;
        entity.RN_ENABLED = dto.RN_ENABLED;
        entity.RN_USR_ACCESS = dto.RN_USR_ACCESS;
        entity.RN_CDAPI = dto.RN_CDAPI;
        entity.RN_OBJECT_IRID = dto.RN_OBJECT_IRID;
        entity.RN_OBJECT_IVID = dto.RN_OBJECT_IVID;
    }
}
