using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_CO_G;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COVER_CO_GMappingExtensions
{
    public static COVER_CO_GDto ToDto(this COVER_CO_G entity)
    {
        if (entity == null) return null!;
        return new COVER_CO_GDto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NGROUP = entity.NGROUP,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            DEFFECDATE = entity.DEFFECDATE,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NCAPITAL = entity.NCAPITAL,
            SCHANGE = entity.SCHANGE,
            DCOMPDATE = entity.DCOMPDATE,
            SFRANDEDI = entity.SFRANDEDI,
            TABLE64SDESCRIPT = entity.TABLE64?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            NDISCOUNT = entity.NDISCOUNT,
            NFIXAMOUNT = entity.NFIXAMOUNT,
            NMAXAMOUNT = entity.NMAXAMOUNT,
            DNULLDATE = entity.DNULLDATE,
            NMINAMOUNT = entity.NMINAMOUNT,
            NWAIT_QUAN = entity.NWAIT_QUAN,
            SWAIT_TYPE = entity.SWAIT_TYPE,
            TABLE52SDESCRIPT = entity.TABLE52?.SDESCRIPT,
            NRATE = entity.NRATE,
            NUSERCODE = entity.NUSERCODE,
            SFRANCAPL = entity.SFRANCAPL,
            TABLE33SDESCRIPT = entity.TABLE33?.SDESCRIPT,
            NDISC_AMOUN = entity.NDISC_AMOUN,
            NTYPDURINS = entity.NTYPDURINS,
            TABLE5589NTYPDURINSSDESCRIPT = entity.TABLE5589NTYPDURINS?.SDESCRIPT,
            NDURINSUR = entity.NDURINSUR,
            NAGEMININSM = entity.NAGEMININSM,
            NAGEMAXINSM = entity.NAGEMAXINSM,
            NAGEMAXPERM = entity.NAGEMAXPERM,
            NAGEMININSF = entity.NAGEMININSF,
            NAGEMAXINSF = entity.NAGEMAXINSF,
            NAGEMAXPERF = entity.NAGEMAXPERF,
            NTYPDURPAY = entity.NTYPDURPAY,
            TABLE5589NTYPDURPAYSDESCRIPT = entity.TABLE5589NTYPDURPAY?.SDESCRIPT,
            NDURPAY = entity.NDURPAY,
            NRATECOVE = entity.NRATECOVE,
            NPREMIUM = entity.NPREMIUM,
            SDEFAULTI = entity.SDEFAULTI,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            SREQUIRED = entity.SREQUIRED,
            NRETARIF = entity.NRETARIF,
            TABLE5559SDESCRIPT = entity.TABLE5559?.SDESCRIPT,
            NCAPITAL_O = entity.NCAPITAL_O,
            NPREMIUM_O = entity.NPREMIUM_O,
            NRATECOVE_O = entity.NRATECOVE_O,
            NCAPITALTOT = entity.NCAPITALTOT,
            NCAPITALWAITTOT = entity.NCAPITALWAITTOT,
            NPREMIUMTOT = entity.NPREMIUMTOT,
            NRATEAVG_N = entity.NRATEAVG_N,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NRECAMOUNT = entity.NRECAMOUNT,
            NDESCAMOUNT = entity.NDESCAMOUNT,
            NCOMMI_AN = entity.NCOMMI_AN,
            NRATECOVE_B = entity.NRATECOVE_B,
            NCAPMAX = entity.NCAPMAX,
            NCAPMIN = entity.NCAPMIN,
            NPREMAX = entity.NPREMAX,
            NPREMIN = entity.NPREMIN,
            NTYP_AGEMINM = entity.NTYP_AGEMINM,
            NTYP_AGEMINF = entity.NTYP_AGEMINF,
            NPERCENT = entity.NPERCENT,
            NFREQMAXEVEN = entity.NFREQMAXEVEN,
            TABLE340SDESCRIPT = entity.TABLE340?.SDESCRIPT,
            NMAXEVEN_QUAN = entity.NMAXEVEN_QUAN,
            NFREQUEN = entity.NFREQUEN,
            SROUTMAX_EVEN = entity.SROUTMAX_EVEN,
            NMOVEMENT = entity.NMOVEMENT,
            NPREMIUM_CM = entity.NPREMIUM_CM,
            NPREMIUM_SM = entity.NPREMIUM_SM,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static COVER_CO_G ToEntity(this CreateCOVER_CO_GDto dto)
    {
        if (dto == null) return null!;
        return new COVER_CO_G
        {
            NCAPITAL = dto.NCAPITAL,
            SCHANGE = dto.SCHANGE,
            DCOMPDATE = dto.DCOMPDATE,
            SFRANDEDI = dto.SFRANDEDI,
            NCURRENCY = dto.NCURRENCY,
            NDISCOUNT = dto.NDISCOUNT,
            NFIXAMOUNT = dto.NFIXAMOUNT,
            NMAXAMOUNT = dto.NMAXAMOUNT,
            DNULLDATE = dto.DNULLDATE,
            NMINAMOUNT = dto.NMINAMOUNT,
            NWAIT_QUAN = dto.NWAIT_QUAN,
            SWAIT_TYPE = dto.SWAIT_TYPE,
            NRATE = dto.NRATE,
            NUSERCODE = dto.NUSERCODE,
            SFRANCAPL = dto.SFRANCAPL,
            NDISC_AMOUN = dto.NDISC_AMOUN,
            NTYPDURINS = dto.NTYPDURINS,
            NDURINSUR = dto.NDURINSUR,
            NAGEMININSM = dto.NAGEMININSM,
            NAGEMAXINSM = dto.NAGEMAXINSM,
            NAGEMAXPERM = dto.NAGEMAXPERM,
            NAGEMININSF = dto.NAGEMININSF,
            NAGEMAXINSF = dto.NAGEMAXINSF,
            NAGEMAXPERF = dto.NAGEMAXPERF,
            NTYPDURPAY = dto.NTYPDURPAY,
            NDURPAY = dto.NDURPAY,
            NRATECOVE = dto.NRATECOVE,
            NPREMIUM = dto.NPREMIUM,
            SDEFAULTI = dto.SDEFAULTI,
            NBRANCH_REI = dto.NBRANCH_REI,
            SREQUIRED = dto.SREQUIRED,
            NRETARIF = dto.NRETARIF,
            NCAPITAL_O = dto.NCAPITAL_O,
            NPREMIUM_O = dto.NPREMIUM_O,
            NRATECOVE_O = dto.NRATECOVE_O,
            NCAPITALTOT = dto.NCAPITALTOT,
            NCAPITALWAITTOT = dto.NCAPITALWAITTOT,
            NPREMIUMTOT = dto.NPREMIUMTOT,
            NRATEAVG_N = dto.NRATEAVG_N,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NRECAMOUNT = dto.NRECAMOUNT,
            NDESCAMOUNT = dto.NDESCAMOUNT,
            NCOMMI_AN = dto.NCOMMI_AN,
            NRATECOVE_B = dto.NRATECOVE_B,
            NCAPMAX = dto.NCAPMAX,
            NCAPMIN = dto.NCAPMIN,
            NPREMAX = dto.NPREMAX,
            NPREMIN = dto.NPREMIN,
            NTYP_AGEMINM = dto.NTYP_AGEMINM,
            NTYP_AGEMINF = dto.NTYP_AGEMINF,
            NPERCENT = dto.NPERCENT,
            NFREQMAXEVEN = dto.NFREQMAXEVEN,
            NMAXEVEN_QUAN = dto.NMAXEVEN_QUAN,
            NFREQUEN = dto.NFREQUEN,
            SROUTMAX_EVEN = dto.SROUTMAX_EVEN,
            NMOVEMENT = dto.NMOVEMENT,
            NPREMIUM_CM = dto.NPREMIUM_CM,
            NPREMIUM_SM = dto.NPREMIUM_SM,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this COVER_CO_G entity, UpdateCOVER_CO_GDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.SCHANGE = dto.SCHANGE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SFRANDEDI = dto.SFRANDEDI;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NDISCOUNT = dto.NDISCOUNT;
        entity.NFIXAMOUNT = dto.NFIXAMOUNT;
        entity.NMAXAMOUNT = dto.NMAXAMOUNT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NMINAMOUNT = dto.NMINAMOUNT;
        entity.NWAIT_QUAN = dto.NWAIT_QUAN;
        entity.SWAIT_TYPE = dto.SWAIT_TYPE;
        entity.NRATE = dto.NRATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SFRANCAPL = dto.SFRANCAPL;
        entity.NDISC_AMOUN = dto.NDISC_AMOUN;
        entity.NTYPDURINS = dto.NTYPDURINS;
        entity.NDURINSUR = dto.NDURINSUR;
        entity.NAGEMININSM = dto.NAGEMININSM;
        entity.NAGEMAXINSM = dto.NAGEMAXINSM;
        entity.NAGEMAXPERM = dto.NAGEMAXPERM;
        entity.NAGEMININSF = dto.NAGEMININSF;
        entity.NAGEMAXINSF = dto.NAGEMAXINSF;
        entity.NAGEMAXPERF = dto.NAGEMAXPERF;
        entity.NTYPDURPAY = dto.NTYPDURPAY;
        entity.NDURPAY = dto.NDURPAY;
        entity.NRATECOVE = dto.NRATECOVE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.SREQUIRED = dto.SREQUIRED;
        entity.NRETARIF = dto.NRETARIF;
        entity.NCAPITAL_O = dto.NCAPITAL_O;
        entity.NPREMIUM_O = dto.NPREMIUM_O;
        entity.NRATECOVE_O = dto.NRATECOVE_O;
        entity.NCAPITALTOT = dto.NCAPITALTOT;
        entity.NCAPITALWAITTOT = dto.NCAPITALWAITTOT;
        entity.NPREMIUMTOT = dto.NPREMIUMTOT;
        entity.NRATEAVG_N = dto.NRATEAVG_N;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NRECAMOUNT = dto.NRECAMOUNT;
        entity.NDESCAMOUNT = dto.NDESCAMOUNT;
        entity.NCOMMI_AN = dto.NCOMMI_AN;
        entity.NRATECOVE_B = dto.NRATECOVE_B;
        entity.NCAPMAX = dto.NCAPMAX;
        entity.NCAPMIN = dto.NCAPMIN;
        entity.NPREMAX = dto.NPREMAX;
        entity.NPREMIN = dto.NPREMIN;
        entity.NTYP_AGEMINM = dto.NTYP_AGEMINM;
        entity.NTYP_AGEMINF = dto.NTYP_AGEMINF;
        entity.NPERCENT = dto.NPERCENT;
        entity.NFREQMAXEVEN = dto.NFREQMAXEVEN;
        entity.NMAXEVEN_QUAN = dto.NMAXEVEN_QUAN;
        entity.NFREQUEN = dto.NFREQUEN;
        entity.SROUTMAX_EVEN = dto.SROUTMAX_EVEN;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NPREMIUM_CM = dto.NPREMIUM_CM;
        entity.NPREMIUM_SM = dto.NPREMIUM_SM;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
