using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5576MappingExtensions
{
    public static TABLE5576Dto ToDto(this TABLE5576 entity)
    {
        if (entity == null) return null!;
        return new TABLE5576Dto
        {
            NCHEQUE_STAT = entity.NCHEQUE_STAT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5576 ToEntity(this CreateTABLE5576Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5576
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5576 entity, UpdateTABLE5576Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
