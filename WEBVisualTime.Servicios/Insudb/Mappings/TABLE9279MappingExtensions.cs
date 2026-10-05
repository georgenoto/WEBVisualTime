using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9279MappingExtensions
{
    public static TABLE9279Dto ToDto(this TABLE9279 entity)
    {
        if (entity == null) return null!;
        return new TABLE9279Dto
        {
            NSUBLIMIT_TYPE = entity.NSUBLIMIT_TYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE9279 ToEntity(this CreateTABLE9279Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9279
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE9279 entity, UpdateTABLE9279Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
