using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9221MappingExtensions
{
    public static TABLE9221Dto ToDto(this TABLE9221 entity)
    {
        if (entity == null) return null!;
        return new TABLE9221Dto
        {
            NTYPEEXHAUS = entity.NTYPEEXHAUS,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9221 ToEntity(this CreateTABLE9221Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9221
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9221 entity, UpdateTABLE9221Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
