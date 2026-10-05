using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_PARAM_INTERFACE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_PARAM_INTERFACEMappingExtensions
{
    public static T_PARAM_INTERFACEDto ToDto(this T_PARAM_INTERFACE entity)
    {
        if (entity == null) return null!;
        return new T_PARAM_INTERFACEDto
        {
            SKEY = entity.SKEY,
            NFIELD = entity.NFIELD,
            SVALUE = entity.SVALUE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static T_PARAM_INTERFACE ToEntity(this CreateT_PARAM_INTERFACEDto dto)
    {
        if (dto == null) return null!;
        return new T_PARAM_INTERFACE
        {
            SVALUE = dto.SVALUE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this T_PARAM_INTERFACE entity, UpdateT_PARAM_INTERFACEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SVALUE = dto.SVALUE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
