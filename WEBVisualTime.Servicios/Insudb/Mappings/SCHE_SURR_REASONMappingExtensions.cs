using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_REASON;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_SURR_REASONMappingExtensions
{
    public static SCHE_SURR_REASONDto ToDto(this SCHE_SURR_REASON entity)
    {
        if (entity == null) return null!;
        return new SCHE_SURR_REASONDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NSURR_REASON = entity.NSURR_REASON,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SCHE_SURR_REASON ToEntity(this CreateSCHE_SURR_REASONDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_SURR_REASON
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            NSURR_REASON = dto.NSURR_REASON,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SCHE_SURR_REASON entity, UpdateSCHE_SURR_REASONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.NSURR_REASON = dto.NSURR_REASON;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
