using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_ACTIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WIN_ACTIONSMappingExtensions
{
    public static WIN_ACTIONSDto ToDto(this WIN_ACTIONS entity)
    {
        if (entity == null) return null!;
        return new WIN_ACTIONSDto
        {
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NACTION = entity.NACTION,
            ACTIONSSCONTROLKEY = entity.ACTIONS?.SCONTROLKEY,
            NSEQUENCE = entity.NSEQUENCE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static WIN_ACTIONS ToEntity(this CreateWIN_ACTIONSDto dto)
    {
        if (dto == null) return null!;
        return new WIN_ACTIONS
        {
            NACTION = dto.NACTION,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this WIN_ACTIONS entity, UpdateWIN_ACTIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACTION = dto.NACTION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
