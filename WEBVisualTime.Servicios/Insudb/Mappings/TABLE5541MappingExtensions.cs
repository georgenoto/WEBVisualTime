using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5541;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5541MappingExtensions
{
    public static TABLE5541Dto ToDto(this TABLE5541 entity)
    {
        if (entity == null) return null!;
        return new TABLE5541Dto
        {
            NLEVEL_SECTOR = entity.NLEVEL_SECTOR,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5541 ToEntity(this CreateTABLE5541Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5541
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5541 entity, UpdateTABLE5541Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
