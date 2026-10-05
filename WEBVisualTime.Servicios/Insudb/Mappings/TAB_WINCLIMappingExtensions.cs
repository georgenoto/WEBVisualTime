using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WINCLIMappingExtensions
{
    public static TAB_WINCLIDto ToDto(this TAB_WINCLI entity)
    {
        if (entity == null) return null!;
        return new TAB_WINCLIDto
        {
            STYPE_CLIE = entity.STYPE_CLIE,
            STYPE_SEQ = entity.STYPE_SEQ,
            NSEQUENCE = entity.NSEQUENCE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_WINCLI ToEntity(this CreateTAB_WINCLIDto dto)
    {
        if (dto == null) return null!;
        return new TAB_WINCLI
        {
            SCODISPL = dto.SCODISPL,
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_WINCLI entity, UpdateTAB_WINCLIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
