using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9254MappingExtensions
{
    public static TABLE9254Dto ToDto(this TABLE9254 entity)
    {
        if (entity == null) return null!;
        return new TABLE9254Dto
        {
            NTYPEDISC_PROV = entity.NTYPEDISC_PROV,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9254 ToEntity(this CreateTABLE9254Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9254
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9254 entity, UpdateTABLE9254Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
