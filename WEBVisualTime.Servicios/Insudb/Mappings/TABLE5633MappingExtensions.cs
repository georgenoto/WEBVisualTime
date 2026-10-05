using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5633;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5633MappingExtensions
{
    public static TABLE5633Dto ToDto(this TABLE5633 entity)
    {
        if (entity == null) return null!;
        return new TABLE5633Dto
        {
            NORIGIN = entity.NORIGIN,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTABLE6071 = entity.NTABLE6071,
            TABLE6071SDESCRIPT = entity.TABLE6071?.SDESCRIPT,
        };
    }

    public static TABLE5633 ToEntity(this CreateTABLE5633Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5633
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTABLE6071 = dto.NTABLE6071,
        };
    }

    public static void UpdateEntity(this TABLE5633 entity, UpdateTABLE5633Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTABLE6071 = dto.NTABLE6071;
    }
}
