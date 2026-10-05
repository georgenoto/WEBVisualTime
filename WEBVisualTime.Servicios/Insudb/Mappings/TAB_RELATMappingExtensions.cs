using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_RELAT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_RELATMappingExtensions
{
    public static TAB_RELATDto ToDto(this TAB_RELAT entity)
    {
        if (entity == null) return null!;
        return new TAB_RELATDto
        {
            NRELASHIP = entity.NRELASHIP,
            TABLE15NRELASHIPSDESCRIPT = entity.TABLE15NRELASHIP?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NREL_TARGET = entity.NREL_TARGET,
            TABLE15NREL_TARGETSDESCRIPT = entity.TABLE15NREL_TARGET?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_RELAT ToEntity(this CreateTAB_RELATDto dto)
    {
        if (dto == null) return null!;
        return new TAB_RELAT
        {
            DCOMPDATE = dto.DCOMPDATE,
            NREL_TARGET = dto.NREL_TARGET,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_RELAT entity, UpdateTAB_RELATDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NREL_TARGET = dto.NREL_TARGET;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
