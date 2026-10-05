using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9214MappingExtensions
{
    public static TABLE9214Dto ToDto(this TABLE9214 entity)
    {
        if (entity == null) return null!;
        return new TABLE9214Dto
        {
            NGEOGRAPHAREA = entity.NGEOGRAPHAREA,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9214 ToEntity(this CreateTABLE9214Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9214
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9214 entity, UpdateTABLE9214Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
