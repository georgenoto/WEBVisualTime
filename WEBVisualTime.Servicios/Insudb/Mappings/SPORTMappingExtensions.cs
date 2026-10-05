using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SPORT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SPORTMappingExtensions
{
    public static SPORTDto ToDto(this SPORT entity)
    {
        if (entity == null) return null!;
        return new SPORTDto
        {
            NSPORT = entity.NSPORT,
            TABLE512SDESCRIPT = entity.TABLE512?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SPORT ToEntity(this CreateSPORTDto dto)
    {
        if (dto == null) return null!;
        return new SPORT
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SPORT entity, UpdateSPORTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
