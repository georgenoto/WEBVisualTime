using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_MOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_BANK_MOVMappingExtensions
{
    public static T_BANK_MOVDto ToDto(this T_BANK_MOV entity)
    {
        if (entity == null) return null!;
        return new T_BANK_MOVDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NSEQUENCE = entity.NSEQUENCE,
            NACC_BANK = entity.NACC_BANK,
            NAMOUNT = entity.NAMOUNT,
            DDOC_DATE = entity.DDOC_DATE,
            SDEP_NUMBER = entity.SDEP_NUMBER,
            NTYPE_MOV = entity.NTYPE_MOV,
            NMOVEMENT = entity.NMOVEMENT,
            SNULL_MOVEM = entity.SNULL_MOVEM,
            SNULL_RECOR = entity.SNULL_RECOR,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NCASH_AMOUN = entity.NCASH_AMOUN,
            NCHEQ_AMOUN = entity.NCHEQ_AMOUN,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            SDOCNUMBE = entity.SDOCNUMBE,
            NCONCEPT = entity.NCONCEPT,
            SCLIENT = entity.SCLIENT,
            NINTERMED = entity.NINTERMED,
            NUSERCODE = entity.NUSERCODE,
            SNUMFORM = entity.SNUMFORM,
            NCLAIM = entity.NCLAIM,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NCONTRAT = entity.NCONTRAT,
            NDRAFT = entity.NDRAFT,
            NCOMPANYC = entity.NCOMPANYC,
            NVOUCHER = entity.NVOUCHER,
            NTYP_ACCO = entity.NTYP_ACCO,
            STYPE_ACC = entity.STYPE_ACC,
            NCASHNUM = entity.NCASHNUM,
            DPOSTED = entity.DPOSTED,
            NNOTENUM = entity.NNOTENUM,
            NINSUR_AREA = entity.NINSUR_AREA,
            DCOLLECTION = entity.DCOLLECTION,
            NPROPONUM = entity.NPROPONUM,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            NORI_CURR = entity.NORI_CURR,
            NSUPPORT_ID = entity.NSUPPORT_ID,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            NCASH_ID = entity.NCASH_ID,
            NCOD_AGREE = entity.NCOD_AGREE,
            NBANK_AGREE = entity.NBANK_AGREE,
            NINPUTCHANNEL = entity.NINPUTCHANNEL,
            SACTION = entity.SACTION,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NORI_AMOUNT = entity.NORI_AMOUNT,
            DVALUEDATE = entity.DVALUEDATE,
        };
    }

    public static T_BANK_MOV ToEntity(this CreateT_BANK_MOVDto dto)
    {
        if (dto == null) return null!;
        return new T_BANK_MOV
        {
            NACC_BANK = dto.NACC_BANK,
            NAMOUNT = dto.NAMOUNT,
            DDOC_DATE = dto.DDOC_DATE,
            SDEP_NUMBER = dto.SDEP_NUMBER,
            NTYPE_MOV = dto.NTYPE_MOV,
            NMOVEMENT = dto.NMOVEMENT,
            SNULL_MOVEM = dto.SNULL_MOVEM,
            SNULL_RECOR = dto.SNULL_RECOR,
            DEFFECDATE = dto.DEFFECDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NCASH_AMOUN = dto.NCASH_AMOUN,
            NCHEQ_AMOUN = dto.NCHEQ_AMOUN,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            SDOCNUMBE = dto.SDOCNUMBE,
            NCONCEPT = dto.NCONCEPT,
            SCLIENT = dto.SCLIENT,
            NINTERMED = dto.NINTERMED,
            NUSERCODE = dto.NUSERCODE,
            SNUMFORM = dto.SNUMFORM,
            NCLAIM = dto.NCLAIM,
            NVOUCHER_LE = dto.NVOUCHER_LE,
            NCONTRAT = dto.NCONTRAT,
            NDRAFT = dto.NDRAFT,
            NCOMPANYC = dto.NCOMPANYC,
            NVOUCHER = dto.NVOUCHER,
            NTYP_ACCO = dto.NTYP_ACCO,
            STYPE_ACC = dto.STYPE_ACC,
            NCASHNUM = dto.NCASHNUM,
            DPOSTED = dto.DPOSTED,
            NNOTENUM = dto.NNOTENUM,
            NINSUR_AREA = dto.NINSUR_AREA,
            DCOLLECTION = dto.DCOLLECTION,
            NPROPONUM = dto.NPROPONUM,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            NORI_CURR = dto.NORI_CURR,
            NSUPPORT_ID = dto.NSUPPORT_ID,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NCASH_ID = dto.NCASH_ID,
            NCOD_AGREE = dto.NCOD_AGREE,
            NBANK_AGREE = dto.NBANK_AGREE,
            NINPUTCHANNEL = dto.NINPUTCHANNEL,
            SACTION = dto.SACTION,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NORI_AMOUNT = dto.NORI_AMOUNT,
            DVALUEDATE = dto.DVALUEDATE,
        };
    }

    public static void UpdateEntity(this T_BANK_MOV entity, UpdateT_BANK_MOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DDOC_DATE = dto.DDOC_DATE;
        entity.SDEP_NUMBER = dto.SDEP_NUMBER;
        entity.NTYPE_MOV = dto.NTYPE_MOV;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.SNULL_MOVEM = dto.SNULL_MOVEM;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCASH_AMOUN = dto.NCASH_AMOUN;
        entity.NCHEQ_AMOUN = dto.NCHEQ_AMOUN;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NINTERMED = dto.NINTERMED;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.NCLAIM = dto.NCLAIM;
        entity.NVOUCHER_LE = dto.NVOUCHER_LE;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NDRAFT = dto.NDRAFT;
        entity.NCOMPANYC = dto.NCOMPANYC;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.DPOSTED = dto.DPOSTED;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.DCOLLECTION = dto.DCOLLECTION;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NORI_CURR = dto.NORI_CURR;
        entity.NSUPPORT_ID = dto.NSUPPORT_ID;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NBANK_AGREE = dto.NBANK_AGREE;
        entity.NINPUTCHANNEL = dto.NINPUTCHANNEL;
        entity.SACTION = dto.SACTION;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NORI_AMOUNT = dto.NORI_AMOUNT;
        entity.DVALUEDATE = dto.DVALUEDATE;
    }
}
