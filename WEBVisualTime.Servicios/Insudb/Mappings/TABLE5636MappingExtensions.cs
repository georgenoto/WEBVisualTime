using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5636MappingExtensions
{
    public static TABLE5636Dto ToDto(this TABLE5636 entity)
    {
        if (entity == null) return null!;
        return new TABLE5636Dto
        {
            NTYPE_PAYMENT = entity.NTYPE_PAYMENT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5636 ToEntity(this CreateTABLE5636Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5636
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5636 entity, UpdateTABLE5636Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
