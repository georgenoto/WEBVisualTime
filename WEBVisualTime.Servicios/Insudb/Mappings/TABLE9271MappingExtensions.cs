using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9271MappingExtensions
{
    public static TABLE9271Dto ToDto(this TABLE9271 entity)
    {
        if (entity == null) return null!;
        return new TABLE9271Dto
        {
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9271 ToEntity(this CreateTABLE9271Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9271
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9271 entity, UpdateTABLE9271Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
