using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REINSU_PRIM_HEALTHMappingExtensions
{
    public static REINSU_PRIM_HEALTHDto ToDto(this REINSU_PRIM_HEALTH entity)
    {
        if (entity == null) return null!;
        return new REINSU_PRIM_HEALTHDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            PRODMASTERSDESCRIPT = entity.PRODMASTER?.SDESCRIPT,
            NMODULEC = entity.NMODULEC,
            NCURRENCY = entity.NCURRENCY,
            TABLE11SDESCRIPT = entity.TABLE11?.SDESCRIPT,
            DEEFECDATE = entity.DEEFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NREINPRE = entity.NREINPRE,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREG = entity.SSTATREG,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static REINSU_PRIM_HEALTH ToEntity(this CreateREINSU_PRIM_HEALTHDto dto)
    {
        if (dto == null) return null!;
        return new REINSU_PRIM_HEALTH
        {
            DNULLDATE = dto.DNULLDATE,
            NREINPRE = dto.NREINPRE,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREG = dto.SSTATREG,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this REINSU_PRIM_HEALTH entity, UpdateREINSU_PRIM_HEALTHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NREINPRE = dto.NREINPRE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREG = dto.SSTATREG;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
