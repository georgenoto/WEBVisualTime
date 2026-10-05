using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8500;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8500MappingExtensions
{
    public static TABLE8500Dto ToDto(this TABLE8500 entity)
    {
        if (entity == null) return null!;
        return new TABLE8500Dto
        {
            NTYPE_SCHCOM = entity.NTYPE_SCHCOM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE8500 ToEntity(this CreateTABLE8500Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8500
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE8500 entity, UpdateTABLE8500Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
