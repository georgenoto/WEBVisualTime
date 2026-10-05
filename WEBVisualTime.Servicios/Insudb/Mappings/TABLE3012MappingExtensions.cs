using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3012;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE3012MappingExtensions
{
    public static TABLE3012Dto ToDto(this TABLE3012 entity)
    {
        if (entity == null) return null!;
        return new TABLE3012Dto
        {
            NENDORSETYPE = entity.NENDORSETYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE3012 ToEntity(this CreateTABLE3012Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE3012
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE3012 entity, UpdateTABLE3012Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
