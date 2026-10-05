using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_HOUR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WIN_HOURMappingExtensions
{
    public static WIN_HOURDto ToDto(this WIN_HOUR entity)
    {
        if (entity == null) return null!;
        return new WIN_HOURDto
        {
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            SHOUR_START = entity.SHOUR_START,
            SHOUR_END = entity.SHOUR_END,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static WIN_HOUR ToEntity(this CreateWIN_HOURDto dto)
    {
        if (dto == null) return null!;
        return new WIN_HOUR
        {
            SHOUR_END = dto.SHOUR_END,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this WIN_HOUR entity, UpdateWIN_HOURDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SHOUR_END = dto.SHOUR_END;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
