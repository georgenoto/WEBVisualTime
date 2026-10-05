using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5617;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5617MappingExtensions
{
    public static TABLE5617Dto ToDto(this TABLE5617 entity)
    {
        if (entity == null) return null!;
        return new TABLE5617Dto
        {
            NPAYFREQCREDITCARD = entity.NPAYFREQCREDITCARD,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5617 ToEntity(this CreateTABLE5617Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5617
        {
            NPAYFREQCREDITCARD = dto.NPAYFREQCREDITCARD,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5617 entity, UpdateTABLE5617Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPAYFREQCREDITCARD = dto.NPAYFREQCREDITCARD;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
