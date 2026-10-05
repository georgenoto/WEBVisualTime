using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6046;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE6046MappingExtensions
{
    public static TABLE6046Dto ToDto(this TABLE6046 entity)
    {
        if (entity == null) return null!;
        return new TABLE6046Dto
        {
            NCLI_CATEGORY = entity.NCLI_CATEGORY,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE6046 ToEntity(this CreateTABLE6046Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE6046
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE6046 entity, UpdateTABLE6046Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
