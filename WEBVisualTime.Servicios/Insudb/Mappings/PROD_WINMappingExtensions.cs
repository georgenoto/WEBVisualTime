using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_WIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROD_WINMappingExtensions
{
    public static PROD_WINDto ToDto(this PROD_WIN entity)
    {
        if (entity == null) return null!;
        return new PROD_WINDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SV_CONPRODU = entity.SV_CONPRODU,
            SV_WINPRODU = entity.SV_WINPRODU,
            SV_WINPRODU1 = entity.SV_WINPRODU1,
        };
    }

    public static PROD_WIN ToEntity(this CreatePROD_WINDto dto)
    {
        if (dto == null) return null!;
        return new PROD_WIN
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONPRODU = dto.SV_CONPRODU,
            SV_WINPRODU = dto.SV_WINPRODU,
            SV_WINPRODU1 = dto.SV_WINPRODU1,
        };
    }

    public static void UpdateEntity(this PROD_WIN entity, UpdatePROD_WINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONPRODU = dto.SV_CONPRODU;
        entity.SV_WINPRODU = dto.SV_WINPRODU;
        entity.SV_WINPRODU1 = dto.SV_WINPRODU1;
    }
}
