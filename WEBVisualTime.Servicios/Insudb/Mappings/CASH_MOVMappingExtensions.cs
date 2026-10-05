using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_MOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CASH_MOVMappingExtensions
{
    public static CASH_MOVDto ToDto(this CASH_MOV entity)
    {
        if (entity == null) return null!;
        return new CASH_MOVDto
        {
            NACC_CASH = entity.NACC_CASH,
            CASH_ACCNACC_CASHSSTATREGT = entity.CASH_ACCNACC_CASH?.SSTATREGT,
            NOFFICE = entity.NOFFICE,
            CASH_ACCNOFFICESSTATREGT = entity.CASH_ACCNOFFICE?.SSTATREGT,
            NCURRENCY = entity.NCURRENCY,
            CASH_ACCNCURRENCYSSTATREGT = entity.CASH_ACCNCURRENCY?.SSTATREGT,
            NTRANSAC = entity.NTRANSAC,
            NCASHNUM = entity.NCASHNUM,
            CASH_ACCNCASHNUMSSTATREGT = entity.CASH_ACCNCASHNUM?.SSTATREGT,
            DEFFECDATE = entity.DEFFECDATE,
            NAMOUNT = entity.NAMOUNT,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCONCEPT = entity.NCONCEPT,
            TABLE22SDESCRIPT = entity.TABLE22?.SDESCRIPT,
            NACC_BANK = entity.NACC_BANK,
            BANK_ACCSACC_LEDGER = entity.BANK_ACC?.SACC_LEDGER,
            NCARD_TYPE = entity.NCARD_TYPE,
            TABLE183SDESCRIPT = entity.TABLE183?.SDESCRIPT,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7NBANK_CODESDESCRIPT = entity.TABLE7NBANK_CODE?.SDESCRIPT,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            DCARD_EXPIR = entity.DCARD_EXPIR,
            SCARD_NUM = entity.SCARD_NUM,
            NCL_TRANSAC = entity.NCL_TRANSAC,
            NCOMPANYC = entity.NCOMPANYC,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NVOUCHER = entity.NVOUCHER,
            NCONTRAT = entity.NCONTRAT,
            FINANC_DRANCONTRATSINDCHEQUE = entity.FINANC_DRANCONTRAT?.SINDCHEQUE,
            SDEP_NUMBER = entity.SDEP_NUMBER,
            DDOC_DATE = entity.DDOC_DATE,
            SDOCNUMBE = entity.SDOCNUMBE,
            NDRAFT = entity.NDRAFT,
            FINANC_DRANDRAFTSINDCHEQUE = entity.FINANC_DRANDRAFT?.SINDCHEQUE,
            NEXCHANGE = entity.NEXCHANGE,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NMOV_TYPE = entity.NMOV_TYPE,
            TABLE78SDESCRIPT = entity.TABLE78?.SDESCRIPT,
            SNULL_MOVEM = entity.SNULL_MOVEM,
            SNULL_RECOR = entity.SNULL_RECOR,
            DNULLDATE = entity.DNULLDATE,
            NPAYNUMBE = entity.NPAYNUMBE,
            NRECEIPT = entity.NRECEIPT,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NTYP_ACCO = entity.NTYP_ACCO,
            TABLE400SDESCRIPT = entity.TABLE400?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSCLIENTSACCOUNT_IN = entity.CLIENTSCLIENT?.SACCOUNT_IN,
            SNUMFORM = entity.SNUMFORM,
            SINTER_PAY = entity.SINTER_PAY,
            CLIENTSINTER_PAYSACCOUNT_IN = entity.CLIENTSINTER_PAY?.SACCOUNT_IN,
            STYPE_ACC = entity.STYPE_ACC,
            SDESCRIPT = entity.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DLEDGER_DAT = entity.DLEDGER_DAT,
            NUSER_SOL = entity.NUSER_SOL,
            NCHEQUELOCAT = entity.NCHEQUELOCAT,
            TABLE5553SDESCRIPT = entity.TABLE5553?.SDESCRIPT,
            NCOMPANY = entity.NCOMPANY,
            SPROCESS = entity.SPROCESS,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            DPOSTED = entity.DPOSTED,
            NCOD_AGREE = entity.NCOD_AGREE,
            AGREEMENTSSTATREGT = entity.AGREEMENT?.SSTATREGT,
            NINPUTCHANNEL = entity.NINPUTCHANNEL,
            TABLE5554SDESCRIPT = entity.TABLE5554?.SDESCRIPT,
            DVALDATE = entity.DVALDATE,
            SR_DEPNUM = entity.SR_DEPNUM,
            NORI_CURR = entity.NORI_CURR,
            NORI_AMOUNT = entity.NORI_AMOUNT,
            NSUPPORT_ID = entity.NSUPPORT_ID,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            DCOLLECTION = entity.DCOLLECTION,
            NCHEQUE_STAT = entity.NCHEQUE_STAT,
            TABLE5576SDESCRIPT = entity.TABLE5576?.SDESCRIPT,
            NCASH_ID = entity.NCASH_ID,
            NFIN_INT = entity.NFIN_INT,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NBANK_AGREE = entity.NBANK_AGREE,
            TABLE7NBANK_AGREESDESCRIPT = entity.TABLE7NBANK_AGREE?.SDESCRIPT,
            NPROPONUM = entity.NPROPONUM,
            NBULLETINS = entity.NBULLETINS,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASENCASE_NUMSSTACASE = entity.CLAIM_CASENCASE_NUM?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_CASENDEMAN_TYPESSTACASE = entity.CLAIM_CASENDEMAN_TYPE?.SSTACASE,
            NID = entity.NID,
            NBORDERUSED = entity.NBORDERUSED,
            NAMOUNTDEC = entity.NAMOUNTDEC,
        };
    }

    public static CASH_MOV ToEntity(this CreateCASH_MOVDto dto)
    {
        if (dto == null) return null!;
        return new CASH_MOV
        {
            NAMOUNT = dto.NAMOUNT,
            NCLAIM = dto.NCLAIM,
            NCONCEPT = dto.NCONCEPT,
            NACC_BANK = dto.NACC_BANK,
            NCARD_TYPE = dto.NCARD_TYPE,
            NBANK_CODE = dto.NBANK_CODE,
            NBRANCH_LED = dto.NBRANCH_LED,
            DCARD_EXPIR = dto.DCARD_EXPIR,
            SCARD_NUM = dto.SCARD_NUM,
            NCL_TRANSAC = dto.NCL_TRANSAC,
            NCOMPANYC = dto.NCOMPANYC,
            DCOMPDATE = dto.DCOMPDATE,
            NVOUCHER_LE = dto.NVOUCHER_LE,
            NVOUCHER = dto.NVOUCHER,
            NCONTRAT = dto.NCONTRAT,
            SDEP_NUMBER = dto.SDEP_NUMBER,
            DDOC_DATE = dto.DDOC_DATE,
            SDOCNUMBE = dto.SDOCNUMBE,
            NDRAFT = dto.NDRAFT,
            NEXCHANGE = dto.NEXCHANGE,
            NINTERMED = dto.NINTERMED,
            NMOV_TYPE = dto.NMOV_TYPE,
            SNULL_MOVEM = dto.SNULL_MOVEM,
            SNULL_RECOR = dto.SNULL_RECOR,
            DNULLDATE = dto.DNULLDATE,
            NPAYNUMBE = dto.NPAYNUMBE,
            NRECEIPT = dto.NRECEIPT,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            NBORDEREAUX = dto.NBORDEREAUX,
            NTYP_ACCO = dto.NTYP_ACCO,
            SCLIENT = dto.SCLIENT,
            SNUMFORM = dto.SNUMFORM,
            SINTER_PAY = dto.SINTER_PAY,
            STYPE_ACC = dto.STYPE_ACC,
            SDESCRIPT = dto.SDESCRIPT,
            NNOTENUM = dto.NNOTENUM,
            DLEDGER_DAT = dto.DLEDGER_DAT,
            NUSER_SOL = dto.NUSER_SOL,
            NCHEQUELOCAT = dto.NCHEQUELOCAT,
            NCOMPANY = dto.NCOMPANY,
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
            NTYPESUPPORT = dto.NTYPESUPPORT,
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
            NID = dto.NID,
            NBORDERUSED = dto.NBORDERUSED,
            NAMOUNTDEC = dto.NAMOUNTDEC,
        };
    }

    public static void UpdateEntity(this CASH_MOV entity, UpdateCASH_MOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NCARD_TYPE = dto.NCARD_TYPE;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.DCARD_EXPIR = dto.DCARD_EXPIR;
        entity.SCARD_NUM = dto.SCARD_NUM;
        entity.NCL_TRANSAC = dto.NCL_TRANSAC;
        entity.NCOMPANYC = dto.NCOMPANYC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NVOUCHER_LE = dto.NVOUCHER_LE;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.SDEP_NUMBER = dto.SDEP_NUMBER;
        entity.DDOC_DATE = dto.DDOC_DATE;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.NDRAFT = dto.NDRAFT;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NINTERMED = dto.NINTERMED;
        entity.NMOV_TYPE = dto.NMOV_TYPE;
        entity.SNULL_MOVEM = dto.SNULL_MOVEM;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.SCLIENT = dto.SCLIENT;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.SINTER_PAY = dto.SINTER_PAY;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DLEDGER_DAT = dto.DLEDGER_DAT;
        entity.NUSER_SOL = dto.NUSER_SOL;
        entity.NCHEQUELOCAT = dto.NCHEQUELOCAT;
        entity.NCOMPANY = dto.NCOMPANY;
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
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
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
        entity.NID = dto.NID;
        entity.NBORDERUSED = dto.NBORDERUSED;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
    }
}
