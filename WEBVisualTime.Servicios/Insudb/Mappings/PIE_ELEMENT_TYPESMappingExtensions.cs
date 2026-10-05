using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PIE_ELEMENT_TYPESMappingExtensions
{
    public static PIE_ELEMENT_TYPESDto ToDto(this PIE_ELEMENT_TYPES entity)
    {
        if (entity == null) return null!;
        return new PIE_ELEMENT_TYPESDto
        {
            DISPLAY_NAME = entity.DISPLAY_NAME,
            NAME = entity.NAME,
            RM_ID = entity.RM_ID,
            PLURAL = entity.PLURAL,
            GIF_FILE = entity.GIF_FILE,
            ROOT_PROCEDURE = entity.ROOT_PROCEDURE,
            SHORT_NAME = entity.SHORT_NAME,
            DETAIL_PROCEDURE = entity.DETAIL_PROCEDURE,
            DISPLAY_SEQUENCE = entity.DISPLAY_SEQUENCE,
        };
    }

    public static PIE_ELEMENT_TYPES ToEntity(this CreatePIE_ELEMENT_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new PIE_ELEMENT_TYPES
        {
            DISPLAY_NAME = dto.DISPLAY_NAME,
            NAME = dto.NAME,
            RM_ID = dto.RM_ID,
            PLURAL = dto.PLURAL,
            GIF_FILE = dto.GIF_FILE,
            ROOT_PROCEDURE = dto.ROOT_PROCEDURE,
            DETAIL_PROCEDURE = dto.DETAIL_PROCEDURE,
            DISPLAY_SEQUENCE = dto.DISPLAY_SEQUENCE,
        };
    }

    public static void UpdateEntity(this PIE_ELEMENT_TYPES entity, UpdatePIE_ELEMENT_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DISPLAY_NAME = dto.DISPLAY_NAME;
        entity.NAME = dto.NAME;
        entity.RM_ID = dto.RM_ID;
        entity.PLURAL = dto.PLURAL;
        entity.GIF_FILE = dto.GIF_FILE;
        entity.ROOT_PROCEDURE = dto.ROOT_PROCEDURE;
        entity.DETAIL_PROCEDURE = dto.DETAIL_PROCEDURE;
        entity.DISPLAY_SEQUENCE = dto.DISPLAY_SEQUENCE;
    }
}
