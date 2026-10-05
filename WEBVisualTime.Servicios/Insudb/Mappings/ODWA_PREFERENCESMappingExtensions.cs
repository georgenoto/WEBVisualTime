using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ODWA_PREFERENCESMappingExtensions
{
    public static ODWA_PREFERENCESDto ToDto(this ODWA_PREFERENCES entity)
    {
        if (entity == null) return null!;
        return new ODWA_PREFERENCESDto
        {
            PREFERENCE_NAME = entity.PREFERENCE_NAME,
            PREFERENCE_VALUE = entity.PREFERENCE_VALUE,
            PREFERENCE_DESCRIPTION = entity.PREFERENCE_DESCRIPTION,
        };
    }

    public static ODWA_PREFERENCES ToEntity(this CreateODWA_PREFERENCESDto dto)
    {
        if (dto == null) return null!;
        return new ODWA_PREFERENCES
        {
            PREFERENCE_VALUE = dto.PREFERENCE_VALUE,
            PREFERENCE_DESCRIPTION = dto.PREFERENCE_DESCRIPTION,
        };
    }

    public static void UpdateEntity(this ODWA_PREFERENCES entity, UpdateODWA_PREFERENCESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.PREFERENCE_VALUE = dto.PREFERENCE_VALUE;
        entity.PREFERENCE_DESCRIPTION = dto.PREFERENCE_DESCRIPTION;
    }
}
