using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LATEPAYMENTPENALTY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LATEPAYMENTPENALTYMappingExtensions
{
    public static LATEPAYMENTPENALTYDto ToDto(this LATEPAYMENTPENALTY entity)
    {
        if (entity == null) return null!;
        return new LATEPAYMENTPENALTYDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            PRODMASTERSDESCRIPT = entity.PRODMASTER?.SDESCRIPT,
            NDAY_INI = entity.NDAY_INI,
            DEFFECTDATE = entity.DEFFECTDATE,
            NDAY_END = entity.NDAY_END,
            NDAYSPENALTY = entity.NDAYSPENALTY,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static LATEPAYMENTPENALTY ToEntity(this CreateLATEPAYMENTPENALTYDto dto)
    {
        if (dto == null) return null!;
        return new LATEPAYMENTPENALTY
        {
            NDAY_END = dto.NDAY_END,
            NDAYSPENALTY = dto.NDAYSPENALTY,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this LATEPAYMENTPENALTY entity, UpdateLATEPAYMENTPENALTYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NDAY_END = dto.NDAY_END;
        entity.NDAYSPENALTY = dto.NDAYSPENALTY;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
