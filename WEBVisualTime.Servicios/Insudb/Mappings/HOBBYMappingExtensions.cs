using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOBBY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HOBBYMappingExtensions
{
    public static HOBBYDto ToDto(this HOBBY entity)
    {
        if (entity == null) return null!;
        return new HOBBYDto
        {
            NHOBBY = entity.NHOBBY,
            TABLE5506SDESCRIPT = entity.TABLE5506?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static HOBBY ToEntity(this CreateHOBBYDto dto)
    {
        if (dto == null) return null!;
        return new HOBBY
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this HOBBY entity, UpdateHOBBYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
