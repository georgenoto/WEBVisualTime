using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_SQL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TOAD_PLAN_SQLMappingExtensions
{
    public static TOAD_PLAN_SQLDto ToDto(this TOAD_PLAN_SQL entity)
    {
        if (entity == null) return null!;
        return new TOAD_PLAN_SQLDto
        {
            USERNAME = entity.USERNAME,
            STATEMENT_ID = entity.STATEMENT_ID,
            TIMESTAMP = entity.TIMESTAMP,
            STATEMENT = entity.STATEMENT,
        };
    }

    public static TOAD_PLAN_SQL ToEntity(this CreateTOAD_PLAN_SQLDto dto)
    {
        if (dto == null) return null!;
        return new TOAD_PLAN_SQL
        {
            USERNAME = dto.USERNAME,
            STATEMENT_ID = dto.STATEMENT_ID,
            TIMESTAMP = dto.TIMESTAMP,
            STATEMENT = dto.STATEMENT,
        };
    }

    public static void UpdateEntity(this TOAD_PLAN_SQL entity, UpdateTOAD_PLAN_SQLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.USERNAME = dto.USERNAME;
        entity.STATEMENT_ID = dto.STATEMENT_ID;
        entity.TIMESTAMP = dto.TIMESTAMP;
        entity.STATEMENT = dto.STATEMENT;
    }
}
