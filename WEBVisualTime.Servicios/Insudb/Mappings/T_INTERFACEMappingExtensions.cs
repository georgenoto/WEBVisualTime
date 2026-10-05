using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_INTERFACE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_INTERFACEMappingExtensions
{
    public static T_INTERFACEDto ToDto(this T_INTERFACE entity)
    {
        if (entity == null) return null!;
        return new T_INTERFACEDto
        {
            SKEY = entity.SKEY,
            NROW = entity.NROW,
            NCOLUMN = entity.NCOLUMN,
            SVALUE = entity.SVALUE,
            STABLE = entity.STABLE,
            SPROCESS = entity.SPROCESS,
            NFIELD = entity.NFIELD,
            SVALUE_HOMO = entity.SVALUE_HOMO,
            SFIELDDESC = entity.SFIELDDESC,
            NDATATYPE = entity.NDATATYPE,
        };
    }

    public static T_INTERFACE ToEntity(this CreateT_INTERFACEDto dto)
    {
        if (dto == null) return null!;
        return new T_INTERFACE
        {
            SVALUE = dto.SVALUE,
            SPROCESS = dto.SPROCESS,
            NFIELD = dto.NFIELD,
            SVALUE_HOMO = dto.SVALUE_HOMO,
            SFIELDDESC = dto.SFIELDDESC,
            NDATATYPE = dto.NDATATYPE,
        };
    }

    public static void UpdateEntity(this T_INTERFACE entity, UpdateT_INTERFACEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SVALUE = dto.SVALUE;
        entity.SPROCESS = dto.SPROCESS;
        entity.NFIELD = dto.NFIELD;
        entity.SVALUE_HOMO = dto.SVALUE_HOMO;
        entity.SFIELDDESC = dto.SFIELDDESC;
        entity.NDATATYPE = dto.NDATATYPE;
    }
}
