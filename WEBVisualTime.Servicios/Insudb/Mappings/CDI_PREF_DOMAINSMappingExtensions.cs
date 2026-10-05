using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PREF_DOMAINS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_PREF_DOMAINSMappingExtensions
{
    public static CDI_PREF_DOMAINSDto ToDto(this CDI_PREF_DOMAINS entity)
    {
        if (entity == null) return null!;
        return new CDI_PREF_DOMAINSDto
        {
            PD_DOMAIN = entity.PD_DOMAIN,
            PD_DESC = entity.PD_DESC,
        };
    }

    public static CDI_PREF_DOMAINS ToEntity(this CreateCDI_PREF_DOMAINSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_PREF_DOMAINS
        {
            PD_DOMAIN = dto.PD_DOMAIN,
            PD_DESC = dto.PD_DESC,
        };
    }

    public static void UpdateEntity(this CDI_PREF_DOMAINS entity, UpdateCDI_PREF_DOMAINSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.PD_DOMAIN = dto.PD_DOMAIN;
        entity.PD_DESC = dto.PD_DESC;
    }
}
