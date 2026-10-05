using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_MAP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REPORT_MAPMappingExtensions
{
    public static REPORT_MAPDto ToDto(this REPORT_MAP entity)
    {
        if (entity == null) return null!;
        return new REPORT_MAPDto
        {
            NORDER = entity.NORDER,
            NCODIG = entity.NCODIG,
            NORIGIN = entity.NORIGIN,
            NTYPE = entity.NTYPE,
        };
    }

    public static REPORT_MAP ToEntity(this CreateREPORT_MAPDto dto)
    {
        if (dto == null) return null!;
        return new REPORT_MAP
        {
            NORDER = dto.NORDER,
            NCODIG = dto.NCODIG,
            NORIGIN = dto.NORIGIN,
            NTYPE = dto.NTYPE,
        };
    }

    public static void UpdateEntity(this REPORT_MAP entity, UpdateREPORT_MAPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NORDER = dto.NORDER;
        entity.NCODIG = dto.NCODIG;
        entity.NORIGIN = dto.NORIGIN;
        entity.NTYPE = dto.NTYPE;
    }
}
