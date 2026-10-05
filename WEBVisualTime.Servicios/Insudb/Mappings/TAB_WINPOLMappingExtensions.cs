using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPOL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WINPOLMappingExtensions
{
    public static TAB_WINPOLDto ToDto(this TAB_WINPOL entity)
    {
        if (entity == null) return null!;
        return new TAB_WINPOLDto
        {
            SBUSSITYP = entity.SBUSSITYP,
            SPOLITYPE = entity.SPOLITYPE,
            SCOMPON = entity.SCOMPON,
            NSEQUENCE = entity.NSEQUENCE,
            NTRATYPEP = entity.NTRATYPEP,
            TABLE5588SDESCRIPT = entity.TABLE5588?.SDESCRIPT,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
            SAUTOMATIC = entity.SAUTOMATIC,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            SBRANCHT = entity.SBRANCHT,
        };
    }

    public static TAB_WINPOL ToEntity(this CreateTAB_WINPOLDto dto)
    {
        if (dto == null) return null!;
        return new TAB_WINPOL
        {
            NSEQUENCE = dto.NSEQUENCE,
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
            SAUTOMATIC = dto.SAUTOMATIC,
        };
    }

    public static void UpdateEntity(this TAB_WINPOL entity, UpdateTAB_WINPOLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSEQUENCE = dto.NSEQUENCE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SAUTOMATIC = dto.SAUTOMATIC;
    }
}
