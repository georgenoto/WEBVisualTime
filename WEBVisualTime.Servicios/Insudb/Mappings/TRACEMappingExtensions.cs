using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TRACEMappingExtensions
{
    public static TRACEDto ToDto(this TRACE entity)
    {
        if (entity == null) return null!;
        return new TRACEDto
        {
            ID = entity.ID,
            PROC = entity.PROC,
            NUSERCODE = entity.NUSERCODE,
            TEXT = entity.TEXT,
        };
    }

    public static TRACE ToEntity(this CreateTRACEDto dto)
    {
        if (dto == null) return null!;
        return new TRACE
        {
            ID = dto.ID,
            PROC = dto.PROC,
            NUSERCODE = dto.NUSERCODE,
            TEXT = dto.TEXT,
        };
    }

    public static void UpdateEntity(this TRACE entity, UpdateTRACEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.ID = dto.ID;
        entity.PROC = dto.PROC;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.TEXT = dto.TEXT;
    }
}
