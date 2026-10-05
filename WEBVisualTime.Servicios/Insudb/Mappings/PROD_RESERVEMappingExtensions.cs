using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_RESERVE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROD_RESERVEMappingExtensions
{
    public static PROD_RESERVEDto ToDto(this PROD_RESERVE entity)
    {
        if (entity == null) return null!;
        return new PROD_RESERVEDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NTYPE_RESERVE = entity.NTYPE_RESERVE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            SROURESER = entity.SROURESER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NPERCRESER = entity.NPERCRESER,
            NRESEAMO = entity.NRESEAMO,
            NMAXPERCENT = entity.NMAXPERCENT,
            SROUTINECOST = entity.SROUTINECOST,
            SMORTALCO = entity.SMORTALCO,
        };
    }

    public static PROD_RESERVE ToEntity(this CreatePROD_RESERVEDto dto)
    {
        if (dto == null) return null!;
        return new PROD_RESERVE
        {
            DNULLDATE = dto.DNULLDATE,
            SROURESER = dto.SROURESER,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NPERCRESER = dto.NPERCRESER,
            NRESEAMO = dto.NRESEAMO,
            NMAXPERCENT = dto.NMAXPERCENT,
            SROUTINECOST = dto.SROUTINECOST,
            SMORTALCO = dto.SMORTALCO,
        };
    }

    public static void UpdateEntity(this PROD_RESERVE entity, UpdatePROD_RESERVEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SROURESER = dto.SROURESER;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPERCRESER = dto.NPERCRESER;
        entity.NRESEAMO = dto.NRESEAMO;
        entity.NMAXPERCENT = dto.NMAXPERCENT;
        entity.SROUTINECOST = dto.SROUTINECOST;
        entity.SMORTALCO = dto.SMORTALCO;
    }
}
