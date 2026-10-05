using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5501MappingExtensions
{
    public static TABLE5501Dto ToDto(this TABLE5501 entity)
    {
        if (entity == null) return null!;
        return new TABLE5501Dto
        {
            NLEGAL_SCH = entity.NLEGAL_SCH,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE5501 ToEntity(this CreateTABLE5501Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5501
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE5501 entity, UpdateTABLE5501Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
