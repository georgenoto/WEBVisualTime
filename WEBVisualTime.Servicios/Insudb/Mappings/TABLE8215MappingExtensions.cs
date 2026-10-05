using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8215MappingExtensions
{
    public static TABLE8215Dto ToDto(this TABLE8215 entity)
    {
        if (entity == null) return null!;
        return new TABLE8215Dto
        {
            NTYPE_VALUECOLLECT = entity.NTYPE_VALUECOLLECT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE8215 ToEntity(this CreateTABLE8215Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8215
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE8215 entity, UpdateTABLE8215Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
