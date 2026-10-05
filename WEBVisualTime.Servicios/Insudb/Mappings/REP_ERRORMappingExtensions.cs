using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_ERROR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REP_ERRORMappingExtensions
{
    public static REP_ERRORDto ToDto(this REP_ERROR entity)
    {
        if (entity == null) return null!;
        return new REP_ERRORDto
        {
            SPROCESS_NAME = entity.SPROCESS_NAME,
            SSQLCODE = entity.SSQLCODE,
            SSQLERRM = entity.SSQLERRM,
            SDESCRIPTION = entity.SDESCRIPTION,
            DCOMPDATE = entity.DCOMPDATE,
            NORDER = entity.NORDER,
        };
    }

    public static REP_ERROR ToEntity(this CreateREP_ERRORDto dto)
    {
        if (dto == null) return null!;
        return new REP_ERROR
        {
            SPROCESS_NAME = dto.SPROCESS_NAME,
            SSQLCODE = dto.SSQLCODE,
            SSQLERRM = dto.SSQLERRM,
            SDESCRIPTION = dto.SDESCRIPTION,
            DCOMPDATE = dto.DCOMPDATE,
            NORDER = dto.NORDER,
        };
    }

    public static void UpdateEntity(this REP_ERROR entity, UpdateREP_ERRORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPROCESS_NAME = dto.SPROCESS_NAME;
        entity.SSQLCODE = dto.SSQLCODE;
        entity.SSQLERRM = dto.SSQLERRM;
        entity.SDESCRIPTION = dto.SDESCRIPTION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NORDER = dto.NORDER;
    }
}
