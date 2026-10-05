using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CALEND_INTERFACE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CALEND_INTERFACEMappingExtensions
{
    public static CALEND_INTERFACEDto ToDto(this CALEND_INTERFACE entity)
    {
        if (entity == null) return null!;
        return new CALEND_INTERFACEDto
        {
            NSHEET = entity.NSHEET,
            NID = entity.NID,
            NDAY = entity.NDAY,
            DDATEPROC = entity.DDATEPROC,
            SHOUR = entity.SHOUR,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static CALEND_INTERFACE ToEntity(this CreateCALEND_INTERFACEDto dto)
    {
        if (dto == null) return null!;
        return new CALEND_INTERFACE
        {
            NSHEET = dto.NSHEET,
            NID = dto.NID,
            NDAY = dto.NDAY,
            DDATEPROC = dto.DDATEPROC,
            SHOUR = dto.SHOUR,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this CALEND_INTERFACE entity, UpdateCALEND_INTERFACEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSHEET = dto.NSHEET;
        entity.NID = dto.NID;
        entity.NDAY = dto.NDAY;
        entity.DDATEPROC = dto.DDATEPROC;
        entity.SHOUR = dto.SHOUR;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
