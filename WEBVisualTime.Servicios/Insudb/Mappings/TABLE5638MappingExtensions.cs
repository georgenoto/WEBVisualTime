using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5638;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5638MappingExtensions
{
    public static TABLE5638Dto ToDto(this TABLE5638 entity)
    {
        if (entity == null) return null!;
        return new TABLE5638Dto
        {
            NCOMPANY = entity.NCOMPANY,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SOWNER_BASE = entity.SOWNER_BASE,
            SACCESSWO = entity.SACCESSWO,
        };
    }

    public static TABLE5638 ToEntity(this CreateTABLE5638Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5638
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SOWNER_BASE = dto.SOWNER_BASE,
            SACCESSWO = dto.SACCESSWO,
        };
    }

    public static void UpdateEntity(this TABLE5638 entity, UpdateTABLE5638Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SOWNER_BASE = dto.SOWNER_BASE;
        entity.SACCESSWO = dto.SACCESSWO;
    }
}
