using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE271MappingExtensions
{
    public static TABLE271Dto ToDto(this TABLE271 entity)
    {
        if (entity == null) return null!;
        return new TABLE271Dto
        {
            NEXC_CODE = entity.NEXC_CODE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE271 ToEntity(this CreateTABLE271Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE271
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE271 entity, UpdateTABLE271Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
