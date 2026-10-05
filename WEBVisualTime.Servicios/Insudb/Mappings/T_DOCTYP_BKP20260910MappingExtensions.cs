using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP_BKP20260910;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_DOCTYP_BKP20260910MappingExtensions
{
    public static T_DOCTYP_BKP20260910Dto ToDto(this T_DOCTYP_BKP20260910 entity)
    {
        if (entity == null) return null!;
        return new T_DOCTYP_BKP20260910Dto
        {
            SSEL = entity.SSEL,
            NBORDEREAUX = entity.NBORDEREAUX,
            NSEQUENCE = entity.NSEQUENCE,
            NCOLLECDOCTYP = entity.NCOLLECDOCTYP,
            NDOCUMENT = entity.NDOCUMENT,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NCONTRAT = entity.NCONTRAT,
            NDRAFT = entity.NDRAFT,
            SCLIENT = entity.SCLIENT,
            NBULLETINS = entity.NBULLETINS,
            NPROPONUM = entity.NPROPONUM,
            NTYPEMOVE = entity.NTYPEMOVE,
            DMOVDATE = entity.DMOVDATE,
            NTYPE = entity.NTYPE,
            NTRATYPEI = entity.NTRATYPEI,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            NAMOUNTCOL = entity.NAMOUNTCOL,
            NAMOUNTPAY = entity.NAMOUNTPAY,
            NPAYSOONDISC = entity.NPAYSOONDISC,
            NINTEREST_RATE = entity.NINTEREST_RATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            SMANAUTI = entity.SMANAUTI,
            NSTATUS_PRE = entity.NSTATUS_PRE,
            NCOMAMOU = entity.NCOMAMOU,
            NPARTICIP = entity.NPARTICIP,
            NPREMIUM = entity.NPREMIUM,
            NINTERMED = entity.NINTERMED,
            NUSERCODE = entity.NUSERCODE,
            NCASH_MOV = entity.NCASH_MOV,
            DPOSTED = entity.DPOSTED,
            STYPE_DETAI = entity.STYPE_DETAI,
            NCOMMI_RATE = entity.NCOMMI_RATE,
            NINTERTYP = entity.NINTERTYP,
            NRATE_DISC = entity.NRATE_DISC,
            NNOM_VALBON = entity.NNOM_VALBON,
            DISSUEDATBON = entity.DISSUEDATBON,
            DEXPIRDATBON = entity.DEXPIRDATBON,
            NTAX = entity.NTAX,
            NORIGIN = entity.NORIGIN,
            DDATE_ORIGIN = entity.DDATE_ORIGIN,
            NINSTITUTION = entity.NINSTITUTION,
            NCHANGESDAT = entity.NCHANGESDAT,
            DVALUEDATE = entity.DVALUEDATE,
            NCOLLECTOR = entity.NCOLLECTOR,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NLOANS = entity.NLOANS,
            NTYP_PROFITWORKER = entity.NTYP_PROFITWORKER,
            SNEWRECEIPT = entity.SNEWRECEIPT,
            NCOD_SAAPV = entity.NCOD_SAAPV,
            SFOLIONUMBER = entity.SFOLIONUMBER,
            SBILLADVANCE = entity.SBILLADVANCE,
            DLIMITDATE = entity.DLIMITDATE,
        };
    }

    public static T_DOCTYP_BKP20260910 ToEntity(this CreateT_DOCTYP_BKP20260910Dto dto)
    {
        if (dto == null) return null!;
        return new T_DOCTYP_BKP20260910
        {
            SSEL = dto.SSEL,
            NBORDEREAUX = dto.NBORDEREAUX,
            NSEQUENCE = dto.NSEQUENCE,
            NCOLLECDOCTYP = dto.NCOLLECDOCTYP,
            NDOCUMENT = dto.NDOCUMENT,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NCONTRAT = dto.NCONTRAT,
            NDRAFT = dto.NDRAFT,
            SCLIENT = dto.SCLIENT,
            NBULLETINS = dto.NBULLETINS,
            NPROPONUM = dto.NPROPONUM,
            NTYPEMOVE = dto.NTYPEMOVE,
            DMOVDATE = dto.DMOVDATE,
            NTYPE = dto.NTYPE,
            NTRATYPEI = dto.NTRATYPEI,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            NAMOUNTCOL = dto.NAMOUNTCOL,
            NAMOUNTPAY = dto.NAMOUNTPAY,
            NPAYSOONDISC = dto.NPAYSOONDISC,
            NINTEREST_RATE = dto.NINTEREST_RATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            SMANAUTI = dto.SMANAUTI,
            NSTATUS_PRE = dto.NSTATUS_PRE,
            NCOMAMOU = dto.NCOMAMOU,
            NPARTICIP = dto.NPARTICIP,
            NPREMIUM = dto.NPREMIUM,
            NINTERMED = dto.NINTERMED,
            NUSERCODE = dto.NUSERCODE,
            NCASH_MOV = dto.NCASH_MOV,
            DPOSTED = dto.DPOSTED,
            STYPE_DETAI = dto.STYPE_DETAI,
            NCOMMI_RATE = dto.NCOMMI_RATE,
            NINTERTYP = dto.NINTERTYP,
            NRATE_DISC = dto.NRATE_DISC,
            NNOM_VALBON = dto.NNOM_VALBON,
            DISSUEDATBON = dto.DISSUEDATBON,
            DEXPIRDATBON = dto.DEXPIRDATBON,
            NTAX = dto.NTAX,
            NORIGIN = dto.NORIGIN,
            DDATE_ORIGIN = dto.DDATE_ORIGIN,
            NINSTITUTION = dto.NINSTITUTION,
            NCHANGESDAT = dto.NCHANGESDAT,
            DVALUEDATE = dto.DVALUEDATE,
            NCOLLECTOR = dto.NCOLLECTOR,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NLOANS = dto.NLOANS,
            NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER,
            SNEWRECEIPT = dto.SNEWRECEIPT,
            NCOD_SAAPV = dto.NCOD_SAAPV,
            SFOLIONUMBER = dto.SFOLIONUMBER,
            SBILLADVANCE = dto.SBILLADVANCE,
            DLIMITDATE = dto.DLIMITDATE,
        };
    }

    public static void UpdateEntity(this T_DOCTYP_BKP20260910 entity, UpdateT_DOCTYP_BKP20260910Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSEL = dto.SSEL;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NSEQUENCE = dto.NSEQUENCE;
        entity.NCOLLECDOCTYP = dto.NCOLLECDOCTYP;
        entity.NDOCUMENT = dto.NDOCUMENT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NDRAFT = dto.NDRAFT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NTYPEMOVE = dto.NTYPEMOVE;
        entity.DMOVDATE = dto.DMOVDATE;
        entity.NTYPE = dto.NTYPE;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NAMOUNTCOL = dto.NAMOUNTCOL;
        entity.NAMOUNTPAY = dto.NAMOUNTPAY;
        entity.NPAYSOONDISC = dto.NPAYSOONDISC;
        entity.NINTEREST_RATE = dto.NINTEREST_RATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.SMANAUTI = dto.SMANAUTI;
        entity.NSTATUS_PRE = dto.NSTATUS_PRE;
        entity.NCOMAMOU = dto.NCOMAMOU;
        entity.NPARTICIP = dto.NPARTICIP;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NINTERMED = dto.NINTERMED;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCASH_MOV = dto.NCASH_MOV;
        entity.DPOSTED = dto.DPOSTED;
        entity.STYPE_DETAI = dto.STYPE_DETAI;
        entity.NCOMMI_RATE = dto.NCOMMI_RATE;
        entity.NINTERTYP = dto.NINTERTYP;
        entity.NRATE_DISC = dto.NRATE_DISC;
        entity.NNOM_VALBON = dto.NNOM_VALBON;
        entity.DISSUEDATBON = dto.DISSUEDATBON;
        entity.DEXPIRDATBON = dto.DEXPIRDATBON;
        entity.NTAX = dto.NTAX;
        entity.NORIGIN = dto.NORIGIN;
        entity.DDATE_ORIGIN = dto.DDATE_ORIGIN;
        entity.NINSTITUTION = dto.NINSTITUTION;
        entity.NCHANGESDAT = dto.NCHANGESDAT;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NLOANS = dto.NLOANS;
        entity.NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER;
        entity.SNEWRECEIPT = dto.SNEWRECEIPT;
        entity.NCOD_SAAPV = dto.NCOD_SAAPV;
        entity.SFOLIONUMBER = dto.SFOLIONUMBER;
        entity.SBILLADVANCE = dto.SBILLADVANCE;
        entity.DLIMITDATE = dto.DLIMITDATE;
    }
}
