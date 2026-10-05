using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_WIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_WINMappingExtensions
{
    public static CLIENT_WINDto ToDto(this CLIENT_WIN entity)
    {
        if (entity == null) return null!;
        return new CLIENT_WINDto
        {
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SV_CONCLIEN = entity.SV_CONCLIEN,
            SV_WINCLIEN = entity.SV_WINCLIEN,
        };
    }

    public static CLIENT_WIN ToEntity(this CreateCLIENT_WINDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_WIN
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONCLIEN = dto.SV_CONCLIEN,
            SV_WINCLIEN = dto.SV_WINCLIEN,
        };
    }

    public static void UpdateEntity(this CLIENT_WIN entity, UpdateCLIENT_WINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONCLIEN = dto.SV_CONCLIEN;
        entity.SV_WINCLIEN = dto.SV_WINCLIEN;
    }
}
