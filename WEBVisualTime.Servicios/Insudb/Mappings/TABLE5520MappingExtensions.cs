using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5520;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5520MappingExtensions
{
    public static TABLE5520Dto ToDto(this TABLE5520 entity)
    {
        if (entity == null) return null!;
        return new TABLE5520Dto
        {
            NTYPEINVEST = entity.NTYPEINVEST,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYPEINVEST_ORIG = entity.NTYPEINVEST_ORIG,
        };
    }

    public static TABLE5520 ToEntity(this CreateTABLE5520Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5520
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYPEINVEST_ORIG = dto.NTYPEINVEST_ORIG,
        };
    }

    public static void UpdateEntity(this TABLE5520 entity, UpdateTABLE5520Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPEINVEST_ORIG = dto.NTYPEINVEST_ORIG;
    }
}
