using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5506MappingExtensions
{
    public static TABLE5506Dto ToDto(this TABLE5506 entity)
    {
        if (entity == null) return null!;
        return new TABLE5506Dto
        {
            NHOBBY = entity.NHOBBY,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5506 ToEntity(this CreateTABLE5506Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5506
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5506 entity, UpdateTABLE5506Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
