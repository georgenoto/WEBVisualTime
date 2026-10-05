using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_FEES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_FEESMappingExtensions
{
    public static TAB_PROV_FEESDto ToDto(this TAB_PROV_FEES entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_FEESDto
        {
            NPROVIDER = entity.NPROVIDER,
            NZONE = entity.NZONE,
            //TAB_PROV_ZONENZONENPROVIDER = entity.TAB_PROV_ZONENZONE?.NPROVIDER,
            STYPEBENEFIT = entity.STYPEBENEFIT,
            TABLE8600SDESCRIPT = entity.TABLE8600?.SDESCRIPT,
            SBENEFITCLAS = entity.SBENEFITCLAS,
            TABLE8601SDESCRIPT = entity.TABLE8601?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NDISC_FEE = entity.NDISC_FEE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_PROV_FEES ToEntity(this CreateTAB_PROV_FEESDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_FEES
        {
            DNULLDATE = dto.DNULLDATE,
            NDISC_FEE = dto.NDISC_FEE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_FEES entity, UpdateTAB_PROV_FEESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NDISC_FEE = dto.NDISC_FEE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
