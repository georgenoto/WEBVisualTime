using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COVERMappingExtensions
{
    public static COVERDto ToDto(this COVER entity)
    {
        if (entity == null) return null!;
        return new COVERDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NGROUP_INSU = entity.NGROUP_INSU,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            DEFFECDATE = entity.DEFFECDATE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NCAPITAL = entity.NCAPITAL,
            NCAPITALI = entity.NCAPITALI,
            SCHANGE = entity.SCHANGE,
            DCOMPDATE = entity.DCOMPDATE,
            SFRANDEDI = entity.SFRANDEDI,
            TABLE64SDESCRIPT = entity.TABLE64?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            NDISCOUNT = entity.NDISCOUNT,
            NFIXAMOUNT = entity.NFIXAMOUNT,
            NMAXAMOUNT = entity.NMAXAMOUNT,
            SFREE_PREMI = entity.SFREE_PREMI,
            NMINAMOUNT = entity.NMINAMOUNT,
            DNULLDATE = entity.DNULLDATE,
            NPREMIUM = entity.NPREMIUM,
            NRATE = entity.NRATE,
            NWAIT_QUAN = entity.NWAIT_QUAN,
            NRATECOVE = entity.NRATECOVE,
            NUSERCODE = entity.NUSERCODE,
            SWAIT_TYPE = entity.SWAIT_TYPE,
            TABLE52SDESCRIPT = entity.TABLE52?.SDESCRIPT,
            SFRANCAPL = entity.SFRANCAPL,
            TABLE33SDESCRIPT = entity.TABLE33?.SDESCRIPT,
            NDISC_AMOUN = entity.NDISC_AMOUN,
            NTYPDURINS = entity.NTYPDURINS,
            TABLE5589NTYPDURINSSDESCRIPT = entity.TABLE5589NTYPDURINS?.SDESCRIPT,
            NDURINSUR = entity.NDURINSUR,
            NAGEMININS = entity.NAGEMININS,
            NAGEMAXINS = entity.NAGEMAXINS,
            NAGEMAXPER = entity.NAGEMAXPER,
            NTYPDURPAY = entity.NTYPDURPAY,
            TABLE5589NTYPDURPAYSDESCRIPT = entity.TABLE5589NTYPDURPAY?.SDESCRIPT,
            NDURPAY = entity.NDURPAY,
            NCAUSEUPD = entity.NCAUSEUPD,
            TABLE5547SDESCRIPT = entity.TABLE5547?.SDESCRIPT,
            NCAPITAL_WAIT = entity.NCAPITAL_WAIT,
            NAGELIMIT = entity.NAGELIMIT,
            NAGE_PER = entity.NAGE_PER,
            DANIVERSARY = entity.DANIVERSARY,
            DSEEKTAR = entity.DSEEKTAR,
            DFER = entity.DFER,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NRETARIF = entity.NRETARIF,
            TABLE5559SDESCRIPT = entity.TABLE5559?.SDESCRIPT,
            NCAPITAL_O = entity.NCAPITAL_O,
            NPREMIUM_O = entity.NPREMIUM_O,
            NRATECOVE_O = entity.NRATECOVE_O,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NRECAMOUNT = entity.NRECAMOUNT,
            NDESCAMOUNT = entity.NDESCAMOUNT,
            NCOMMI_AN = entity.NCOMMI_AN,
            NRATECOVE_B = entity.NRATECOVE_B,
            NCAPITAL_REQ = entity.NCAPITAL_REQ,
            NRATECLA = entity.NRATECLA,
            NFIXAMOCLA = entity.NFIXAMOCLA,
            NMINAMOCLA = entity.NMINAMOCLA,
            NMAXAMOCLA = entity.NMAXAMOCLA,
            NDISCCLA = entity.NDISCCLA,
            NDISC_AMOCLA = entity.NDISC_AMOCLA,
            NFRANCDAYS = entity.NFRANCDAYS,
            NFREQMAXEVEN = entity.NFREQMAXEVEN,
            TABLE340SDESCRIPT = entity.TABLE340?.SDESCRIPT,
            SROUTMAX_EVEN = entity.SROUTMAX_EVEN,
            NFREQUEN = entity.NFREQUEN,
            NMAXEVEN_QUAN = entity.NMAXEVEN_QUAN,
            SREDUCCAPITAL = entity.SREDUCCAPITAL,
            NREDUCAPAGE = entity.NREDUCAPAGE,
            NAGELIMITCAP = entity.NAGELIMITCAP,
            NPERCCOAS = entity.NPERCCOAS,
            DFREE_PREM_IN = entity.DFREE_PREM_IN,
            DFREE_PREM_LIM = entity.DFREE_PREM_LIM,
            DANTIDATE = entity.DANTIDATE,
            NANTI_AMOUNT = entity.NANTI_AMOUNT,
            NCLAIMRAT = entity.NCLAIMRAT,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
            SCOVERCHANGE = entity.SCOVERCHANGE,
        };
    }

    public static COVER ToEntity(this CreateCOVERDto dto)
    {
        if (dto == null) return null!;
        return new COVER
        {
            NROLE = dto.NROLE,
            NCAPITAL = dto.NCAPITAL,
            NCAPITALI = dto.NCAPITALI,
            SCHANGE = dto.SCHANGE,
            DCOMPDATE = dto.DCOMPDATE,
            SFRANDEDI = dto.SFRANDEDI,
            NCURRENCY = dto.NCURRENCY,
            NDISCOUNT = dto.NDISCOUNT,
            NFIXAMOUNT = dto.NFIXAMOUNT,
            NMAXAMOUNT = dto.NMAXAMOUNT,
            SFREE_PREMI = dto.SFREE_PREMI,
            NMINAMOUNT = dto.NMINAMOUNT,
            DNULLDATE = dto.DNULLDATE,
            NPREMIUM = dto.NPREMIUM,
            NRATE = dto.NRATE,
            NWAIT_QUAN = dto.NWAIT_QUAN,
            NRATECOVE = dto.NRATECOVE,
            NUSERCODE = dto.NUSERCODE,
            SWAIT_TYPE = dto.SWAIT_TYPE,
            SFRANCAPL = dto.SFRANCAPL,
            NDISC_AMOUN = dto.NDISC_AMOUN,
            NTYPDURINS = dto.NTYPDURINS,
            NDURINSUR = dto.NDURINSUR,
            NAGEMININS = dto.NAGEMININS,
            NAGEMAXINS = dto.NAGEMAXINS,
            NAGEMAXPER = dto.NAGEMAXPER,
            NTYPDURPAY = dto.NTYPDURPAY,
            NDURPAY = dto.NDURPAY,
            NCAUSEUPD = dto.NCAUSEUPD,
            NCAPITAL_WAIT = dto.NCAPITAL_WAIT,
            NAGELIMIT = dto.NAGELIMIT,
            NAGE_PER = dto.NAGE_PER,
            DANIVERSARY = dto.DANIVERSARY,
            DSEEKTAR = dto.DSEEKTAR,
            DFER = dto.DFER,
            NBRANCH_REI = dto.NBRANCH_REI,
            NRETARIF = dto.NRETARIF,
            NCAPITAL_O = dto.NCAPITAL_O,
            NPREMIUM_O = dto.NPREMIUM_O,
            NRATECOVE_O = dto.NRATECOVE_O,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NRECAMOUNT = dto.NRECAMOUNT,
            NDESCAMOUNT = dto.NDESCAMOUNT,
            NCOMMI_AN = dto.NCOMMI_AN,
            NRATECOVE_B = dto.NRATECOVE_B,
            NCAPITAL_REQ = dto.NCAPITAL_REQ,
            NRATECLA = dto.NRATECLA,
            NFIXAMOCLA = dto.NFIXAMOCLA,
            NMINAMOCLA = dto.NMINAMOCLA,
            NMAXAMOCLA = dto.NMAXAMOCLA,
            NDISCCLA = dto.NDISCCLA,
            NDISC_AMOCLA = dto.NDISC_AMOCLA,
            NFRANCDAYS = dto.NFRANCDAYS,
            NFREQMAXEVEN = dto.NFREQMAXEVEN,
            SROUTMAX_EVEN = dto.SROUTMAX_EVEN,
            NFREQUEN = dto.NFREQUEN,
            NMAXEVEN_QUAN = dto.NMAXEVEN_QUAN,
            SREDUCCAPITAL = dto.SREDUCCAPITAL,
            NREDUCAPAGE = dto.NREDUCAPAGE,
            NAGELIMITCAP = dto.NAGELIMITCAP,
            NPERCCOAS = dto.NPERCCOAS,
            DFREE_PREM_IN = dto.DFREE_PREM_IN,
            DFREE_PREM_LIM = dto.DFREE_PREM_LIM,
            DANTIDATE = dto.DANTIDATE,
            NANTI_AMOUNT = dto.NANTI_AMOUNT,
            NCLAIMRAT = dto.NCLAIMRAT,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
            SCOVERCHANGE = dto.SCOVERCHANGE,
        };
    }

    public static void UpdateEntity(this COVER entity, UpdateCOVERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NROLE = dto.NROLE;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCAPITALI = dto.NCAPITALI;
        entity.SCHANGE = dto.SCHANGE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SFRANDEDI = dto.SFRANDEDI;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NDISCOUNT = dto.NDISCOUNT;
        entity.NFIXAMOUNT = dto.NFIXAMOUNT;
        entity.NMAXAMOUNT = dto.NMAXAMOUNT;
        entity.SFREE_PREMI = dto.SFREE_PREMI;
        entity.NMINAMOUNT = dto.NMINAMOUNT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NRATE = dto.NRATE;
        entity.NWAIT_QUAN = dto.NWAIT_QUAN;
        entity.NRATECOVE = dto.NRATECOVE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SWAIT_TYPE = dto.SWAIT_TYPE;
        entity.SFRANCAPL = dto.SFRANCAPL;
        entity.NDISC_AMOUN = dto.NDISC_AMOUN;
        entity.NTYPDURINS = dto.NTYPDURINS;
        entity.NDURINSUR = dto.NDURINSUR;
        entity.NAGEMININS = dto.NAGEMININS;
        entity.NAGEMAXINS = dto.NAGEMAXINS;
        entity.NAGEMAXPER = dto.NAGEMAXPER;
        entity.NTYPDURPAY = dto.NTYPDURPAY;
        entity.NDURPAY = dto.NDURPAY;
        entity.NCAUSEUPD = dto.NCAUSEUPD;
        entity.NCAPITAL_WAIT = dto.NCAPITAL_WAIT;
        entity.NAGELIMIT = dto.NAGELIMIT;
        entity.NAGE_PER = dto.NAGE_PER;
        entity.DANIVERSARY = dto.DANIVERSARY;
        entity.DSEEKTAR = dto.DSEEKTAR;
        entity.DFER = dto.DFER;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NRETARIF = dto.NRETARIF;
        entity.NCAPITAL_O = dto.NCAPITAL_O;
        entity.NPREMIUM_O = dto.NPREMIUM_O;
        entity.NRATECOVE_O = dto.NRATECOVE_O;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NRECAMOUNT = dto.NRECAMOUNT;
        entity.NDESCAMOUNT = dto.NDESCAMOUNT;
        entity.NCOMMI_AN = dto.NCOMMI_AN;
        entity.NRATECOVE_B = dto.NRATECOVE_B;
        entity.NCAPITAL_REQ = dto.NCAPITAL_REQ;
        entity.NRATECLA = dto.NRATECLA;
        entity.NFIXAMOCLA = dto.NFIXAMOCLA;
        entity.NMINAMOCLA = dto.NMINAMOCLA;
        entity.NMAXAMOCLA = dto.NMAXAMOCLA;
        entity.NDISCCLA = dto.NDISCCLA;
        entity.NDISC_AMOCLA = dto.NDISC_AMOCLA;
        entity.NFRANCDAYS = dto.NFRANCDAYS;
        entity.NFREQMAXEVEN = dto.NFREQMAXEVEN;
        entity.SROUTMAX_EVEN = dto.SROUTMAX_EVEN;
        entity.NFREQUEN = dto.NFREQUEN;
        entity.NMAXEVEN_QUAN = dto.NMAXEVEN_QUAN;
        entity.SREDUCCAPITAL = dto.SREDUCCAPITAL;
        entity.NREDUCAPAGE = dto.NREDUCAPAGE;
        entity.NAGELIMITCAP = dto.NAGELIMITCAP;
        entity.NPERCCOAS = dto.NPERCCOAS;
        entity.DFREE_PREM_IN = dto.DFREE_PREM_IN;
        entity.DFREE_PREM_LIM = dto.DFREE_PREM_LIM;
        entity.DANTIDATE = dto.DANTIDATE;
        entity.NANTI_AMOUNT = dto.NANTI_AMOUNT;
        entity.NCLAIMRAT = dto.NCLAIMRAT;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
        entity.SCOVERCHANGE = dto.SCOVERCHANGE;
    }
}
