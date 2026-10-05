using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_ROLES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_SURR_ROLESMappingExtensions
{
    public static SCHE_SURR_ROLESDto ToDto(this SCHE_SURR_ROLES entity)
    {
        if (entity == null) return null!;
        return new SCHE_SURR_ROLESDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NROLE = entity.NROLE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SCHE_SURR_ROLES ToEntity(this CreateSCHE_SURR_ROLESDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_SURR_ROLES
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            NROLE = dto.NROLE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SCHE_SURR_ROLES entity, UpdateSCHE_SURR_ROLESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.NROLE = dto.NROLE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
