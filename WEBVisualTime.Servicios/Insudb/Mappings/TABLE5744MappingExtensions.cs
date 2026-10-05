using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5744;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5744MappingExtensions
{
    public static TABLE5744Dto ToDto(this TABLE5744 entity)
    {
        if (entity == null) return null!;
        return new TABLE5744Dto
        {
            NFUNDS_ORIGIN = entity.NFUNDS_ORIGIN,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE5744 ToEntity(this CreateTABLE5744Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5744
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE5744 entity, UpdateTABLE5744Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
