using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_BKP_256518;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PREMIUM_BKP_256518MappingExtensions
{
    public static PREMIUM_BKP_256518Dto ToDto(this PREMIUM_BKP_256518 entity)
    {
        if (entity == null) return null!;
        return new PREMIUM_BKP_256518Dto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NRECEIPT = entity.NRECEIPT,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NPERIOD_OLD = entity.NPERIOD_OLD,
            NPERIOD_NEW = entity.NPERIOD_NEW,
            DFIX = entity.DFIX,
        };
    }

    public static PREMIUM_BKP_256518 ToEntity(this CreatePREMIUM_BKP_256518Dto dto)
    {
        if (dto == null) return null!;
        return new PREMIUM_BKP_256518
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NRECEIPT = dto.NRECEIPT,
            NDIGIT = dto.NDIGIT,
            NPAYNUMBE = dto.NPAYNUMBE,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NPERIOD_OLD = dto.NPERIOD_OLD,
            NPERIOD_NEW = dto.NPERIOD_NEW,
            DFIX = dto.DFIX,
        };
    }

    public static void UpdateEntity(this PREMIUM_BKP_256518 entity, UpdatePREMIUM_BKP_256518Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NDIGIT = dto.NDIGIT;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NPERIOD_OLD = dto.NPERIOD_OLD;
        entity.NPERIOD_NEW = dto.NPERIOD_NEW;
        entity.DFIX = dto.DFIX;
    }
}
