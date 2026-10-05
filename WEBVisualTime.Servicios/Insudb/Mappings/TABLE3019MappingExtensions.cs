using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3019;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE3019MappingExtensions
{
    public static TABLE3019Dto ToDto(this TABLE3019 entity)
    {
        if (entity == null) return null!;
        return new TABLE3019Dto
        {
            NRECOWNER = entity.NRECOWNER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE3019 ToEntity(this CreateTABLE3019Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE3019
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE3019 entity, UpdateTABLE3019Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
