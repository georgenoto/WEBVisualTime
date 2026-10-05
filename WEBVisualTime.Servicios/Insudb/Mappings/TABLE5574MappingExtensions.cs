using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5574;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5574MappingExtensions
{
    public static TABLE5574Dto ToDto(this TABLE5574 entity)
    {
        if (entity == null) return null!;
        return new TABLE5574Dto
        {
            NSENDADDR = entity.NSENDADDR,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5574 ToEntity(this CreateTABLE5574Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5574
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5574 entity, UpdateTABLE5574Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
