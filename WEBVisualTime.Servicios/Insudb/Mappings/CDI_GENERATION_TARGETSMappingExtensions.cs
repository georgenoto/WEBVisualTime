using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GENERATION_TARGETS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_GENERATION_TARGETSMappingExtensions
{
    public static CDI_GENERATION_TARGETSDto ToDto(this CDI_GENERATION_TARGETS entity)
    {
        if (entity == null) return null!;
        return new CDI_GENERATION_TARGETSDto
        {
            NAME = entity.NAME,
            SEQ = entity.SEQ,
            LANGUAGE = entity.LANGUAGE,
            REGISTRY_NAME = entity.REGISTRY_NAME,
            MEMBER_BEGIN_MARKER = entity.MEMBER_BEGIN_MARKER,
            CLOSE_MEMBER_MARKER = entity.CLOSE_MEMBER_MARKER,
            MEMBER_END_MARKER = entity.MEMBER_END_MARKER,
            NLS_LANG = entity.NLS_LANG,
        };
    }

    public static CDI_GENERATION_TARGETS ToEntity(this CreateCDI_GENERATION_TARGETSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_GENERATION_TARGETS
        {
            NAME = dto.NAME,
            SEQ = dto.SEQ,
            LANGUAGE = dto.LANGUAGE,
            REGISTRY_NAME = dto.REGISTRY_NAME,
            MEMBER_BEGIN_MARKER = dto.MEMBER_BEGIN_MARKER,
            CLOSE_MEMBER_MARKER = dto.CLOSE_MEMBER_MARKER,
            MEMBER_END_MARKER = dto.MEMBER_END_MARKER,
            NLS_LANG = dto.NLS_LANG,
        };
    }

    public static void UpdateEntity(this CDI_GENERATION_TARGETS entity, UpdateCDI_GENERATION_TARGETSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAME = dto.NAME;
        entity.SEQ = dto.SEQ;
        entity.LANGUAGE = dto.LANGUAGE;
        entity.REGISTRY_NAME = dto.REGISTRY_NAME;
        entity.MEMBER_BEGIN_MARKER = dto.MEMBER_BEGIN_MARKER;
        entity.CLOSE_MEMBER_MARKER = dto.CLOSE_MEMBER_MARKER;
        entity.MEMBER_END_MARKER = dto.MEMBER_END_MARKER;
        entity.NLS_LANG = dto.NLS_LANG;
    }
}
