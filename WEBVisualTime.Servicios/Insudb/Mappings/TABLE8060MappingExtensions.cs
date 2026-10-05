using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8060MappingExtensions
{
    public static TABLE8060Dto ToDto(this TABLE8060 entity)
    {
        if (entity == null) return null!;
        return new TABLE8060Dto
        {
            NBESTTIMETOCALL = entity.NBESTTIMETOCALL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
        };
    }

    public static TABLE8060 ToEntity(this CreateTABLE8060Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8060
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
        };
    }

    public static void UpdateEntity(this TABLE8060 entity, UpdateTABLE8060Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
    }
}
