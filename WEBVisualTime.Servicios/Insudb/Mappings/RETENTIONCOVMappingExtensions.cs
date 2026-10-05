using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RETENTIONCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RETENTIONCOVMappingExtensions
{
    public static RETENTIONCOVDto ToDto(this RETENTIONCOV entity)
    {
        if (entity == null) return null!;
        return new RETENTIONCOVDto
        {
            NBRANCH_REI = entity.NBRANCH_REI,
            DEFFECDATE = entity.DEFFECDATE,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NCOVERGEN = entity.NCOVERGEN,
            DNULLDATE = entity.DNULLDATE,
            NRETENTION = entity.NRETENTION,
            SROUTINE = entity.SROUTINE,
            NCOVPROPOR = entity.NCOVPROPOR,
            NCOMBLIM = entity.NCOMBLIM,
            NCOVERCL = entity.NCOVERCL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SEARTHQUAKE = entity.SEARTHQUAKE,
            NMAXRETAMOUNT = entity.NMAXRETAMOUNT,
        };
    }

    public static RETENTIONCOV ToEntity(this CreateRETENTIONCOVDto dto)
    {
        if (dto == null) return null!;
        return new RETENTIONCOV
        {
            DNULLDATE = dto.DNULLDATE,
            NRETENTION = dto.NRETENTION,
            SROUTINE = dto.SROUTINE,
            NCOVPROPOR = dto.NCOVPROPOR,
            NCOMBLIM = dto.NCOMBLIM,
            NCOVERCL = dto.NCOVERCL,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SEARTHQUAKE = dto.SEARTHQUAKE,
            NMAXRETAMOUNT = dto.NMAXRETAMOUNT,
        };
    }

    public static void UpdateEntity(this RETENTIONCOV entity, UpdateRETENTIONCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRETENTION = dto.NRETENTION;
        entity.SROUTINE = dto.SROUTINE;
        entity.NCOVPROPOR = dto.NCOVPROPOR;
        entity.NCOMBLIM = dto.NCOMBLIM;
        entity.NCOVERCL = dto.NCOVERCL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SEARTHQUAKE = dto.SEARTHQUAKE;
        entity.NMAXRETAMOUNT = dto.NMAXRETAMOUNT;
    }
}
