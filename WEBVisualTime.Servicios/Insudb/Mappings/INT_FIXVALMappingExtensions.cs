using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INT_FIXVAL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INT_FIXVALMappingExtensions
{
    public static INT_FIXVALDto ToDto(this INT_FIXVAL entity)
    {
        if (entity == null) return null!;
        return new INT_FIXVALDto
        {
            NCODE = entity.NCODE,
            DEFFECDATE = entity.DEFFECDATE,
            SDESCRIPT = entity.SDESCRIPT,
            NAMOUNT = entity.NAMOUNT,
            NRATE = entity.NRATE,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static INT_FIXVAL ToEntity(this CreateINT_FIXVALDto dto)
    {
        if (dto == null) return null!;
        return new INT_FIXVAL
        {
            SDESCRIPT = dto.SDESCRIPT,
            NAMOUNT = dto.NAMOUNT,
            NRATE = dto.NRATE,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this INT_FIXVAL entity, UpdateINT_FIXVALDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NRATE = dto.NRATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
