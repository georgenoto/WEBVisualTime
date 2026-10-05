using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CODE_SECTION_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_CODE_SECTION_TYPESMappingExtensions
{
    public static CDI_CODE_SECTION_TYPESDto ToDto(this CDI_CODE_SECTION_TYPES entity)
    {
        if (entity == null) return null!;
        return new CDI_CODE_SECTION_TYPESDto
        {
            LANGUAGE_NAME = entity.LANGUAGE_NAME,
            TYPE_NAME = entity.TYPE_NAME,
            GEN_TEMPLATE_FILE = entity.GEN_TEMPLATE_FILE,
            REGEN_TEMPLATE_FILE = entity.REGEN_TEMPLATE_FILE,
            OPEN_BEGIN_MARKER = entity.OPEN_BEGIN_MARKER,
            CLOSE_BEGIN_MARKER = entity.CLOSE_BEGIN_MARKER,
            END_MARKER = entity.END_MARKER,
            FILE_FILTER = entity.FILE_FILTER,
            SEQ = entity.SEQ,
            REGISTRY_NAME = entity.REGISTRY_NAME,
            DEFAULT_FILE_NAME = entity.DEFAULT_FILE_NAME,
            CLOSE_END_MARKER = entity.CLOSE_END_MARKER,
            SECTION_TYPE = entity.SECTION_TYPE,
            FILE_TYPE = entity.FILE_TYPE,
            NLS_LANG = entity.NLS_LANG,
        };
    }

    public static CDI_CODE_SECTION_TYPES ToEntity(this CreateCDI_CODE_SECTION_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new CDI_CODE_SECTION_TYPES
        {
            LANGUAGE_NAME = dto.LANGUAGE_NAME,
            TYPE_NAME = dto.TYPE_NAME,
            GEN_TEMPLATE_FILE = dto.GEN_TEMPLATE_FILE,
            REGEN_TEMPLATE_FILE = dto.REGEN_TEMPLATE_FILE,
            OPEN_BEGIN_MARKER = dto.OPEN_BEGIN_MARKER,
            CLOSE_BEGIN_MARKER = dto.CLOSE_BEGIN_MARKER,
            END_MARKER = dto.END_MARKER,
            FILE_FILTER = dto.FILE_FILTER,
            SEQ = dto.SEQ,
            REGISTRY_NAME = dto.REGISTRY_NAME,
            DEFAULT_FILE_NAME = dto.DEFAULT_FILE_NAME,
            CLOSE_END_MARKER = dto.CLOSE_END_MARKER,
            SECTION_TYPE = dto.SECTION_TYPE,
            FILE_TYPE = dto.FILE_TYPE,
            NLS_LANG = dto.NLS_LANG,
        };
    }

    public static void UpdateEntity(this CDI_CODE_SECTION_TYPES entity, UpdateCDI_CODE_SECTION_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.LANGUAGE_NAME = dto.LANGUAGE_NAME;
        entity.TYPE_NAME = dto.TYPE_NAME;
        entity.GEN_TEMPLATE_FILE = dto.GEN_TEMPLATE_FILE;
        entity.REGEN_TEMPLATE_FILE = dto.REGEN_TEMPLATE_FILE;
        entity.OPEN_BEGIN_MARKER = dto.OPEN_BEGIN_MARKER;
        entity.CLOSE_BEGIN_MARKER = dto.CLOSE_BEGIN_MARKER;
        entity.END_MARKER = dto.END_MARKER;
        entity.FILE_FILTER = dto.FILE_FILTER;
        entity.SEQ = dto.SEQ;
        entity.REGISTRY_NAME = dto.REGISTRY_NAME;
        entity.DEFAULT_FILE_NAME = dto.DEFAULT_FILE_NAME;
        entity.CLOSE_END_MARKER = dto.CLOSE_END_MARKER;
        entity.SECTION_TYPE = dto.SECTION_TYPE;
        entity.FILE_TYPE = dto.FILE_TYPE;
        entity.NLS_LANG = dto.NLS_LANG;
    }
}
