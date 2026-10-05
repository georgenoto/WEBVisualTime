using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9262MappingExtensions
{
    public static TABLE9262Dto ToDto(this TABLE9262 entity)
    {
        if (entity == null) return null!;
        return new TABLE9262Dto
        {
            NCLAIM_ENTITY = entity.NCLAIM_ENTITY,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9262 ToEntity(this CreateTABLE9262Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9262
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9262 entity, UpdateTABLE9262Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
