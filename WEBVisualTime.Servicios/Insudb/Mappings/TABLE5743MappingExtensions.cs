using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5743;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5743MappingExtensions
{
    public static TABLE5743Dto ToDto(this TABLE5743 entity)
    {
        if (entity == null) return null!;
        return new TABLE5743Dto
        {
            NTYPE_AMEAPV = entity.NTYPE_AMEAPV,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE5743 ToEntity(this CreateTABLE5743Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5743
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE5743 entity, UpdateTABLE5743Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
