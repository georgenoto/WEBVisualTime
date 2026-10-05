using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVERMA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CL_COVERMAMappingExtensions
{
    public static CL_COVERMADto ToDto(this CL_COVERMA entity)
    {
        if (entity == null) return null!;
        return new CL_COVERMADto
        {
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCONCEPT = entity.NCONCEPT,
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            NDED_AMOUNT = entity.NDED_AMOUNT,
            NQUANT_USED = entity.NQUANT_USED,
            NRESERVE = entity.NRESERVE,
            NUNIT_COST = entity.NUNIT_COST,
            NUSERCODE = entity.NUSERCODE,
            SBUDGET = entity.SBUDGET,
            DDATE_BUD = entity.DDATE_BUD,
            NBILL_CON = entity.NBILL_CON,
            SBILL = entity.SBILL,
            DSTATRDAT = entity.DSTATRDAT,
            DPAYDATE = entity.DPAYDATE,
            DCANCELDAT = entity.DCANCELDAT,
            NEXCHANGE = entity.NEXCHANGE,
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            NPROVIDER = entity.NPROVIDER,
            NEVALSTAT = entity.NEVALSTAT,
        };
    }

    public static CL_COVERMA ToEntity(this CreateCL_COVERMADto dto)
    {
        if (dto == null) return null!;
        return new CL_COVERMA
        {
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NDED_AMOUNT = dto.NDED_AMOUNT,
            NQUANT_USED = dto.NQUANT_USED,
            NRESERVE = dto.NRESERVE,
            NUNIT_COST = dto.NUNIT_COST,
            NUSERCODE = dto.NUSERCODE,
            SBUDGET = dto.SBUDGET,
            DDATE_BUD = dto.DDATE_BUD,
            NBILL_CON = dto.NBILL_CON,
            SBILL = dto.SBILL,
            DSTATRDAT = dto.DSTATRDAT,
            DPAYDATE = dto.DPAYDATE,
            DCANCELDAT = dto.DCANCELDAT,
            NEXCHANGE = dto.NEXCHANGE,
            NPROVIDER = dto.NPROVIDER,
            NEVALSTAT = dto.NEVALSTAT,
        };
    }

    public static void UpdateEntity(this CL_COVERMA entity, UpdateCL_COVERMADto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NDED_AMOUNT = dto.NDED_AMOUNT;
        entity.NQUANT_USED = dto.NQUANT_USED;
        entity.NRESERVE = dto.NRESERVE;
        entity.NUNIT_COST = dto.NUNIT_COST;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SBUDGET = dto.SBUDGET;
        entity.DDATE_BUD = dto.DDATE_BUD;
        entity.NBILL_CON = dto.NBILL_CON;
        entity.SBILL = dto.SBILL;
        entity.DSTATRDAT = dto.DSTATRDAT;
        entity.DPAYDATE = dto.DPAYDATE;
        entity.DCANCELDAT = dto.DCANCELDAT;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NEVALSTAT = dto.NEVALSTAT;
    }
}
