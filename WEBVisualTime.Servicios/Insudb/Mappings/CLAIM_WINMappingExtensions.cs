using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_WIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_WINMappingExtensions
{
    public static CLAIM_WINDto ToDto(this CLAIM_WIN entity)
    {
        if (entity == null) return null!;
        return new CLAIM_WINDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SV_CONCLAIM = entity.SV_CONCLAIM,
            SV_WINCLAIM = entity.SV_WINCLAIM,
        };
    }

    public static CLAIM_WIN ToEntity(this CreateCLAIM_WINDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_WIN
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONCLAIM = dto.SV_CONCLAIM,
            SV_WINCLAIM = dto.SV_WINCLAIM,
        };
    }

    public static void UpdateEntity(this CLAIM_WIN entity, UpdateCLAIM_WINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONCLAIM = dto.SV_CONCLAIM;
        entity.SV_WINCLAIM = dto.SV_WINCLAIM;
    }
}
