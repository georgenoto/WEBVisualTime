using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8206MappingExtensions
{
    public static TABLE8206Dto ToDto(this TABLE8206 entity)
    {
        if (entity == null) return null!;
        return new TABLE8206Dto
        {
            NACTION = entity.NACTION,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE8206 ToEntity(this CreateTABLE8206Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8206
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE8206 entity, UpdateTABLE8206Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
