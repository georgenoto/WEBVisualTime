using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6000;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE6000MappingExtensions
{
    public static TABLE6000Dto ToDto(this TABLE6000 entity)
    {
        if (entity == null) return null!;
        return new TABLE6000Dto
        {
            NTYPEOFADDRESS = entity.NTYPEOFADDRESS,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE6000 ToEntity(this CreateTABLE6000Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE6000
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE6000 entity, UpdateTABLE6000Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
