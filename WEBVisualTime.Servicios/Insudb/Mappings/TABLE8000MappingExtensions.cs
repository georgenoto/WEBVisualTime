using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8000;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8000MappingExtensions
{
    public static TABLE8000Dto ToDto(this TABLE8000 entity)
    {
        if (entity == null) return null!;
        return new TABLE8000Dto
        {
            NTYPEDOC = entity.NTYPEDOC,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8000 ToEntity(this CreateTABLE8000Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8000
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8000 entity, UpdateTABLE8000Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
