using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_TIMES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REP_TIMESMappingExtensions
{
    public static REP_TIMESDto ToDto(this REP_TIMES entity)
    {
        if (entity == null) return null!;
        return new REP_TIMESDto
        {
            SPROCESS_NAME = entity.SPROCESS_NAME,
            SDESC = entity.SDESC,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static REP_TIMES ToEntity(this CreateREP_TIMESDto dto)
    {
        if (dto == null) return null!;
        return new REP_TIMES
        {
            SPROCESS_NAME = dto.SPROCESS_NAME,
            SDESC = dto.SDESC,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this REP_TIMES entity, UpdateREP_TIMESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPROCESS_NAME = dto.SPROCESS_NAME;
        entity.SDESC = dto.SDESC;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
