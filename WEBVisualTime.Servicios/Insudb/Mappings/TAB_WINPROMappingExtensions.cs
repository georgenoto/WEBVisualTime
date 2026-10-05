using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPRO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WINPROMappingExtensions
{
    public static TAB_WINPRODto ToDto(this TAB_WINPRO entity)
    {
        if (entity == null) return null!;
        return new TAB_WINPRODto
        {
            SBRANCHT = entity.SBRANCHT,
            TABLE37SDESCRIPT = entity.TABLE37?.SDESCRIPT,
            NSEQUENCE = entity.NSEQUENCE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_WINPRO ToEntity(this CreateTAB_WINPRODto dto)
    {
        if (dto == null) return null!;
        return new TAB_WINPRO
        {
            SCODISPL = dto.SCODISPL,
            DCOMPDATE = dto.DCOMPDATE,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_WINPRO entity, UpdateTAB_WINPRODto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
