using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_VALID_PREFS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_VALID_PREFSMappingExtensions
{
    public static CDI_VALID_PREFSDto ToDto(this CDI_VALID_PREFS entity)
    {
        if (entity == null) return null!;
        return new CDI_VALID_PREFSDto
        {
            VP_DOMAIN = entity.VP_DOMAIN,
            VP_VALUE = entity.VP_VALUE,
            VP_MEANING = entity.VP_MEANING,
            VP_ABBREVIATION = entity.VP_ABBREVIATION,
            NLS_LANG = entity.NLS_LANG,
        };
    }

    public static CDI_VALID_PREFS ToEntity(this CreateCDI_VALID_PREFSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_VALID_PREFS
        {
            VP_DOMAIN = dto.VP_DOMAIN,
            VP_VALUE = dto.VP_VALUE,
            VP_MEANING = dto.VP_MEANING,
            VP_ABBREVIATION = dto.VP_ABBREVIATION,
            NLS_LANG = dto.NLS_LANG,
        };
    }

    public static void UpdateEntity(this CDI_VALID_PREFS entity, UpdateCDI_VALID_PREFSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.VP_DOMAIN = dto.VP_DOMAIN;
        entity.VP_VALUE = dto.VP_VALUE;
        entity.VP_MEANING = dto.VP_MEANING;
        entity.VP_ABBREVIATION = dto.VP_ABBREVIATION;
        entity.NLS_LANG = dto.NLS_LANG;
    }
}
