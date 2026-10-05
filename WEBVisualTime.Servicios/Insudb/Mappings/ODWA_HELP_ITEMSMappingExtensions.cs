using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ODWA_HELP_ITEMSMappingExtensions
{
    public static ODWA_HELP_ITEMSDto ToDto(this ODWA_HELP_ITEMS entity)
    {
        if (entity == null) return null!;
        return new ODWA_HELP_ITEMSDto
        {
            ID = entity.ID,
            DESCRIPTION = entity.DESCRIPTION,
            DOCUMENT = entity.DOCUMENT,
            KEYWORDS = entity.KEYWORDS,
        };
    }

    public static ODWA_HELP_ITEMS ToEntity(this CreateODWA_HELP_ITEMSDto dto)
    {
        if (dto == null) return null!;
        return new ODWA_HELP_ITEMS
        {
            DESCRIPTION = dto.DESCRIPTION,
            DOCUMENT = dto.DOCUMENT,
            KEYWORDS = dto.KEYWORDS,
        };
    }

    public static void UpdateEntity(this ODWA_HELP_ITEMS entity, UpdateODWA_HELP_ITEMSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DESCRIPTION = dto.DESCRIPTION;
        entity.DOCUMENT = dto.DOCUMENT;
        entity.KEYWORDS = dto.KEYWORDS;
    }
}
