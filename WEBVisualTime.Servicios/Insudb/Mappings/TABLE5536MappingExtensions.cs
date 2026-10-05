using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5536;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5536MappingExtensions
{
    public static TABLE5536Dto ToDto(this TABLE5536 entity)
    {
        if (entity == null) return null!;
        return new TABLE5536Dto
        {
            NSTRUCTURE_WALL = entity.NSTRUCTURE_WALL,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5536 ToEntity(this CreateTABLE5536Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5536
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5536 entity, UpdateTABLE5536Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
