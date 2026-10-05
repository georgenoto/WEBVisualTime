using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE999MappingExtensions
{
    public static TABLE999Dto ToDto(this TABLE999 entity)
    {
        if (entity == null) return null!;
        return new TABLE999Dto
        {
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SSTAT_ERROR = entity.SSTAT_ERROR,
        };
    }

    public static TABLE999 ToEntity(this CreateTABLE999Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE999
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE999 entity, UpdateTABLE999Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
