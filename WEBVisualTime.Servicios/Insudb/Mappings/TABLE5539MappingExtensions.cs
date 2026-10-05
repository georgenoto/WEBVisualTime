using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5539;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5539MappingExtensions
{
    public static TABLE5539Dto ToDto(this TABLE5539 entity)
    {
        if (entity == null) return null!;
        return new TABLE5539Dto
        {
            NINSTRUMENT_TY = entity.NINSTRUMENT_TY,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5539 ToEntity(this CreateTABLE5539Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5539
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5539 entity, UpdateTABLE5539Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
