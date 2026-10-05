using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINFIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WINFINMappingExtensions
{
    public static TAB_WINFINDto ToDto(this TAB_WINFIN entity)
    {
        if (entity == null) return null!;
        return new TAB_WINFINDto
        {
            NTRATYPEC = entity.NTRATYPEC,
            NSEQUENCE = entity.NSEQUENCE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_WINFIN ToEntity(this CreateTAB_WINFINDto dto)
    {
        if (dto == null) return null!;
        return new TAB_WINFIN
        {
            SCODISPL = dto.SCODISPL,
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_WINFIN entity, UpdateTAB_WINFINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
