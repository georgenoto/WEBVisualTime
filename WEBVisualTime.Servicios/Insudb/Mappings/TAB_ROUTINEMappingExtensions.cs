using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_ROUTINE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_ROUTINEMappingExtensions
{
    public static TAB_ROUTINEDto ToDto(this TAB_ROUTINE entity)
    {
        if (entity == null) return null!;
        return new TAB_ROUTINEDto
        {
            SROUTINE = entity.SROUTINE,
            NROUTINETYPE = entity.NROUTINETYPE,
            TABLE9105SDESCRIPT = entity.TABLE9105?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_ROUTINE ToEntity(this CreateTAB_ROUTINEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_ROUTINE
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_ROUTINE entity, UpdateTAB_ROUTINEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
