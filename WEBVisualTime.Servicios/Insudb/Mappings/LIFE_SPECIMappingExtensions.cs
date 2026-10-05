using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_SPECI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LIFE_SPECIMappingExtensions
{
    public static LIFE_SPECIDto ToDto(this LIFE_SPECI entity)
    {
        if (entity == null) return null!;
        return new LIFE_SPECIDto
        {
            NAGEEND = entity.NAGEEND,
            NAGESTART = entity.NAGESTART,
            NCAPEND = entity.NCAPEND,
            NCONSEC = entity.NCONSEC,
            NCAPSTART = entity.NCAPSTART,
            NMODULEC = entity.NMODULEC,
            NBRANCH = entity.NBRANCH,
            NCOVER = entity.NCOVER,
            NCURRENCY = entity.NCURRENCY,
            NPRODUCT = entity.NPRODUCT,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NCRTHECNI = entity.NCRTHECNI,
            TABLE32SDESCRIPT = entity.TABLE32?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            SSEXCLIEN = entity.SSEXCLIEN,
            TABLE18SDESCRIPT = entity.TABLE18?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            NROLE = entity.NROLE,
            SRANDOM = entity.SRANDOM,
        };
    }

    public static LIFE_SPECI ToEntity(this CreateLIFE_SPECIDto dto)
    {
        if (dto == null) return null!;
        return new LIFE_SPECI
        {
            NAGEEND = dto.NAGEEND,
            NAGESTART = dto.NAGESTART,
            NCAPEND = dto.NCAPEND,
            NCAPSTART = dto.NCAPSTART,
            NCURRENCY = dto.NCURRENCY,
            DCOMPDATE = dto.DCOMPDATE,
            NCRTHECNI = dto.NCRTHECNI,
            DNULLDATE = dto.DNULLDATE,
            SSEXCLIEN = dto.SSEXCLIEN,
            NUSERCODE = dto.NUSERCODE,
            SRANDOM = dto.SRANDOM,
        };
    }

    public static void UpdateEntity(this LIFE_SPECI entity, UpdateLIFE_SPECIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAGEEND = dto.NAGEEND;
        entity.NAGESTART = dto.NAGESTART;
        entity.NCAPEND = dto.NCAPEND;
        entity.NCAPSTART = dto.NCAPSTART;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCRTHECNI = dto.NCRTHECNI;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SRANDOM = dto.SRANDOM;
    }
}
