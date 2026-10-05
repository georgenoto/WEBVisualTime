using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5709;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5709MappingExtensions
{
    public static TABLE5709Dto ToDto(this TABLE5709 entity)
    {
        if (entity == null) return null!;
        return new TABLE5709Dto
        {
            NTYPE = entity.NTYPE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5709 ToEntity(this CreateTABLE5709Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5709
        {
            NTYPE = dto.NTYPE,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5709 entity, UpdateTABLE5709Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPE = dto.NTYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
