using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5535;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5535MappingExtensions
{
    public static TABLE5535Dto ToDto(this TABLE5535 entity)
    {
        if (entity == null) return null!;
        return new TABLE5535Dto
        {
            NDAMAGE_MAGNIF = entity.NDAMAGE_MAGNIF,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5535 ToEntity(this CreateTABLE5535Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5535
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5535 entity, UpdateTABLE5535Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
