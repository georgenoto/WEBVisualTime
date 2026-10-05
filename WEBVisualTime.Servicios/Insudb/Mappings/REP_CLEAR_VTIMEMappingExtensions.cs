using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_CLEAR_VTIME;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REP_CLEAR_VTIMEMappingExtensions
{
    public static REP_CLEAR_VTIMEDto ToDto(this REP_CLEAR_VTIME entity)
    {
        if (entity == null) return null!;
        return new REP_CLEAR_VTIMEDto
        {
            STABLE = entity.STABLE,
            NCOUNT = entity.NCOUNT,
            NCOUNT_BD = entity.NCOUNT_BD,
            NCOUNT_DEP = entity.NCOUNT_DEP,
            NERASE = entity.NERASE,
            NDROP = entity.NDROP,
            SCOMMENTS = entity.SCOMMENTS,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static REP_CLEAR_VTIME ToEntity(this CreateREP_CLEAR_VTIMEDto dto)
    {
        if (dto == null) return null!;
        return new REP_CLEAR_VTIME
        {
            STABLE = dto.STABLE,
            NCOUNT = dto.NCOUNT,
            NCOUNT_BD = dto.NCOUNT_BD,
            NCOUNT_DEP = dto.NCOUNT_DEP,
            NERASE = dto.NERASE,
            NDROP = dto.NDROP,
            SCOMMENTS = dto.SCOMMENTS,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this REP_CLEAR_VTIME entity, UpdateREP_CLEAR_VTIMEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STABLE = dto.STABLE;
        entity.NCOUNT = dto.NCOUNT;
        entity.NCOUNT_BD = dto.NCOUNT_BD;
        entity.NCOUNT_DEP = dto.NCOUNT_DEP;
        entity.NERASE = dto.NERASE;
        entity.NDROP = dto.NDROP;
        entity.SCOMMENTS = dto.SCOMMENTS;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
