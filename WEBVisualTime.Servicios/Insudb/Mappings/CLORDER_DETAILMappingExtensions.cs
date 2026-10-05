using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DETAIL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLORDER_DETAILMappingExtensions
{
    public static CLORDER_DETAILDto ToDto(this CLORDER_DETAIL entity)
    {
        if (entity == null) return null!;
        return new CLORDER_DETAILDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_ORDERNCLAIMSTYPECARE = entity.CLAIM_ORDERNCLAIM?.STYPECARE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_ORDERNCASE_NUMSTYPECARE = entity.CLAIM_ORDERNCASE_NUM?.STYPECARE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            NORDER_NUM = entity.NORDER_NUM,
            CLAIM_ORDERNORDER_NUMSTYPECARE = entity.CLAIM_ORDERNORDER_NUM?.STYPECARE,
            NDETAIL_ORDER = entity.NDETAIL_ORDER,
            NID = entity.NID,
            SBENEFIT = entity.SBENEFIT,
            MEDICALBENEFITSSTYPEBENEFIT = entity.MEDICALBENEFITS?.STYPEBENEFIT,
            VADEMECUM = entity.VADEMECUM,
            NQUANTITY = entity.NQUANTITY,
            NAMOUNT_DOCU = entity.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = entity.NAMOUNT_ORDEN,
            NAMOUNT_UNITAMV = entity.NAMOUNT_UNITAMV,
            NAMOUNT_UNITRECAL = entity.NAMOUNT_UNITRECAL,
            NAMOUNT_TOTAL = entity.NAMOUNT_TOTAL,
            NPERCEN_COVERAGE = entity.NPERCEN_COVERAGE,
            NAMOUNT_DEDUCOIN = entity.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = entity.NAMOUNT_PAY,
            NCOD_REJECT = entity.NCOD_REJECT,
            NACCEPT_EVALMED = entity.NACCEPT_EVALMED,
            NAPPLY_EXCLU = entity.NAPPLY_EXCLU,
            SILLNES_DETECT = entity.SILLNES_DETECT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBALANCE = entity.NBALANCE,
            SREJECTALERT = entity.SREJECTALERT,
            SILLNESS = entity.SILLNESS,
            TAB_AM_ILLSDESCRIPT = entity.TAB_AM_ILL?.SDESCRIPT,
            NAMOUNT_PAY_POL = entity.NAMOUNT_PAY_POL,
            SMEDSPECIALIALTY = entity.SMEDSPECIALIALTY,
            TABLE8603SDESCRIPT = entity.TABLE8603?.SDESCRIPT,
            NSURCHAR_MED = entity.NSURCHAR_MED,
            MEDICAL_SURCHARGESDESCRIPT = entity.MEDICAL_SURCHARGE?.SDESCRIPT,
            NPERC_SURCHAR = entity.NPERC_SURCHAR,
            NAMOUNT_SURCHAR = entity.NAMOUNT_SURCHAR,
            SSECONDVISIT = entity.SSECONDVISIT,
            NAMOUNT_UNITAMV_INT = entity.NAMOUNT_UNITAMV_INT,
            SMEDICAL_REJEC = entity.SMEDICAL_REJEC,
            SREJECTOBSV = entity.SREJECTOBSV,
            NMASTERORDER = entity.NMASTERORDER,
            NPROCEDURE_ID = entity.NPROCEDURE_ID,
            NPERCENTAGE_ROLE = entity.NPERCENTAGE_ROLE,
            NIND_DONOTRECALCULATE = entity.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = entity.NAMOUNT_DIFFERENCETARIFF,
            NAMOUNT_DEDUCTIBLE = entity.NAMOUNT_DEDUCTIBLE,
            NAMOUNT_DISCOUNTS = entity.NAMOUNT_DISCOUNTS,
            NPERCENT_COV_ORIG = entity.NPERCENT_COV_ORIG,
            NTOTALAMOUNT_ORDER = entity.NTOTALAMOUNT_ORDER,
        };
    }

    public static CLORDER_DETAIL ToEntity(this CreateCLORDER_DETAILDto dto)
    {
        if (dto == null) return null!;
        return new CLORDER_DETAIL
        {
            NID = dto.NID,
            SBENEFIT = dto.SBENEFIT,
            VADEMECUM = dto.VADEMECUM,
            NQUANTITY = dto.NQUANTITY,
            NAMOUNT_DOCU = dto.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN,
            NAMOUNT_UNITAMV = dto.NAMOUNT_UNITAMV,
            NAMOUNT_UNITRECAL = dto.NAMOUNT_UNITRECAL,
            NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL,
            NPERCEN_COVERAGE = dto.NPERCEN_COVERAGE,
            NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = dto.NAMOUNT_PAY,
            NCOD_REJECT = dto.NCOD_REJECT,
            NACCEPT_EVALMED = dto.NACCEPT_EVALMED,
            NAPPLY_EXCLU = dto.NAPPLY_EXCLU,
            SILLNES_DETECT = dto.SILLNES_DETECT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBALANCE = dto.NBALANCE,
            SREJECTALERT = dto.SREJECTALERT,
            SILLNESS = dto.SILLNESS,
            NAMOUNT_PAY_POL = dto.NAMOUNT_PAY_POL,
            SMEDSPECIALIALTY = dto.SMEDSPECIALIALTY,
            NSURCHAR_MED = dto.NSURCHAR_MED,
            NPERC_SURCHAR = dto.NPERC_SURCHAR,
            NAMOUNT_SURCHAR = dto.NAMOUNT_SURCHAR,
            SSECONDVISIT = dto.SSECONDVISIT,
            NAMOUNT_UNITAMV_INT = dto.NAMOUNT_UNITAMV_INT,
            SMEDICAL_REJEC = dto.SMEDICAL_REJEC,
            SREJECTOBSV = dto.SREJECTOBSV,
            NMASTERORDER = dto.NMASTERORDER,
            NPROCEDURE_ID = dto.NPROCEDURE_ID,
            NPERCENTAGE_ROLE = dto.NPERCENTAGE_ROLE,
            NIND_DONOTRECALCULATE = dto.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = dto.NAMOUNT_DIFFERENCETARIFF,
            NAMOUNT_DEDUCTIBLE = dto.NAMOUNT_DEDUCTIBLE,
            NAMOUNT_DISCOUNTS = dto.NAMOUNT_DISCOUNTS,
            NPERCENT_COV_ORIG = dto.NPERCENT_COV_ORIG,
            NTOTALAMOUNT_ORDER = dto.NTOTALAMOUNT_ORDER,
        };
    }

    public static void UpdateEntity(this CLORDER_DETAIL entity, UpdateCLORDER_DETAILDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NID = dto.NID;
        entity.SBENEFIT = dto.SBENEFIT;
        entity.VADEMECUM = dto.VADEMECUM;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NAMOUNT_DOCU = dto.NAMOUNT_DOCU;
        entity.NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN;
        entity.NAMOUNT_UNITAMV = dto.NAMOUNT_UNITAMV;
        entity.NAMOUNT_UNITRECAL = dto.NAMOUNT_UNITRECAL;
        entity.NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL;
        entity.NPERCEN_COVERAGE = dto.NPERCEN_COVERAGE;
        entity.NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN;
        entity.NAMOUNT_PAY = dto.NAMOUNT_PAY;
        entity.NCOD_REJECT = dto.NCOD_REJECT;
        entity.NACCEPT_EVALMED = dto.NACCEPT_EVALMED;
        entity.NAPPLY_EXCLU = dto.NAPPLY_EXCLU;
        entity.SILLNES_DETECT = dto.SILLNES_DETECT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBALANCE = dto.NBALANCE;
        entity.SREJECTALERT = dto.SREJECTALERT;
        entity.SILLNESS = dto.SILLNESS;
        entity.NAMOUNT_PAY_POL = dto.NAMOUNT_PAY_POL;
        entity.SMEDSPECIALIALTY = dto.SMEDSPECIALIALTY;
        entity.NSURCHAR_MED = dto.NSURCHAR_MED;
        entity.NPERC_SURCHAR = dto.NPERC_SURCHAR;
        entity.NAMOUNT_SURCHAR = dto.NAMOUNT_SURCHAR;
        entity.SSECONDVISIT = dto.SSECONDVISIT;
        entity.NAMOUNT_UNITAMV_INT = dto.NAMOUNT_UNITAMV_INT;
        entity.SMEDICAL_REJEC = dto.SMEDICAL_REJEC;
        entity.SREJECTOBSV = dto.SREJECTOBSV;
        entity.NMASTERORDER = dto.NMASTERORDER;
        entity.NPROCEDURE_ID = dto.NPROCEDURE_ID;
        entity.NPERCENTAGE_ROLE = dto.NPERCENTAGE_ROLE;
        entity.NIND_DONOTRECALCULATE = dto.NIND_DONOTRECALCULATE;
        entity.NAMOUNT_DIFFERENCETARIFF = dto.NAMOUNT_DIFFERENCETARIFF;
        entity.NAMOUNT_DEDUCTIBLE = dto.NAMOUNT_DEDUCTIBLE;
        entity.NAMOUNT_DISCOUNTS = dto.NAMOUNT_DISCOUNTS;
        entity.NPERCENT_COV_ORIG = dto.NPERCENT_COV_ORIG;
        entity.NTOTALAMOUNT_ORDER = dto.NTOTALAMOUNT_ORDER;
    }
}
