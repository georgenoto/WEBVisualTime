using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9108MappingExtensions
{
    public static TABLE9108Dto ToDto(this TABLE9108 entity)
    {
        if (entity == null) return null!;
        return new TABLE9108Dto
        {
            NTYPE_CONTRAT = entity.NTYPE_CONTRAT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9108 ToEntity(this CreateTABLE9108Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9108
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9108 entity, UpdateTABLE9108Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
