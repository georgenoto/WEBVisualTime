using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE159;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE159MappingExtensions
{
    public static TABLE159Dto ToDto(this TABLE159 entity)
    {
        if (entity == null) return null!;
        return new TABLE159Dto
        {
            NGROUP_PRES = entity.NGROUP_PRES,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE159 ToEntity(this CreateTABLE159Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE159
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE159 entity, UpdateTABLE159Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
