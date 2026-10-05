using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6100;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE6100MappingExtensions
{
    public static TABLE6100Dto ToDto(this TABLE6100 entity)
    {
        if (entity == null) return null!;
        return new TABLE6100Dto
        {
            NCLASEMPRESALEGAL = entity.NCLASEMPRESALEGAL,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE6100 ToEntity(this CreateTABLE6100Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE6100
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE6100 entity, UpdateTABLE6100Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
