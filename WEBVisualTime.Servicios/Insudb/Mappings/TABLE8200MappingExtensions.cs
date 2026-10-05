using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8200MappingExtensions
{
    public static TABLE8200Dto ToDto(this TABLE8200 entity)
    {
        if (entity == null) return null!;
        return new TABLE8200Dto
        {
            NPROCESS = entity.NPROCESS,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE8200 ToEntity(this CreateTABLE8200Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8200
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE8200 entity, UpdateTABLE8200Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
