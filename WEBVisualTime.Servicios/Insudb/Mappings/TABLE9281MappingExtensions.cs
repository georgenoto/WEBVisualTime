using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9281;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9281MappingExtensions
{
    public static TABLE9281Dto ToDto(this TABLE9281 entity)
    {
        if (entity == null) return null!;
        return new TABLE9281Dto
        {
            NSERVICE_TYPE = entity.NSERVICE_TYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE9281 ToEntity(this CreateTABLE9281Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9281
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE9281 entity, UpdateTABLE9281Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
