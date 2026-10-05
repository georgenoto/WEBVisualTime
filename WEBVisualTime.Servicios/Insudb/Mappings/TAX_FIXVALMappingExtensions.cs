using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAX_FIXVAL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAX_FIXVALMappingExtensions
{
    public static TAX_FIXVALDto ToDto(this TAX_FIXVAL entity)
    {
        if (entity == null) return null!;
        return new TAX_FIXVALDto
        {
            NCODE = entity.NCODE,
            STYPETAX = entity.STYPETAX,
            TABLE5602SDESCRIPT = entity.TABLE5602?.SDESCRIPT,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NPERCENT = entity.NPERCENT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DNULLDATE = entity.DNULLDATE,
            SDESCRIPT = entity.SDESCRIPT,
            NBRANCH = entity.NBRANCH,
            NCURRENCY = entity.NCURRENCY,
            NAMOUNT = entity.NAMOUNT,
        };
    }

    public static TAX_FIXVAL ToEntity(this CreateTAX_FIXVALDto dto)
    {
        if (dto == null) return null!;
        return new TAX_FIXVAL
        {
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NPERCENT = dto.NPERCENT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
            SDESCRIPT = dto.SDESCRIPT,
            NBRANCH = dto.NBRANCH,
            NCURRENCY = dto.NCURRENCY,
            NAMOUNT = dto.NAMOUNT,
        };
    }

    public static void UpdateEntity(this TAX_FIXVAL entity, UpdateTAX_FIXVALDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NPERCENT = dto.NPERCENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAMOUNT = dto.NAMOUNT;
    }
}
