using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7001;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7001MappingExtensions
{
    public static TABLE7001Dto ToDto(this TABLE7001 entity)
    {
        if (entity == null) return null!;
        return new TABLE7001Dto
        {
            NTYPEREQUEST = entity.NTYPEREQUEST,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE7001 ToEntity(this CreateTABLE7001Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7001
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE7001 entity, UpdateTABLE7001Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
