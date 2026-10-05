using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODCLI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MODCLIMappingExtensions
{
    public static TAB_MODCLIDto ToDto(this TAB_MODCLI entity)
    {
        if (entity == null) return null!;
        return new TAB_MODCLIDto
        {
            SITEM = entity.SITEM,
            STABNAME = entity.STABNAME,
            SINDPK = entity.SINDPK,
        };
    }

    public static TAB_MODCLI ToEntity(this CreateTAB_MODCLIDto dto)
    {
        if (dto == null) return null!;
        return new TAB_MODCLI
        {
            SINDPK = dto.SINDPK,
        };
    }

    public static void UpdateEntity(this TAB_MODCLI entity, UpdateTAB_MODCLIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SINDPK = dto.SINDPK;
    }
}
