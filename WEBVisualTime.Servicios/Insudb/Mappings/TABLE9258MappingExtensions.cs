using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9258MappingExtensions
{
    public static TABLE9258Dto ToDto(this TABLE9258 entity)
    {
        if (entity == null) return null!;
        return new TABLE9258Dto
        {
            NSERV_ESTRUCT = entity.NSERV_ESTRUCT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9258 ToEntity(this CreateTABLE9258Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9258
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9258 entity, UpdateTABLE9258Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
