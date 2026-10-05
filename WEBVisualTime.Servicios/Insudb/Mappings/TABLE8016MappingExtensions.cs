using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8016;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8016MappingExtensions
{
    public static TABLE8016Dto ToDto(this TABLE8016 entity)
    {
        if (entity == null) return null!;
        return new TABLE8016Dto
        {
            NTYPMOV_GUAR = entity.NTYPMOV_GUAR,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8016 ToEntity(this CreateTABLE8016Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8016
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8016 entity, UpdateTABLE8016Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
