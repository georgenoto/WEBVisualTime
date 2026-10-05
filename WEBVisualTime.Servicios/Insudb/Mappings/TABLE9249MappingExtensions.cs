using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9249MappingExtensions
{
    public static TABLE9249Dto ToDto(this TABLE9249 entity)
    {
        if (entity == null) return null!;
        return new TABLE9249Dto
        {
            NSETTLEMENT_CONC = entity.NSETTLEMENT_CONC,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9249 ToEntity(this CreateTABLE9249Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9249
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9249 entity, UpdateTABLE9249Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
