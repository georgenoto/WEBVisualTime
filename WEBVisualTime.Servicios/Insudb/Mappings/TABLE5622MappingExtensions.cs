using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5622;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5622MappingExtensions
{
    public static TABLE5622Dto ToDto(this TABLE5622 entity)
    {
        if (entity == null) return null!;
        return new TABLE5622Dto
        {
            NTYPEOFWORK = entity.NTYPEOFWORK,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE5622 ToEntity(this CreateTABLE5622Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5622
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE5622 entity, UpdateTABLE5622Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
