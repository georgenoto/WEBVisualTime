using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NULL_CONDI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NULL_CONDIMappingExtensions
{
    public static NULL_CONDIDto ToDto(this NULL_CONDI entity)
    {
        if (entity == null) return null!;
        return new NULL_CONDIDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NNULLCODE = entity.NNULLCODE,
            TABLE13SDESCRIPT = entity.TABLE13?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NAMELEVEL = entity.NAMELEVEL,
            DCOMPDATE = entity.DCOMPDATE,
            SREGTYPEN = entity.SREGTYPEN,
            SRETURN_IND = entity.SRETURN_IND,
            NRETURN_RAT = entity.NRETURN_RAT,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DNULLDATE = entity.DNULLDATE,
            SNOTREHAB = entity.SNOTREHAB,
            SREHAB_AUTO = entity.SREHAB_AUTO,
            SROUTINE_PAY = entity.SROUTINE_PAY,
            NRETRACTION = entity.NRETRACTION,
        };
    }

    public static NULL_CONDI ToEntity(this CreateNULL_CONDIDto dto)
    {
        if (dto == null) return null!;
        return new NULL_CONDI
        {
            NAMELEVEL = dto.NAMELEVEL,
            DCOMPDATE = dto.DCOMPDATE,
            SREGTYPEN = dto.SREGTYPEN,
            SRETURN_IND = dto.SRETURN_IND,
            NRETURN_RAT = dto.NRETURN_RAT,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
            SNOTREHAB = dto.SNOTREHAB,
            SREHAB_AUTO = dto.SREHAB_AUTO,
            SROUTINE_PAY = dto.SROUTINE_PAY,
            NRETRACTION = dto.NRETRACTION,
        };
    }

    public static void UpdateEntity(this NULL_CONDI entity, UpdateNULL_CONDIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMELEVEL = dto.NAMELEVEL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SREGTYPEN = dto.SREGTYPEN;
        entity.SRETURN_IND = dto.SRETURN_IND;
        entity.NRETURN_RAT = dto.NRETURN_RAT;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SNOTREHAB = dto.SNOTREHAB;
        entity.SREHAB_AUTO = dto.SREHAB_AUTO;
        entity.SROUTINE_PAY = dto.SROUTINE_PAY;
        entity.NRETRACTION = dto.NRETRACTION;
    }
}
