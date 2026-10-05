using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_NAV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_NAVMappingExtensions
{
    public static CDI_NAVDto ToDto(this CDI_NAV entity)
    {
        if (entity == null) return null!;
        return new CDI_NAVDto
        {
            NAV_TYPE = entity.NAV_TYPE,
            NAV_FNAME = entity.NAV_FNAME,
            NAV_NAME = entity.NAV_NAME,
            NAV_BTNAME = entity.NAV_BTNAME,
            NAV_CNAME = entity.NAV_CNAME,
            NAV_REF_BTNAME = entity.NAV_REF_BTNAME,
            NAV_REF_CNAME = entity.NAV_REF_CNAME,
            NAV_SEQ = entity.NAV_SEQ,
            NAV_ASSOC_END = entity.NAV_ASSOC_END,
            NAV_DESCRIPTION = entity.NAV_DESCRIPTION,
        };
    }

    public static CDI_NAV ToEntity(this CreateCDI_NAVDto dto)
    {
        if (dto == null) return null!;
        return new CDI_NAV
        {
            NAV_TYPE = dto.NAV_TYPE,
            NAV_FNAME = dto.NAV_FNAME,
            NAV_NAME = dto.NAV_NAME,
            NAV_BTNAME = dto.NAV_BTNAME,
            NAV_CNAME = dto.NAV_CNAME,
            NAV_REF_BTNAME = dto.NAV_REF_BTNAME,
            NAV_REF_CNAME = dto.NAV_REF_CNAME,
            NAV_SEQ = dto.NAV_SEQ,
            NAV_ASSOC_END = dto.NAV_ASSOC_END,
            NAV_DESCRIPTION = dto.NAV_DESCRIPTION,
        };
    }

    public static void UpdateEntity(this CDI_NAV entity, UpdateCDI_NAVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAV_TYPE = dto.NAV_TYPE;
        entity.NAV_FNAME = dto.NAV_FNAME;
        entity.NAV_NAME = dto.NAV_NAME;
        entity.NAV_BTNAME = dto.NAV_BTNAME;
        entity.NAV_CNAME = dto.NAV_CNAME;
        entity.NAV_REF_BTNAME = dto.NAV_REF_BTNAME;
        entity.NAV_REF_CNAME = dto.NAV_REF_CNAME;
        entity.NAV_SEQ = dto.NAV_SEQ;
        entity.NAV_ASSOC_END = dto.NAV_ASSOC_END;
        entity.NAV_DESCRIPTION = dto.NAV_DESCRIPTION;
    }
}
