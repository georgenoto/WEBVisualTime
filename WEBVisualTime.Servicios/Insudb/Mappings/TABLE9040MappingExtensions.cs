using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9040;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9040MappingExtensions
{
    public static TABLE9040Dto ToDto(this TABLE9040 entity)
    {
        if (entity == null) return null!;
        return new TABLE9040Dto
        {
            NTYPE_SETTLE = entity.NTYPE_SETTLE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9040 ToEntity(this CreateTABLE9040Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9040
        {
            NTYPE_SETTLE = dto.NTYPE_SETTLE,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9040 entity, UpdateTABLE9040Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPE_SETTLE = dto.NTYPE_SETTLE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
