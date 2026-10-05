using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CASH_MOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_CASH_MOVMappingExtensions
{
    public static T_CASH_MOVDto ToDto(this T_CASH_MOV entity)
    {
        if (entity == null) return null!;
        return new T_CASH_MOVDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NSEQUENCE = entity.NSEQUENCE,
            NACC_CASH = entity.NACC_CASH,
            NLOCAL = entity.NLOCAL,
            TAB_LOCATSDESCRIPT = entity.TAB_LOCAT?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            NAMOUNT = entity.NAMOUNT,
            SCARD_NUM = entity.SCARD_NUM,
            NCARD_TYP = entity.NCARD_TYP,
            DDOC_DATE = entity.DDOC_DATE,
            SDOCNUMBE = entity.SDOCNUMBE,
            NEXCHANGE = entity.NEXCHANGE,
            NMOV_TYPE = entity.NMOV_TYPE,
            NBANK_CODE = entity.NBANK_CODE,
            NCOMPANY = entity.NCOMPANY,
            NTRANSAC = entity.NTRANSAC,
            NCHEQUELOCAT = entity.NCHEQUELOCAT,
            NCASH_NUM = entity.NCASH_NUM,
            NOFFICE = entity.NOFFICE,
            NCASHNUM = entity.NCASHNUM,
            DEFFECDATE = entity.DEFFECDATE,
            NCLAIM = entity.NCLAIM,
            NCONCEPT = entity.NCONCEPT,
            NACC_BANK = entity.NACC_BANK,
            NCARD_TYPE = entity.NCARD_TYPE,
            NBRANCH_LED = entity.NBRANCH_LED,
            DCARD_EXPIR = entity.DCARD_EXPIR,
            NCL_TRANSAC = entity.NCL_TRANSAC,
            NCOMPANYC = entity.NCOMPANYC,
            DCOMPDATE = entity.DCOMPDATE,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NVOUCHER = entity.NVOUCHER,
            NCONTRAT = entity.NCONTRAT,
            SDEP_NUMBER = entity.SDEP_NUMBER,
            NDRAFT = entity.NDRAFT,
            NINTERMED = entity.NINTERMED,
            SNULL_MOVEM = entity.SNULL_MOVEM,
            SNULL_RECOR = entity.SNULL_RECOR,
            DNULLDATE = entity.DNULLDATE,
            NPAYNUMBE = entity.NPAYNUMBE,
            NRECEIPT = entity.NRECEIPT,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            NTYP_ACCO = entity.NTYP_ACCO,
            SCLIENT = entity.SCLIENT,
            SNUMFORM = entity.SNUMFORM,
            SINTER_PAY = entity.SINTER_PAY,
            STYPE_ACC = entity.STYPE_ACC,
            SDESCRIPT = entity.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DLEDGER_DAT = entity.DLEDGER_DAT,
            NUSER_SQL = entity.NUSER_SQL,
            SPROCESS = entity.SPROCESS,
            NINSUR_AREA = entity.NINSUR_AREA,
            DPOSTED = entity.DPOSTED,
            NCOD_AGREE = entity.NCOD_AGREE,
            NINPUTCHANNEL = entity.NINPUTCHANNEL,
            DVALDATE = entity.DVALDATE,
            SR_DEPNUM = entity.SR_DEPNUM,
            NORI_CURR = entity.NORI_CURR,
            NORI_AMOUNT = entity.NORI_AMOUNT,
            NSUPPORT_ID = entity.NSUPPORT_ID,
            NTYPESSUPORT = entity.NTYPESSUPORT,
            DCOLLECTION = entity.DCOLLECTION,
            NCHEQUE_STAT = entity.NCHEQUE_STAT,
            NCASH_ID = entity.NCASH_ID,
            NFIN_INT = entity.NFIN_INT,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NBANK_AGREE = entity.NBANK_AGREE,
            NPROPONUM = entity.NPROPONUM,
            NBULLETINS = entity.NBULLETINS,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            SACTION = entity.SACTION,
            NAMOUNTDEC = entity.NAMOUNTDEC,
        };
    }

    public static T_CASH_MOV ToEntity(this CreateT_CASH_MOVDto dto)
    {
        if (dto == null) return null!;
        return new T_CASH_MOV
        {
            NACC_CASH = dto.NACC_CASH,
            NLOCAL = dto.NLOCAL,
            NCURRENCY = dto.NCURRENCY,
            NAMOUNT = dto.NAMOUNT,
            SCARD_NUM = dto.SCARD_NUM,
            NCARD_TYP = dto.NCARD_TYP,
            DDOC_DATE = dto.DDOC_DATE,
            SDOCNUMBE = dto.SDOCNUMBE,
            NEXCHANGE = dto.NEXCHANGE,
            NMOV_TYPE = dto.NMOV_TYPE,
            NBANK_CODE = dto.NBANK_CODE,
            NCOMPANY = dto.NCOMPANY,
            NTRANSAC = dto.NTRANSAC,
            NCHEQUELOCAT = dto.NCHEQUELOCAT,
            NCASH_NUM = dto.NCASH_NUM,
            NOFFICE = dto.NOFFICE,
            NCASHNUM = dto.NCASHNUM,
            DEFFECDATE = dto.DEFFECDATE,
            NCLAIM = dto.NCLAIM,
            NCONCEPT = dto.NCONCEPT,
            NACC_BANK = dto.NACC_BANK,
            NCARD_TYPE = dto.NCARD_TYPE,
            NBRANCH_LED = dto.NBRANCH_LED,
            DCARD_EXPIR = dto.DCARD_EXPIR,
            NCL_TRANSAC = dto.NCL_TRANSAC,
            NCOMPANYC = dto.NCOMPANYC,
            DCOMPDATE = dto.DCOMPDATE,
            NVOUCHER_LE = dto.NVOUCHER_LE,
            NVOUCHER = dto.NVOUCHER,
            NCONTRAT = dto.NCONTRAT,
            SDEP_NUMBER = dto.SDEP_NUMBER,
            NDRAFT = dto.NDRAFT,
            NINTERMED = dto.NINTERMED,
            SNULL_MOVEM = dto.SNULL_MOVEM,
            SNULL_RECOR = dto.SNULL_RECOR,
            DNULLDATE = dto.DNULLDATE,
            NPAYNUMBE = dto.NPAYNUMBE,
            NRECEIPT = dto.NRECEIPT,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            NTYP_ACCO = dto.NTYP_ACCO,
            SCLIENT = dto.SCLIENT,
            SNUMFORM = dto.SNUMFORM,
            SINTER_PAY = dto.SINTER_PAY,
            STYPE_ACC = dto.STYPE_ACC,
            SDESCRIPT = dto.SDESCRIPT,
            NNOTENUM = dto.NNOTENUM,
            DLEDGER_DAT = dto.DLEDGER_DAT,
            NUSER_SQL = dto.NUSER_SQL,
            SPROCESS = dto.SPROCESS,
            NINSUR_AREA = dto.NINSUR_AREA,
            DPOSTED = dto.DPOSTED,
            NCOD_AGREE = dto.NCOD_AGREE,
            NINPUTCHANNEL = dto.NINPUTCHANNEL,
            DVALDATE = dto.DVALDATE,
            SR_DEPNUM = dto.SR_DEPNUM,
            NORI_CURR = dto.NORI_CURR,
            NORI_AMOUNT = dto.NORI_AMOUNT,
            NSUPPORT_ID = dto.NSUPPORT_ID,
            NTYPESSUPORT = dto.NTYPESSUPORT,
            DCOLLECTION = dto.DCOLLECTION,
            NCHEQUE_STAT = dto.NCHEQUE_STAT,
            NCASH_ID = dto.NCASH_ID,
            NFIN_INT = dto.NFIN_INT,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NBANK_AGREE = dto.NBANK_AGREE,
            NPROPONUM = dto.NPROPONUM,
            NBULLETINS = dto.NBULLETINS,
            NCASE_NUM = dto.NCASE_NUM,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            SACTION = dto.SACTION,
            NAMOUNTDEC = dto.NAMOUNTDEC,
        };
    }

    public static void UpdateEntity(this T_CASH_MOV entity, UpdateT_CASH_MOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACC_CASH = dto.NACC_CASH;
        entity.NLOCAL = dto.NLOCAL;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCARD_NUM = dto.SCARD_NUM;
        entity.NCARD_TYP = dto.NCARD_TYP;
        entity.DDOC_DATE = dto.DDOC_DATE;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NMOV_TYPE = dto.NMOV_TYPE;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NCHEQUELOCAT = dto.NCHEQUELOCAT;
        entity.NCASH_NUM = dto.NCASH_NUM;
        entity.NOFFICE = dto.NOFFICE;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NCARD_TYPE = dto.NCARD_TYPE;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.DCARD_EXPIR = dto.DCARD_EXPIR;
        entity.NCL_TRANSAC = dto.NCL_TRANSAC;
        entity.NCOMPANYC = dto.NCOMPANYC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NVOUCHER_LE = dto.NVOUCHER_LE;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.SDEP_NUMBER = dto.SDEP_NUMBER;
        entity.NDRAFT = dto.NDRAFT;
        entity.NINTERMED = dto.NINTERMED;
        entity.SNULL_MOVEM = dto.SNULL_MOVEM;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.SCLIENT = dto.SCLIENT;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.SINTER_PAY = dto.SINTER_PAY;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DLEDGER_DAT = dto.DLEDGER_DAT;
        entity.NUSER_SQL = dto.NUSER_SQL;
        entity.SPROCESS = dto.SPROCESS;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.DPOSTED = dto.DPOSTED;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NINPUTCHANNEL = dto.NINPUTCHANNEL;
        entity.DVALDATE = dto.DVALDATE;
        entity.SR_DEPNUM = dto.SR_DEPNUM;
        entity.NORI_CURR = dto.NORI_CURR;
        entity.NORI_AMOUNT = dto.NORI_AMOUNT;
        entity.NSUPPORT_ID = dto.NSUPPORT_ID;
        entity.NTYPESSUPORT = dto.NTYPESSUPORT;
        entity.DCOLLECTION = dto.DCOLLECTION;
        entity.NCHEQUE_STAT = dto.NCHEQUE_STAT;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.NFIN_INT = dto.NFIN_INT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NBANK_AGREE = dto.NBANK_AGREE;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.SACTION = dto.SACTION;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
    }
}
