using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9278;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9278MappingExtensions
{
    public static TABLE9278Dto ToDto(this TABLE9278 entity)
    {
        if (entity == null) return null!;
        return new TABLE9278Dto
        {
            NSUM_INSURED_TYPE = entity.NSUM_INSURED_TYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE9278 ToEntity(this CreateTABLE9278Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9278
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE9278 entity, UpdateTABLE9278Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
