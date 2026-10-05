using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE6786MappingExtensions
{
    public static TABLE6786Dto ToDto(this TABLE6786 entity)
    {
        if (entity == null) return null!;
        return new TABLE6786Dto
        {
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            NDEFTYPE = entity.NDEFTYPE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE6786 ToEntity(this CreateTABLE6786Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE6786
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE6786 entity, UpdateTABLE6786Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
