using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GOALS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_GOALSMappingExtensions
{
    public static TAB_GOALSDto ToDto(this TAB_GOALS entity)
    {
        if (entity == null) return null!;
        return new TAB_GOALSDto
        {
            NCODE = entity.NCODE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TAB_GOALS ToEntity(this CreateTAB_GOALSDto dto)
    {
        if (dto == null) return null!;
        return new TAB_GOALS
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TAB_GOALS entity, UpdateTAB_GOALSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
