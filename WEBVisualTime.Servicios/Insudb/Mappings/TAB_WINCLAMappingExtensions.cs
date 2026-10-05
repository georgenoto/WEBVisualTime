using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WINCLAMappingExtensions
{
    public static TAB_WINCLADto ToDto(this TAB_WINCLA entity)
    {
        if (entity == null) return null!;
        return new TAB_WINCLADto
        {
            NTRATYPEC = entity.NTRATYPEC,
            SBRANCHT = entity.SBRANCHT,
            SBUSSITYP = entity.SBUSSITYP,
            NSEQUENCE = entity.NSEQUENCE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_WINCLA ToEntity(this CreateTAB_WINCLADto dto)
    {
        if (dto == null) return null!;
        return new TAB_WINCLA
        {
            SCODISPL = dto.SCODISPL,
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_WINCLA entity, UpdateTAB_WINCLADto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
