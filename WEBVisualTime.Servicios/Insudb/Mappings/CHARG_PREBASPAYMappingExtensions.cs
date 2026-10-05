using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHARG_PREBASPAY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CHARG_PREBASPAYMappingExtensions
{
    public static CHARG_PREBASPAYDto ToDto(this CHARG_PREBASPAY entity)
    {
        if (entity == null) return null!;
        return new CHARG_PREBASPAYDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NAGE_INIT = entity.NAGE_INIT,
            NMONTH_INI = entity.NMONTH_INI,
            NOPTION = entity.NOPTION,
            NAGE_END = entity.NAGE_END,
            NMONTH_END = entity.NMONTH_END,
            NTYPE_CHARG = entity.NTYPE_CHARG,
            NRATE = entity.NRATE,
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NRATE_PPIN = entity.NRATE_PPIN,
            NUSERCODE = entity.NUSERCODE,
            SAPLYQUOT = entity.SAPLYQUOT,
        };
    }

    public static CHARG_PREBASPAY ToEntity(this CreateCHARG_PREBASPAYDto dto)
    {
        if (dto == null) return null!;
        return new CHARG_PREBASPAY
        {
            NAGE_END = dto.NAGE_END,
            NMONTH_END = dto.NMONTH_END,
            NTYPE_CHARG = dto.NTYPE_CHARG,
            NRATE = dto.NRATE,
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NRATE_PPIN = dto.NRATE_PPIN,
            NUSERCODE = dto.NUSERCODE,
            SAPLYQUOT = dto.SAPLYQUOT,
        };
    }

    public static void UpdateEntity(this CHARG_PREBASPAY entity, UpdateCHARG_PREBASPAYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAGE_END = dto.NAGE_END;
        entity.NMONTH_END = dto.NMONTH_END;
        entity.NTYPE_CHARG = dto.NTYPE_CHARG;
        entity.NRATE = dto.NRATE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NRATE_PPIN = dto.NRATE_PPIN;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SAPLYQUOT = dto.SAPLYQUOT;
    }
}
