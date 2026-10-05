using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5770MappingExtensions
{
    public static TABLE5770Dto ToDto(this TABLE5770 entity)
    {
        if (entity == null) return null!;
        return new TABLE5770Dto
        {
            NSPECIALBUSINES = entity.NSPECIALBUSINES,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE5770 ToEntity(this CreateTABLE5770Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5770
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE5770 entity, UpdateTABLE5770Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
