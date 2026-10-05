using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5516;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5516MappingExtensions
{
    public static TABLE5516Dto ToDto(this TABLE5516 entity)
    {
        if (entity == null) return null!;
        return new TABLE5516Dto
        {
            NMOTIVE_ITIN = entity.NMOTIVE_ITIN,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5516 ToEntity(this CreateTABLE5516Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5516
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5516 entity, UpdateTABLE5516Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
