using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIMITS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LIMITSMappingExtensions
{
    public static LIMITSDto ToDto(this LIMITS entity)
    {
        if (entity == null) return null!;
        return new LIMITSDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            NCURRENCY = entity.NCURRENCY,
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NCLAIM_D = entity.NCLAIM_D,
            NPRODUCT = entity.NPRODUCT,
            NCLAIM_P = entity.NCLAIM_P,
            DCOMPDATE = entity.DCOMPDATE,
            NISSUELIM = entity.NISSUELIM,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static LIMITS ToEntity(this CreateLIMITSDto dto)
    {
        if (dto == null) return null!;
        return new LIMITS
        {
            NCLAIM_D = dto.NCLAIM_D,
            NCLAIM_P = dto.NCLAIM_P,
            DCOMPDATE = dto.DCOMPDATE,
            NISSUELIM = dto.NISSUELIM,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this LIMITS entity, UpdateLIMITSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCLAIM_D = dto.NCLAIM_D;
        entity.NCLAIM_P = dto.NCLAIM_P;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NISSUELIM = dto.NISSUELIM;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
