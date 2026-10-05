using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCT_FLAVOURS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_PRODUCT_FLAVOURSMappingExtensions
{
    public static CDI_PRODUCT_FLAVOURSDto ToDto(this CDI_PRODUCT_FLAVOURS entity)
    {
        if (entity == null) return null!;
        return new CDI_PRODUCT_FLAVOURSDto
        {
            P_SNAME = entity.P_SNAME,
            P_CGVERSION = entity.P_CGVERSION,
            SEQ = entity.SEQ,
            DESCRIPTION = entity.DESCRIPTION,
        };
    }

    public static CDI_PRODUCT_FLAVOURS ToEntity(this CreateCDI_PRODUCT_FLAVOURSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_PRODUCT_FLAVOURS
        {
            P_SNAME = dto.P_SNAME,
            P_CGVERSION = dto.P_CGVERSION,
            SEQ = dto.SEQ,
            DESCRIPTION = dto.DESCRIPTION,
        };
    }

    public static void UpdateEntity(this CDI_PRODUCT_FLAVOURS entity, UpdateCDI_PRODUCT_FLAVOURSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.P_SNAME = dto.P_SNAME;
        entity.P_CGVERSION = dto.P_CGVERSION;
        entity.SEQ = dto.SEQ;
        entity.DESCRIPTION = dto.DESCRIPTION;
    }
}
