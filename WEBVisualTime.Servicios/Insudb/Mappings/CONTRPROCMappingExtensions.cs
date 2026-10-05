using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRPROC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTRPROCMappingExtensions
{
    public static CONTRPROCDto ToDto(this CONTRPROC entity)
    {
        if (entity == null) return null!;
        return new CONTRPROCDto
        {
            NNUMBER = entity.NNUMBER,
            CONTRMASTERNNUMBERSSTATREGT = entity.CONTRMASTERNNUMBER?.SSTATREGT,
            NBRANCH = entity.NBRANCH,
            CONTRMASTERNBRANCHSSTATREGT = entity.CONTRMASTERNBRANCH?.SSTATREGT,
            DEFFECDATE = entity.DEFFECDATE,
            NTYPE = entity.NTYPE,
            CONTRMASTERNTYPESSTATREGT = entity.CONTRMASTERNTYPE?.SSTATREGT,
            NAMOUNT = entity.NAMOUNT,
            NTYPE_REL = entity.NTYPE_REL,
            CONTRMASTERNTYPE_RELSSTATREGT = entity.CONTRMASTERNTYPE_REL?.SSTATREGT,
            NFQCY_ACC = entity.NFQCY_ACC,
            TABLE97SDESCRIPT = entity.TABLE97?.SDESCRIPT,
            SCAP_NOM_RI = entity.SCAP_NOM_RI,
            DCOMPDATE = entity.DCOMPDATE,
            NEXCESS = entity.NEXCESS,
            NEXPENSES = entity.NEXPENSES,
            NFACT_RESER = entity.NFACT_RESER,
            NFIXED_PRAT = entity.NFIXED_PRAT,
            NGROUP_BENE = entity.NGROUP_BENE,
            NGROUP_CO = entity.NGROUP_CO,
            NINT_CLAIM = entity.NINT_CLAIM,
            NINT_PREM = entity.NINT_PREM,
            NLINES = entity.NLINES,
            NMAX_EVEN = entity.NMAX_EVEN,
            DNULLDATE = entity.DNULLDATE,
            NPREM_DEP = entity.NPREM_DEP,
            NPROFIT_SH = entity.NPROFIT_SH,
            NQUOTA_SHA = entity.NQUOTA_SHA,
            NRATE_CLAIM = entity.NRATE_CLAIM,
            SRESER_CLAI = entity.SRESER_CLAI,
            NRETEN_MIN = entity.NRETEN_MIN,
            NTAB_COMMI = entity.NTAB_COMMI,
            STAB_LIMIT = entity.STAB_LIMIT,
            NTRAN_PREM = entity.NTRAN_PREM,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_BEGIN = entity.NYEAR_BEGIN,
            NYEAR_END = entity.NYEAR_END,
            SRETCOVER = entity.SRETCOVER,
            SLIMITCOV = entity.SLIMITCOV,
            SCESSPRCOV = entity.SCESSPRCOV,
            SEXTRAPREM = entity.SEXTRAPREM,
            SGENCESS = entity.SGENCESS,
            NRATE = entity.NRATE,
            NCESSPRFIX = entity.NCESSPRFIX,
            NMINCAPCESS = entity.NMINCAPCESS,
            NNEXTMONTHP = entity.NNEXTMONTHP,
            NNEXTYEARP = entity.NNEXTYEARP,
            NNEXTMONTHC = entity.NNEXTMONTHC,
            NNEXTYEARC = entity.NNEXTYEARC,
            SROUPROFIT = entity.SROUPROFIT,
            SCOMMCOV = entity.SCOMMCOV,
            NINTEREST = entity.NINTEREST,
            SCUMULTYP = entity.SCUMULTYP,
            TABLE79SDESCRIPT = entity.TABLE79?.SDESCRIPT,
            SCUMREINT = entity.SCUMREINT,
            TABLE90SDESCRIPT = entity.TABLE90?.SDESCRIPT,
            SCUMULPOL = entity.SCUMULPOL,
            NFREQPAY = entity.NFREQPAY,
            TABLE36SDESCRIPT = entity.TABLE36?.SDESCRIPT,
            NNEXTMONTHPA = entity.NNEXTMONTHPA,
            NNEXTYEARPA = entity.NNEXTYEARPA,
            SRETZONE = entity.SRETZONE,
            SCESSCIA = entity.SCESSCIA,
            NIND_AGE = entity.NIND_AGE,
            SROUCESS = entity.SROUCESS,
            NMAXRETAMOUNT = entity.NMAXRETAMOUNT,
            SDESCRIPT = entity.SDESCRIPT,
        };
    }

    public static CONTRPROC ToEntity(this CreateCONTRPROCDto dto)
    {
        if (dto == null) return null!;
        return new CONTRPROC
        {
            NAMOUNT = dto.NAMOUNT,
            NTYPE_REL = dto.NTYPE_REL,
            NFQCY_ACC = dto.NFQCY_ACC,
            SCAP_NOM_RI = dto.SCAP_NOM_RI,
            DCOMPDATE = dto.DCOMPDATE,
            NEXCESS = dto.NEXCESS,
            NEXPENSES = dto.NEXPENSES,
            NFACT_RESER = dto.NFACT_RESER,
            NFIXED_PRAT = dto.NFIXED_PRAT,
            NGROUP_BENE = dto.NGROUP_BENE,
            NGROUP_CO = dto.NGROUP_CO,
            NINT_CLAIM = dto.NINT_CLAIM,
            NINT_PREM = dto.NINT_PREM,
            NLINES = dto.NLINES,
            NMAX_EVEN = dto.NMAX_EVEN,
            DNULLDATE = dto.DNULLDATE,
            NPREM_DEP = dto.NPREM_DEP,
            NPROFIT_SH = dto.NPROFIT_SH,
            NQUOTA_SHA = dto.NQUOTA_SHA,
            NRATE_CLAIM = dto.NRATE_CLAIM,
            SRESER_CLAI = dto.SRESER_CLAI,
            NRETEN_MIN = dto.NRETEN_MIN,
            NTAB_COMMI = dto.NTAB_COMMI,
            STAB_LIMIT = dto.STAB_LIMIT,
            NTRAN_PREM = dto.NTRAN_PREM,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_BEGIN = dto.NYEAR_BEGIN,
            NYEAR_END = dto.NYEAR_END,
            SRETCOVER = dto.SRETCOVER,
            SLIMITCOV = dto.SLIMITCOV,
            SCESSPRCOV = dto.SCESSPRCOV,
            SEXTRAPREM = dto.SEXTRAPREM,
            SGENCESS = dto.SGENCESS,
            NRATE = dto.NRATE,
            NCESSPRFIX = dto.NCESSPRFIX,
            NMINCAPCESS = dto.NMINCAPCESS,
            NNEXTMONTHP = dto.NNEXTMONTHP,
            NNEXTYEARP = dto.NNEXTYEARP,
            NNEXTMONTHC = dto.NNEXTMONTHC,
            NNEXTYEARC = dto.NNEXTYEARC,
            SROUPROFIT = dto.SROUPROFIT,
            SCOMMCOV = dto.SCOMMCOV,
            NINTEREST = dto.NINTEREST,
            SCUMULTYP = dto.SCUMULTYP,
            SCUMREINT = dto.SCUMREINT,
            SCUMULPOL = dto.SCUMULPOL,
            NFREQPAY = dto.NFREQPAY,
            NNEXTMONTHPA = dto.NNEXTMONTHPA,
            NNEXTYEARPA = dto.NNEXTYEARPA,
            SRETZONE = dto.SRETZONE,
            SCESSCIA = dto.SCESSCIA,
            NIND_AGE = dto.NIND_AGE,
            SROUCESS = dto.SROUCESS,
            NMAXRETAMOUNT = dto.NMAXRETAMOUNT,
            SDESCRIPT = dto.SDESCRIPT,
        };
    }

    public static void UpdateEntity(this CONTRPROC entity, UpdateCONTRPROCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NTYPE_REL = dto.NTYPE_REL;
        entity.NFQCY_ACC = dto.NFQCY_ACC;
        entity.SCAP_NOM_RI = dto.SCAP_NOM_RI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NEXCESS = dto.NEXCESS;
        entity.NEXPENSES = dto.NEXPENSES;
        entity.NFACT_RESER = dto.NFACT_RESER;
        entity.NFIXED_PRAT = dto.NFIXED_PRAT;
        entity.NGROUP_BENE = dto.NGROUP_BENE;
        entity.NGROUP_CO = dto.NGROUP_CO;
        entity.NINT_CLAIM = dto.NINT_CLAIM;
        entity.NINT_PREM = dto.NINT_PREM;
        entity.NLINES = dto.NLINES;
        entity.NMAX_EVEN = dto.NMAX_EVEN;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPREM_DEP = dto.NPREM_DEP;
        entity.NPROFIT_SH = dto.NPROFIT_SH;
        entity.NQUOTA_SHA = dto.NQUOTA_SHA;
        entity.NRATE_CLAIM = dto.NRATE_CLAIM;
        entity.SRESER_CLAI = dto.SRESER_CLAI;
        entity.NRETEN_MIN = dto.NRETEN_MIN;
        entity.NTAB_COMMI = dto.NTAB_COMMI;
        entity.STAB_LIMIT = dto.STAB_LIMIT;
        entity.NTRAN_PREM = dto.NTRAN_PREM;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_BEGIN = dto.NYEAR_BEGIN;
        entity.NYEAR_END = dto.NYEAR_END;
        entity.SRETCOVER = dto.SRETCOVER;
        entity.SLIMITCOV = dto.SLIMITCOV;
        entity.SCESSPRCOV = dto.SCESSPRCOV;
        entity.SEXTRAPREM = dto.SEXTRAPREM;
        entity.SGENCESS = dto.SGENCESS;
        entity.NRATE = dto.NRATE;
        entity.NCESSPRFIX = dto.NCESSPRFIX;
        entity.NMINCAPCESS = dto.NMINCAPCESS;
        entity.NNEXTMONTHP = dto.NNEXTMONTHP;
        entity.NNEXTYEARP = dto.NNEXTYEARP;
        entity.NNEXTMONTHC = dto.NNEXTMONTHC;
        entity.NNEXTYEARC = dto.NNEXTYEARC;
        entity.SROUPROFIT = dto.SROUPROFIT;
        entity.SCOMMCOV = dto.SCOMMCOV;
        entity.NINTEREST = dto.NINTEREST;
        entity.SCUMULTYP = dto.SCUMULTYP;
        entity.SCUMREINT = dto.SCUMREINT;
        entity.SCUMULPOL = dto.SCUMULPOL;
        entity.NFREQPAY = dto.NFREQPAY;
        entity.NNEXTMONTHPA = dto.NNEXTMONTHPA;
        entity.NNEXTYEARPA = dto.NNEXTYEARPA;
        entity.SRETZONE = dto.SRETZONE;
        entity.SCESSCIA = dto.SCESSCIA;
        entity.NIND_AGE = dto.NIND_AGE;
        entity.SROUCESS = dto.SROUCESS;
        entity.NMAXRETAMOUNT = dto.NMAXRETAMOUNT;
        entity.SDESCRIPT = dto.SDESCRIPT;
    }
}
