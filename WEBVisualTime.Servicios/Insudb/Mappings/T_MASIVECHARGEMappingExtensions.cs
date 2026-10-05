using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MASIVECHARGE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_MASIVECHARGEMappingExtensions
{
    public static T_MASIVECHARGEDto ToDto(this T_MASIVECHARGE entity)
    {
        if (entity == null) return null!;
        return new T_MASIVECHARGEDto
        {
            SKEY = entity.SKEY,
            NROWS = entity.NROWS,
            NCOLUMNS = entity.NCOLUMNS,
            SFIELD = entity.SFIELD,
            SVALUE = entity.SVALUE,
            NSEARCH = entity.NSEARCH,
            TABLE5571SDESCRIPT = entity.TABLE5571?.SDESCRIPT,
            STABLE = entity.STABLE,
            SVALUESLIST = entity.SVALUESLIST,
        };
    }

    public static T_MASIVECHARGE ToEntity(this CreateT_MASIVECHARGEDto dto)
    {
        if (dto == null) return null!;
        return new T_MASIVECHARGE
        {
            SFIELD = dto.SFIELD,
            SVALUE = dto.SVALUE,
            NSEARCH = dto.NSEARCH,
            STABLE = dto.STABLE,
            SVALUESLIST = dto.SVALUESLIST,
        };
    }

    public static void UpdateEntity(this T_MASIVECHARGE entity, UpdateT_MASIVECHARGEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SFIELD = dto.SFIELD;
        entity.SVALUE = dto.SVALUE;
        entity.NSEARCH = dto.NSEARCH;
        entity.STABLE = dto.STABLE;
        entity.SVALUESLIST = dto.SVALUESLIST;
    }
}
