using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE6007MappingExtensions
{
    public static TABLE6007Dto ToDto(this TABLE6007 entity)
    {
        if (entity == null) return null!;
        return new TABLE6007Dto
        {
            NZONETYPE = entity.NZONETYPE,
            SDESCRIPT = entity.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE6007 ToEntity(this CreateTABLE6007Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE6007
        {
            SDESCRIPT = dto.SDESCRIPT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE6007 entity, UpdateTABLE6007Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
