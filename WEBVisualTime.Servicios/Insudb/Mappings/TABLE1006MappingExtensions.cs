using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1006;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE1006MappingExtensions
{
    public static TABLE1006Dto ToDto(this TABLE1006 entity)
    {
        if (entity == null) return null!;
        return new TABLE1006Dto
        {
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NPRIORITY = entity.NPRIORITY,
        };
    }

    public static TABLE1006 ToEntity(this CreateTABLE1006Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE1006
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE1006 entity, UpdateTABLE1006Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
