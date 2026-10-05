using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5616;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5616MappingExtensions
{
    public static TABLE5616Dto ToDto(this TABLE5616 entity)
    {
        if (entity == null) return null!;
        return new TABLE5616Dto
        {
            NPAYFORMCREDITCARD = entity.NPAYFORMCREDITCARD,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5616 ToEntity(this CreateTABLE5616Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5616
        {
            NPAYFORMCREDITCARD = dto.NPAYFORMCREDITCARD,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5616 entity, UpdateTABLE5616Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPAYFORMCREDITCARD = dto.NPAYFORMCREDITCARD;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
