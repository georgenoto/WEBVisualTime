using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_WIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FINANC_WINMappingExtensions
{
    public static FINANC_WINDto ToDto(this FINANC_WIN entity)
    {
        if (entity == null) return null!;
        return new FINANC_WINDto
        {
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            SV_CONCONTR = entity.SV_CONCONTR,
            SV_WINCONTR = entity.SV_WINCONTR,
        };
    }

    public static FINANC_WIN ToEntity(this CreateFINANC_WINDto dto)
    {
        if (dto == null) return null!;
        return new FINANC_WIN
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONCONTR = dto.SV_CONCONTR,
            SV_WINCONTR = dto.SV_WINCONTR,
        };
    }

    public static void UpdateEntity(this FINANC_WIN entity, UpdateFINANC_WINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONCONTR = dto.SV_CONCONTR;
        entity.SV_WINCONTR = dto.SV_WINCONTR;
    }
}
