using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5587MappingExtensions
{
    public static TABLE5587Dto ToDto(this TABLE5587 entity)
    {
        if (entity == null) return null!;
        return new TABLE5587Dto
        {
            NCOLLECDOCTYP = entity.NCOLLECDOCTYP,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5587 ToEntity(this CreateTABLE5587Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5587
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5587 entity, UpdateTABLE5587Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
