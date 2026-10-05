using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_BRANCH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_SURR_BRANCHMappingExtensions
{
    public static SCHE_SURR_BRANCHDto ToDto(this SCHE_SURR_BRANCH entity)
    {
        if (entity == null) return null!;
        return new SCHE_SURR_BRANCHDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NBRANCH = entity.NBRANCH,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SLIFE = entity.SLIFE,
        };
    }

    public static SCHE_SURR_BRANCH ToEntity(this CreateSCHE_SURR_BRANCHDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_SURR_BRANCH
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            NBRANCH = dto.NBRANCH,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SLIFE = dto.SLIFE,
        };
    }

    public static void UpdateEntity(this SCHE_SURR_BRANCH entity, UpdateSCHE_SURR_BRANCHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.NBRANCH = dto.NBRANCH;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SLIFE = dto.SLIFE;
    }
}
