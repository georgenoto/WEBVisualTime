using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5572MappingExtensions
{
    public static TABLE5572Dto ToDto(this TABLE5572 entity)
    {
        if (entity == null) return null!;
        return new TABLE5572Dto
        {
            NSTATUS_EVAL = entity.NSTATUS_EVAL,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5572 ToEntity(this CreateTABLE5572Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5572
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5572 entity, UpdateTABLE5572Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
