using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9238MappingExtensions
{
    public static TABLE9238Dto ToDto(this TABLE9238 entity)
    {
        if (entity == null) return null!;
        return new TABLE9238Dto
        {
            NORDERTYPE = entity.NORDERTYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9238 ToEntity(this CreateTABLE9238Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9238
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9238 entity, UpdateTABLE9238Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
