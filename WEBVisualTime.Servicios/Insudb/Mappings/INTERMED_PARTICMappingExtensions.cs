using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_PARTIC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INTERMED_PARTICMappingExtensions
{
    public static INTERMED_PARTICDto ToDto(this INTERMED_PARTIC entity)
    {
        if (entity == null) return null!;
        return new INTERMED_PARTICDto
        {
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NSUPERIN_NUM = entity.NSUPERIN_NUM,
            DSUPERIN_NUM = entity.DSUPERIN_NUM,
            NWARRAN_POL = entity.NWARRAN_POL,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NCIRCULAR_DOC = entity.NCIRCULAR_DOC,
            DEXPSUPERIN_NUM = entity.DEXPSUPERIN_NUM,
        };
    }

    public static INTERMED_PARTIC ToEntity(this CreateINTERMED_PARTICDto dto)
    {
        if (dto == null) return null!;
        return new INTERMED_PARTIC
        {
            NSUPERIN_NUM = dto.NSUPERIN_NUM,
            DSUPERIN_NUM = dto.DSUPERIN_NUM,
            NWARRAN_POL = dto.NWARRAN_POL,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NCIRCULAR_DOC = dto.NCIRCULAR_DOC,
            DEXPSUPERIN_NUM = dto.DEXPSUPERIN_NUM,
        };
    }

    public static void UpdateEntity(this INTERMED_PARTIC entity, UpdateINTERMED_PARTICDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSUPERIN_NUM = dto.NSUPERIN_NUM;
        entity.DSUPERIN_NUM = dto.DSUPERIN_NUM;
        entity.NWARRAN_POL = dto.NWARRAN_POL;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCIRCULAR_DOC = dto.NCIRCULAR_DOC;
        entity.DEXPSUPERIN_NUM = dto.DEXPSUPERIN_NUM;
    }
}
