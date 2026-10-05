using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SHORT_G;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_SHORT_GMappingExtensions
{
    public static TAB_SHORT_GDto ToDto(this TAB_SHORT_G entity)
    {
        if (entity == null) return null!;
        return new TAB_SHORT_GDto
        {
            NMONTHMAX = entity.NMONTHMAX,
            NDAYSMAX = entity.NDAYSMAX,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NRATEDEVO = entity.NRATEDEVO,
            NRATEPREM = entity.NRATEPREM,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_SHORT_G ToEntity(this CreateTAB_SHORT_GDto dto)
    {
        if (dto == null) return null!;
        return new TAB_SHORT_G
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NRATEDEVO = dto.NRATEDEVO,
            NRATEPREM = dto.NRATEPREM,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_SHORT_G entity, UpdateTAB_SHORT_GDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRATEDEVO = dto.NRATEDEVO;
        entity.NRATEPREM = dto.NRATEPREM;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
