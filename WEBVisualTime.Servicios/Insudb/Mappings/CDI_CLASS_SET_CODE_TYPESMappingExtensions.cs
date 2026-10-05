using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CLASS_SET_CODE_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_CLASS_SET_CODE_TYPESMappingExtensions
{
    public static CDI_CLASS_SET_CODE_TYPESDto ToDto(this CDI_CLASS_SET_CODE_TYPES entity)
    {
        if (entity == null) return null!;
        return new CDI_CLASS_SET_CODE_TYPESDto
        {
            LANGUAGE_NAME = entity.LANGUAGE_NAME,
            TYPE_NAME = entity.TYPE_NAME,
            GENERATE_FLAG = entity.GENERATE_FLAG,
            TEMPLATE_FILE = entity.TEMPLATE_FILE,
            FILE_FILTER = entity.FILE_FILTER,
            SEQ = entity.SEQ,
            DEFAULT_FILE_NAME = entity.DEFAULT_FILE_NAME,
            OPEN_BEGIN_MARKER = entity.OPEN_BEGIN_MARKER,
            CLOSE_BEGIN_MARKER = entity.CLOSE_BEGIN_MARKER,
            OPEN_END_MARKER = entity.OPEN_END_MARKER,
            CLOSE_END_MARKER = entity.CLOSE_END_MARKER,
            FILE_TYPE = entity.FILE_TYPE,
            NLS_LANG = entity.NLS_LANG,
        };
    }

    public static CDI_CLASS_SET_CODE_TYPES ToEntity(this CreateCDI_CLASS_SET_CODE_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new CDI_CLASS_SET_CODE_TYPES
        {
            LANGUAGE_NAME = dto.LANGUAGE_NAME,
            TYPE_NAME = dto.TYPE_NAME,
            GENERATE_FLAG = dto.GENERATE_FLAG,
            TEMPLATE_FILE = dto.TEMPLATE_FILE,
            FILE_FILTER = dto.FILE_FILTER,
            SEQ = dto.SEQ,
            DEFAULT_FILE_NAME = dto.DEFAULT_FILE_NAME,
            OPEN_BEGIN_MARKER = dto.OPEN_BEGIN_MARKER,
            CLOSE_BEGIN_MARKER = dto.CLOSE_BEGIN_MARKER,
            OPEN_END_MARKER = dto.OPEN_END_MARKER,
            CLOSE_END_MARKER = dto.CLOSE_END_MARKER,
            FILE_TYPE = dto.FILE_TYPE,
            NLS_LANG = dto.NLS_LANG,
        };
    }

    public static void UpdateEntity(this CDI_CLASS_SET_CODE_TYPES entity, UpdateCDI_CLASS_SET_CODE_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.LANGUAGE_NAME = dto.LANGUAGE_NAME;
        entity.TYPE_NAME = dto.TYPE_NAME;
        entity.GENERATE_FLAG = dto.GENERATE_FLAG;
        entity.TEMPLATE_FILE = dto.TEMPLATE_FILE;
        entity.FILE_FILTER = dto.FILE_FILTER;
        entity.SEQ = dto.SEQ;
        entity.DEFAULT_FILE_NAME = dto.DEFAULT_FILE_NAME;
        entity.OPEN_BEGIN_MARKER = dto.OPEN_BEGIN_MARKER;
        entity.CLOSE_BEGIN_MARKER = dto.CLOSE_BEGIN_MARKER;
        entity.OPEN_END_MARKER = dto.OPEN_END_MARKER;
        entity.CLOSE_END_MARKER = dto.CLOSE_END_MARKER;
        entity.FILE_TYPE = dto.FILE_TYPE;
        entity.NLS_LANG = dto.NLS_LANG;
    }
}
