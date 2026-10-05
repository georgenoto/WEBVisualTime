using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE18MappingExtensions
{
    public static TABLE18Dto ToDto(this TABLE18 entity)
    {
        if (entity == null) return null!;
        return new TABLE18Dto
        {
            SSEXCLIEN = entity.SSEXCLIEN,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE18 ToEntity(this CreateTABLE18Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE18
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE18 entity, UpdateTABLE18Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
