using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE201;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE201MappingExtensions
{
    public static TABLE201Dto ToDto(this TABLE201 entity)
    {
        if (entity == null) return null!;
        return new TABLE201Dto
        {
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYPEWARRANTY = entity.NTYPEWARRANTY,
        };
    }

    public static TABLE201 ToEntity(this CreateTABLE201Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE201
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE201 entity, UpdateTABLE201Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
