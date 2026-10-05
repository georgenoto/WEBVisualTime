using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_PR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CESSION_PRMappingExtensions
{
    public static CESSION_PRDto ToDto(this CESSION_PR entity)
    {
        if (entity == null) return null!;
        return new CESSION_PRDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NCESSION_NU = entity.NCESSION_NU,
            NNUM_CESS = entity.NNUM_CESS,
            NNUMBER = entity.NNUMBER,
            CONTRPROCNNUMBERSCAP_NOM_RI = entity.CONTRPROCNNUMBER?.SCAP_NOM_RI,
            NID = entity.NID,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NCAPITAL = entity.NCAPITAL,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NCOMMISSION = entity.NCOMMISSION,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            NCONCEPT = entity.NCONCEPT,
            TABLE533SDESCRIPT = entity.TABLE533?.SDESCRIPT,
            DEXPIRDAT = entity.DEXPIRDAT,
            NINTER_RATE = entity.NINTER_RATE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NPREMIUM = entity.NPREMIUM,
            SPRINT_CE = entity.SPRINT_CE,
            NRESER_PREM = entity.NRESER_PREM,
            SRETENTION = entity.SRETENTION,
            NSHARE = entity.NSHARE,
            NTYPE_CESSI = entity.NTYPE_CESSI,
            NUSERCODE = entity.NUSERCODE,
            NEXPENSIV = entity.NEXPENSIV,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NGROUP_INSU = entity.NGROUP_INSU,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFD_CONTRPROC = entity.DEFD_CONTRPROC,
            CONTRPROCDEFD_CONTRPROCSCAP_NOM_RI = entity.CONTRPROCDEFD_CONTRPROC?.SCAP_NOM_RI,
            NYEARMONTH = entity.NYEARMONTH,
            NCAPCESS = entity.NCAPCESS,
            DSTARTDATE = entity.DSTARTDATE,
            NCESSPREM = entity.NCESSPREM,
            NCESSEXTRAPR = entity.NCESSEXTRAPR,
            NTYPE = entity.NTYPE,
            CONTRPROCNTYPESCAP_NOM_RI = entity.CONTRPROCNTYPE?.SCAP_NOM_RI,
            DEFFECDATE = entity.DEFFECDATE,
            NRECEIPT = entity.NRECEIPT,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
            NTRANSAC = entity.NTRANSAC,
            NRATE_TAR = entity.NRATE_TAR,
            NPREM_TAR = entity.NPREM_TAR,
            NINSUAGE = entity.NINSUAGE,
            SSMOKING = entity.SSMOKING,
            DBIRTHDATE = entity.DBIRTHDATE,
            SSEXCLIEN = entity.SSEXCLIEN,
            NTYPERISK = entity.NTYPERISK,
            NRESERVE = entity.NRESERVE,
            DSTART_PROC = entity.DSTART_PROC,
            DEND_PROC = entity.DEND_PROC,
            NTAXRATE = entity.NTAXRATE,
            NFACTOR = entity.NFACTOR,
            NRATE_FAC = entity.NRATE_FAC,
            NRATE_REA = entity.NRATE_REA,
            SEXTRAPREM = entity.SEXTRAPREM,
            DINIEXPR = entity.DINIEXPR,
            DENDEXPR = entity.DENDEXPR,
            NFACTOREXT = entity.NFACTOREXT,
            NCODEXTRA = entity.NCODEXTRA,
            NPOLYEAR = entity.NPOLYEAR,
            DPOSTED = entity.DPOSTED,
            SKEY = entity.SKEY,
            DCTB_DATE = entity.DCTB_DATE,
            SPOSTEDSEQUENCE = entity.SPOSTEDSEQUENCE,
            NBILLNUM = entity.NBILLNUM,
            SINDPROCESS = entity.SINDPROCESS,
            NCTA_X_PAGAR = entity.NCTA_X_PAGAR,
            NVALUE_BASERETENCOMM = entity.NVALUE_BASERETENCOMM,
            NVALUE_PREMCED = entity.NVALUE_PREMCED,
            NVALUE_RETENTAXPRE = entity.NVALUE_RETENTAXPRE,
            NVALUE_BASERETENPRECED = entity.NVALUE_BASERETENPRECED,
            NVALUE_RETENCOMM = entity.NVALUE_RETENCOMM,
            NCOMISSION_IVA = entity.NCOMISSION_IVA,
            NUN_PER_REM = entity.NUN_PER_REM,
            DLEDGERDAT = entity.DLEDGERDAT,
        };
    }

    public static CESSION_PR ToEntity(this CreateCESSION_PRDto dto)
    {
        if (dto == null) return null!;
        return new CESSION_PR
        {
            NNUM_CESS = dto.NNUM_CESS,
            NNUMBER = dto.NNUMBER,
            NBRANCH_REI = dto.NBRANCH_REI,
            NCOMPANY = dto.NCOMPANY,
            NCAPITAL = dto.NCAPITAL,
            NCOMMISSION = dto.NCOMMISSION,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NCONCEPT = dto.NCONCEPT,
            DEXPIRDAT = dto.DEXPIRDAT,
            NINTER_RATE = dto.NINTER_RATE,
            NPREMIUM = dto.NPREMIUM,
            SPRINT_CE = dto.SPRINT_CE,
            NRESER_PREM = dto.NRESER_PREM,
            SRETENTION = dto.SRETENTION,
            NSHARE = dto.NSHARE,
            NTYPE_CESSI = dto.NTYPE_CESSI,
            NUSERCODE = dto.NUSERCODE,
            NEXPENSIV = dto.NEXPENSIV,
            NBRANCH_LED = dto.NBRANCH_LED,
            NINSUR_AREA = dto.NINSUR_AREA,
            NGROUP_INSU = dto.NGROUP_INSU,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            SCLIENT = dto.SCLIENT,
            DEFD_CONTRPROC = dto.DEFD_CONTRPROC,
            NYEARMONTH = dto.NYEARMONTH,
            NCAPCESS = dto.NCAPCESS,
            DSTARTDATE = dto.DSTARTDATE,
            NCESSPREM = dto.NCESSPREM,
            NCESSEXTRAPR = dto.NCESSEXTRAPR,
            NTYPE = dto.NTYPE,
            DEFFECDATE = dto.DEFFECDATE,
            NRECEIPT = dto.NRECEIPT,
            NDIGIT = dto.NDIGIT,
            NPAYNUMBE = dto.NPAYNUMBE,
            NTRANSAC = dto.NTRANSAC,
            NRATE_TAR = dto.NRATE_TAR,
            NPREM_TAR = dto.NPREM_TAR,
            NINSUAGE = dto.NINSUAGE,
            SSMOKING = dto.SSMOKING,
            DBIRTHDATE = dto.DBIRTHDATE,
            SSEXCLIEN = dto.SSEXCLIEN,
            NTYPERISK = dto.NTYPERISK,
            NRESERVE = dto.NRESERVE,
            DSTART_PROC = dto.DSTART_PROC,
            DEND_PROC = dto.DEND_PROC,
            NTAXRATE = dto.NTAXRATE,
            NFACTOR = dto.NFACTOR,
            NRATE_FAC = dto.NRATE_FAC,
            NRATE_REA = dto.NRATE_REA,
            SEXTRAPREM = dto.SEXTRAPREM,
            DINIEXPR = dto.DINIEXPR,
            DENDEXPR = dto.DENDEXPR,
            NFACTOREXT = dto.NFACTOREXT,
            NCODEXTRA = dto.NCODEXTRA,
            NPOLYEAR = dto.NPOLYEAR,
            DPOSTED = dto.DPOSTED,
            SKEY = dto.SKEY,
            DCTB_DATE = dto.DCTB_DATE,
            SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE,
            NBILLNUM = dto.NBILLNUM,
            SINDPROCESS = dto.SINDPROCESS,
            NCTA_X_PAGAR = dto.NCTA_X_PAGAR,
            NVALUE_BASERETENCOMM = dto.NVALUE_BASERETENCOMM,
            NVALUE_PREMCED = dto.NVALUE_PREMCED,
            NVALUE_RETENTAXPRE = dto.NVALUE_RETENTAXPRE,
            NVALUE_BASERETENPRECED = dto.NVALUE_BASERETENPRECED,
            NVALUE_RETENCOMM = dto.NVALUE_RETENCOMM,
            NCOMISSION_IVA = dto.NCOMISSION_IVA,
            NUN_PER_REM = dto.NUN_PER_REM,
            DLEDGERDAT = dto.DLEDGERDAT,
        };
    }

    public static void UpdateEntity(this CESSION_PR entity, UpdateCESSION_PRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NNUM_CESS = dto.NNUM_CESS;
        entity.NNUMBER = dto.NNUMBER;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NINTER_RATE = dto.NINTER_RATE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.SPRINT_CE = dto.SPRINT_CE;
        entity.NRESER_PREM = dto.NRESER_PREM;
        entity.SRETENTION = dto.SRETENTION;
        entity.NSHARE = dto.NSHARE;
        entity.NTYPE_CESSI = dto.NTYPE_CESSI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NEXPENSIV = dto.NEXPENSIV;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NGROUP_INSU = dto.NGROUP_INSU;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.SCLIENT = dto.SCLIENT;
        entity.DEFD_CONTRPROC = dto.DEFD_CONTRPROC;
        entity.NYEARMONTH = dto.NYEARMONTH;
        entity.NCAPCESS = dto.NCAPCESS;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NCESSPREM = dto.NCESSPREM;
        entity.NCESSEXTRAPR = dto.NCESSEXTRAPR;
        entity.NTYPE = dto.NTYPE;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NDIGIT = dto.NDIGIT;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NRATE_TAR = dto.NRATE_TAR;
        entity.NPREM_TAR = dto.NPREM_TAR;
        entity.NINSUAGE = dto.NINSUAGE;
        entity.SSMOKING = dto.SSMOKING;
        entity.DBIRTHDATE = dto.DBIRTHDATE;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.NTYPERISK = dto.NTYPERISK;
        entity.NRESERVE = dto.NRESERVE;
        entity.DSTART_PROC = dto.DSTART_PROC;
        entity.DEND_PROC = dto.DEND_PROC;
        entity.NTAXRATE = dto.NTAXRATE;
        entity.NFACTOR = dto.NFACTOR;
        entity.NRATE_FAC = dto.NRATE_FAC;
        entity.NRATE_REA = dto.NRATE_REA;
        entity.SEXTRAPREM = dto.SEXTRAPREM;
        entity.DINIEXPR = dto.DINIEXPR;
        entity.DENDEXPR = dto.DENDEXPR;
        entity.NFACTOREXT = dto.NFACTOREXT;
        entity.NCODEXTRA = dto.NCODEXTRA;
        entity.NPOLYEAR = dto.NPOLYEAR;
        entity.DPOSTED = dto.DPOSTED;
        entity.SKEY = dto.SKEY;
        entity.DCTB_DATE = dto.DCTB_DATE;
        entity.SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SINDPROCESS = dto.SINDPROCESS;
        entity.NCTA_X_PAGAR = dto.NCTA_X_PAGAR;
        entity.NVALUE_BASERETENCOMM = dto.NVALUE_BASERETENCOMM;
        entity.NVALUE_PREMCED = dto.NVALUE_PREMCED;
        entity.NVALUE_RETENTAXPRE = dto.NVALUE_RETENTAXPRE;
        entity.NVALUE_BASERETENPRECED = dto.NVALUE_BASERETENPRECED;
        entity.NVALUE_RETENCOMM = dto.NVALUE_RETENCOMM;
        entity.NCOMISSION_IVA = dto.NCOMISSION_IVA;
        entity.NUN_PER_REM = dto.NUN_PER_REM;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
    }
}
