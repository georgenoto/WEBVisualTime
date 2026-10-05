using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_COM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FINANC_COMMappingExtensions
{
    public static FINANC_COMDto ToDto(this FINANC_COM entity)
    {
        if (entity == null) return null!;
        return new FINANC_COMDto
        {
            NAMOUNT = entity.NAMOUNT,
            NRECEIPT = entity.NRECEIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NPERCENT = entity.NPERCENT,
            NSHARE = entity.NSHARE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
        };
    }

    public static FINANC_COM ToEntity(this CreateFINANC_COMDto dto)
    {
        if (dto == null) return null!;
        return new FINANC_COM
        {
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NPERCENT = dto.NPERCENT,
            NSHARE = dto.NSHARE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this FINANC_COM entity, UpdateFINANC_COMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NPERCENT = dto.NPERCENT;
        entity.NSHARE = dto.NSHARE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
