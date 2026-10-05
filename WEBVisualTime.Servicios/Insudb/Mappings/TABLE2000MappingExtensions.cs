using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE2000MappingExtensions
{
    public static TABLE2000Dto ToDto(this TABLE2000 entity)
    {
        if (entity == null) return null!;
        return new TABLE2000Dto
        {
            NAPLY = entity.NAPLY,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE2000 ToEntity(this CreateTABLE2000Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE2000
        {
            NAPLY = dto.NAPLY,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE2000 entity, UpdateTABLE2000Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAPLY = dto.NAPLY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
