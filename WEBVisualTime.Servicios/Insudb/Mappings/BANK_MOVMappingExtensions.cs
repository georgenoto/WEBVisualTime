using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_MOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BANK_MOVMappingExtensions
{
    public static BANK_MOVDto ToDto(this BANK_MOV entity)
    {
        if (entity == null) return null!;
        return new BANK_MOVDto
        {
            SDEP_NUMBER = entity.SDEP_NUMBER,
            SNULL_MOVEM = entity.SNULL_MOVEM,
            SNULL_RECOR = entity.SNULL_RECOR,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DDOC_DATE = entity.DDOC_DATE,
            NCASH_AMOUN = entity.NCASH_AMOUN,
            NCHEQ_AMOUN = entity.NCHEQ_AMOUN,
            NMOVEMENT = entity.NMOVEMENT,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            SDOCNUMBE = entity.SDOCNUMBE,
            NCONCEPT = entity.NCONCEPT,
            TABLE22SDESCRIPT = entity.TABLE22?.SDESCRIPT,
            NACC_BANK = entity.NACC_BANK,
            BANK_ACCSACC_LEDGER = entity.BANK_ACC?.SACC_LEDGER,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NTYPE_MOV = entity.NTYPE_MOV,
            TABLE296SDESCRIPT = entity.TABLE296?.SDESCRIPT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NUSERCODE = entity.NUSERCODE,
            SNUMFORM = entity.SNUMFORM,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NCONTRAT = entity.NCONTRAT,
            FINANC_DRANCONTRATSINDCHEQUE = entity.FINANC_DRANCONTRAT?.SINDCHEQUE,
            NDRAFT = entity.NDRAFT,
            FINANC_DRANDRAFTSINDCHEQUE = entity.FINANC_DRANDRAFT?.SINDCHEQUE,
            NCOMPANYC = entity.NCOMPANYC,
            NVOUCHER = entity.NVOUCHER,
            NTYP_ACCO = entity.NTYP_ACCO,
            TABLE400SDESCRIPT = entity.TABLE400?.SDESCRIPT,
            STYPE_ACC = entity.STYPE_ACC,
            NCASHNUM = entity.NCASHNUM,
            DPOSTED = entity.DPOSTED,
            NNOTENUM = entity.NNOTENUM,
            NID = entity.NID,
            NINSUR_AREA = entity.NINSUR_AREA,
            DCOLLECTION = entity.DCOLLECTION,
            NPROPONUM = entity.NPROPONUM,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            NORI_CURR = entity.NORI_CURR,
            NORI_AMOUNT = entity.NORI_AMOUNT,
            NSUPPORT_ID = entity.NSUPPORT_ID,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            NCASH_ID = entity.NCASH_ID,
            NCOD_AGREE = entity.NCOD_AGREE,
            NBANK_AGREE = entity.NBANK_AGREE,
            NINPUTCHANNEL = entity.NINPUTCHANNEL,
            NBORDERUSED = entity.NBORDERUSED,
            DREALDEP = entity.DREALDEP,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            DVALUEDATE = entity.DVALUEDATE,
        };
    }

    public static BANK_MOV ToEntity(this CreateBANK_MOVDto dto)
    {
        if (dto == null) return null!;
        return new BANK_MOV
        {
            SDEP_NUMBER = dto.SDEP_NUMBER,
            SNULL_MOVEM = dto.SNULL_MOVEM,
            SNULL_RECOR = dto.SNULL_RECOR,
            DCOMPDATE = dto.DCOMPDATE,
            DDOC_DATE = dto.DDOC_DATE,
            NCASH_AMOUN = dto.NCASH_AMOUN,
            NCHEQ_AMOUN = dto.NCHEQ_AMOUN,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            NBORDEREAUX = dto.NBORDEREAUX,
            SDOCNUMBE = dto.SDOCNUMBE,
            NCONCEPT = dto.NCONCEPT,
            SCLIENT = dto.SCLIENT,
            NTYPE_MOV = dto.NTYPE_MOV,
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
            NID = dto.NID,
            NINSUR_AREA = dto.NINSUR_AREA,
            DCOLLECTION = dto.DCOLLECTION,
            NPROPONUM = dto.NPROPONUM,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            NORI_CURR = dto.NORI_CURR,
            NORI_AMOUNT = dto.NORI_AMOUNT,
            NSUPPORT_ID = dto.NSUPPORT_ID,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NCASH_ID = dto.NCASH_ID,
            NCOD_AGREE = dto.NCOD_AGREE,
            NBANK_AGREE = dto.NBANK_AGREE,
            NINPUTCHANNEL = dto.NINPUTCHANNEL,
            NBORDERUSED = dto.NBORDERUSED,
            DREALDEP = dto.DREALDEP,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            DVALUEDATE = dto.DVALUEDATE,
        };
    }

    public static void UpdateEntity(this BANK_MOV entity, UpdateBANK_MOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDEP_NUMBER = dto.SDEP_NUMBER;
        entity.SNULL_MOVEM = dto.SNULL_MOVEM;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDOC_DATE = dto.DDOC_DATE;
        entity.NCASH_AMOUN = dto.NCASH_AMOUN;
        entity.NCHEQ_AMOUN = dto.NCHEQ_AMOUN;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NTYPE_MOV = dto.NTYPE_MOV;
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
        entity.NID = dto.NID;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.DCOLLECTION = dto.DCOLLECTION;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NORI_CURR = dto.NORI_CURR;
        entity.NORI_AMOUNT = dto.NORI_AMOUNT;
        entity.NSUPPORT_ID = dto.NSUPPORT_ID;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NBANK_AGREE = dto.NBANK_AGREE;
        entity.NINPUTCHANNEL = dto.NINPUTCHANNEL;
        entity.NBORDERUSED = dto.NBORDERUSED;
        entity.DREALDEP = dto.DREALDEP;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.DVALUEDATE = dto.DVALUEDATE;
    }
}
