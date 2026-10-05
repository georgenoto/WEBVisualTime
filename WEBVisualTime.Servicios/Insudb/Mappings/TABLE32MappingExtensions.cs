using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE32MappingExtensions
{
    public static TABLE32Dto ToDto(this TABLE32 entity)
    {
        if (entity == null) return null!;
        return new TABLE32Dto
        {
            NCRTHECNI = entity.NCRTHECNI,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTABLE8000 = entity.NTABLE8000,
        };
    }

    public static TABLE32 ToEntity(this CreateTABLE32Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE32
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTABLE8000 = dto.NTABLE8000,
        };
    }

    public static void UpdateEntity(this TABLE32 entity, UpdateTABLE32Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTABLE8000 = dto.NTABLE8000;
    }
}
