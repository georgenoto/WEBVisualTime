using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class STATUS_CLAIMMappingExtensions
{
    public static STATUS_CLAIMDto ToDto(this STATUS_CLAIM entity)
    {
        if (entity == null) return null!;
        return new STATUS_CLAIMDto
        {
            NIDSTATUSCLAIM = entity.NIDSTATUSCLAIM,
            SNAME = entity.SNAME,
            SENABLE = entity.SENABLE,
        };
    }

    public static STATUS_CLAIM ToEntity(this CreateSTATUS_CLAIMDto dto)
    {
        if (dto == null) return null!;
        return new STATUS_CLAIM
        {
            SNAME = dto.SNAME,
            SENABLE = dto.SENABLE,
        };
    }

    public static void UpdateEntity(this STATUS_CLAIM entity, UpdateSTATUS_CLAIMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.SENABLE = dto.SENABLE;
    }
}
