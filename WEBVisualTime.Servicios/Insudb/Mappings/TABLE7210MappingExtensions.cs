using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7210MappingExtensions
{
    public static TABLE7210Dto ToDto(this TABLE7210 entity)
    {
        if (entity == null) return null!;
        return new TABLE7210Dto
        {
            NDEPRECIATION = entity.NDEPRECIATION,
            SDESCRIPT = entity.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE7210 ToEntity(this CreateTABLE7210Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7210
        {
            SDESCRIPT = dto.SDESCRIPT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE7210 entity, UpdateTABLE7210Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
