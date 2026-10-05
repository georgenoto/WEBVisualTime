using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5611;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5611MappingExtensions
{
    public static TABLE5611Dto ToDto(this TABLE5611 entity)
    {
        if (entity == null) return null!;
        return new TABLE5611Dto
        {
            NCON_EARTHQUAKE = entity.NCON_EARTHQUAKE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5611 ToEntity(this CreateTABLE5611Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5611
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5611 entity, UpdateTABLE5611Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
