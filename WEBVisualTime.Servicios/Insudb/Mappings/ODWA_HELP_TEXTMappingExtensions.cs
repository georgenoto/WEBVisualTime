using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_TEXT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ODWA_HELP_TEXTMappingExtensions
{
    public static ODWA_HELP_TEXTDto ToDto(this ODWA_HELP_TEXT entity)
    {
        if (entity == null) return null!;
        return new ODWA_HELP_TEXTDto
        {
            HIM_ID = entity.HIM_ID,
            ODWA_HELP_ITEMSDESCRIPTION = entity.ODWA_HELP_ITEMS?.DESCRIPTION,
            SEQ = entity.SEQ,
            TXT = entity.TXT,
        };
    }

    public static ODWA_HELP_TEXT ToEntity(this CreateODWA_HELP_TEXTDto dto)
    {
        if (dto == null) return null!;
        return new ODWA_HELP_TEXT
        {
            TXT = dto.TXT,
        };
    }

    public static void UpdateEntity(this ODWA_HELP_TEXT entity, UpdateODWA_HELP_TEXTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.TXT = dto.TXT;
    }
}
