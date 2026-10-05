using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRELDOC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TRELDOCMappingExtensions
{
    public static TRELDOCDto ToDto(this TRELDOC entity)
    {
        if (entity == null) return null!;
        return new TRELDOCDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            NSEQUENCE = entity.NSEQUENCE,
            NCOLLECDOCTYP = entity.NCOLLECDOCTYP,
            NRECEIPT = entity.NRECEIPT,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NCONTRAT = entity.NCONTRAT,
            NDRAFT = entity.NDRAFT,
            NBULLETINS = entity.NBULLETINS,
            NPROPONUM = entity.NPROPONUM,
            NIDMOV = entity.NIDMOV,
            NAMOUNT = entity.NAMOUNT,
            NINTERESTAMOUNT = entity.NINTERESTAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            DCOMPDATE = entity.DCOMPDATE,
            DPAYDATE = entity.DPAYDATE,
            DVALUEDATE = entity.DVALUEDATE,
            NCHANGESDAT = entity.NCHANGESDAT,
            NORIGIN = entity.NORIGIN,
            DDATE_ORIGIN = entity.DDATE_ORIGIN,
            NINSTITUTION = entity.NINSTITUTION,
            NCOLLECTOR = entity.NCOLLECTOR,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NLOANS = entity.NLOANS,
            NINDREV = entity.NINDREV,
            NTYP_PROFITWORKER = entity.NTYP_PROFITWORKER,
            NAMOUNT_LOC = entity.NAMOUNT_LOC,
            NCOD_SAAPV = entity.NCOD_SAAPV,
            SFOLIONUMBER = entity.SFOLIONUMBER,
        };
    }

    public static TRELDOC ToEntity(this CreateTRELDOCDto dto)
    {
        if (dto == null) return null!;
        return new TRELDOC
        {
            NRECEIPT = dto.NRECEIPT,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NCONTRAT = dto.NCONTRAT,
            NDRAFT = dto.NDRAFT,
            NBULLETINS = dto.NBULLETINS,
            NPROPONUM = dto.NPROPONUM,
            NIDMOV = dto.NIDMOV,
            NAMOUNT = dto.NAMOUNT,
            NINTERESTAMOUNT = dto.NINTERESTAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            DCOMPDATE = dto.DCOMPDATE,
            DPAYDATE = dto.DPAYDATE,
            DVALUEDATE = dto.DVALUEDATE,
            NCHANGESDAT = dto.NCHANGESDAT,
            NORIGIN = dto.NORIGIN,
            DDATE_ORIGIN = dto.DDATE_ORIGIN,
            NINSTITUTION = dto.NINSTITUTION,
            NCOLLECTOR = dto.NCOLLECTOR,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NLOANS = dto.NLOANS,
            NINDREV = dto.NINDREV,
            NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER,
            NAMOUNT_LOC = dto.NAMOUNT_LOC,
            NCOD_SAAPV = dto.NCOD_SAAPV,
            SFOLIONUMBER = dto.SFOLIONUMBER,
        };
    }

    public static void UpdateEntity(this TRELDOC entity, UpdateTRELDOCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NDRAFT = dto.NDRAFT;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NIDMOV = dto.NIDMOV;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NINTERESTAMOUNT = dto.NINTERESTAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DPAYDATE = dto.DPAYDATE;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.NCHANGESDAT = dto.NCHANGESDAT;
        entity.NORIGIN = dto.NORIGIN;
        entity.DDATE_ORIGIN = dto.DDATE_ORIGIN;
        entity.NINSTITUTION = dto.NINSTITUTION;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NLOANS = dto.NLOANS;
        entity.NINDREV = dto.NINDREV;
        entity.NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER;
        entity.NAMOUNT_LOC = dto.NAMOUNT_LOC;
        entity.NCOD_SAAPV = dto.NCOD_SAAPV;
        entity.SFOLIONUMBER = dto.SFOLIONUMBER;
    }
}
