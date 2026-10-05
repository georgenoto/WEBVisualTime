using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DETAIL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERCL_DETAILMappingExtensions
{
    public static MASTERCL_DETAILDto ToDto(this MASTERCL_DETAIL entity)
    {
        if (entity == null) return null!;
        return new MASTERCL_DETAILDto
        {
            NMASTERORDER = entity.NMASTERORDER,
            NORD_PROCEDURE = entity.NORD_PROCEDURE,
            TABLE9261SDESCRIPT = entity.TABLE9261?.SDESCRIPT,
            NID = entity.NID,
            SBENEFIT = entity.SBENEFIT,
            SSAME_INCISION = entity.SSAME_INCISION,
            NPERCENTAGE_PROC = entity.NPERCENTAGE_PROC,
            SILLNESS = entity.SILLNESS,
            NCOD_REJECT = entity.NCOD_REJECT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SREJECTALERT = entity.SREJECTALERT,
            NAPPLY_EXCLU = entity.NAPPLY_EXCLU,
            SILLNES_DETECT = entity.SILLNES_DETECT,
            NACCEPT_EVALMED = entity.NACCEPT_EVALMED,
            SMEDICAL_REJEC = entity.SMEDICAL_REJEC,
            SREJECTOBSV = entity.SREJECTOBSV,
            NORDER_NUM = entity.NORDER_NUM,
            NPROCEDURE_ID = entity.NPROCEDURE_ID,
            NRELPROCEDURE_ID = entity.NRELPROCEDURE_ID,
            NBALANCE = entity.NBALANCE,
            NAMOUNT_DOCU = entity.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = entity.NAMOUNT_ORDEN,
            NPERCEN_COVERAGE = entity.NPERCEN_COVERAGE,
            NQUANTITY = entity.NQUANTITY,
            NIND_DONOTRECALCULATE = entity.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = entity.NAMOUNT_DIFFERENCETARIFF,
            NIND_REOPENCL = entity.NIND_REOPENCL,
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            TABLE9271SDESCRIPT = entity.TABLE9271?.SDESCRIPT,
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            NRELPROCEDURE_NUM_ORIG = entity.NRELPROCEDURE_NUM_ORIG,
            NRELPROCEDURE_NUM_GEN = entity.NRELPROCEDURE_NUM_GEN,
        };
    }

    public static MASTERCL_DETAIL ToEntity(this CreateMASTERCL_DETAILDto dto)
    {
        if (dto == null) return null!;
        return new MASTERCL_DETAIL
        {
            NORD_PROCEDURE = dto.NORD_PROCEDURE,
            NID = dto.NID,
            SBENEFIT = dto.SBENEFIT,
            SSAME_INCISION = dto.SSAME_INCISION,
            NPERCENTAGE_PROC = dto.NPERCENTAGE_PROC,
            SILLNESS = dto.SILLNESS,
            NCOD_REJECT = dto.NCOD_REJECT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SREJECTALERT = dto.SREJECTALERT,
            NAPPLY_EXCLU = dto.NAPPLY_EXCLU,
            SILLNES_DETECT = dto.SILLNES_DETECT,
            NACCEPT_EVALMED = dto.NACCEPT_EVALMED,
            SMEDICAL_REJEC = dto.SMEDICAL_REJEC,
            SREJECTOBSV = dto.SREJECTOBSV,
            NORDER_NUM = dto.NORDER_NUM,
            NRELPROCEDURE_ID = dto.NRELPROCEDURE_ID,
            NBALANCE = dto.NBALANCE,
            NAMOUNT_DOCU = dto.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN,
            NPERCEN_COVERAGE = dto.NPERCEN_COVERAGE,
            NQUANTITY = dto.NQUANTITY,
            NIND_DONOTRECALCULATE = dto.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = dto.NAMOUNT_DIFFERENCETARIFF,
            NIND_REOPENCL = dto.NIND_REOPENCL,
            NCAUSEREOPENCL = dto.NCAUSEREOPENCL,
            NTYPE_COMMPAY = dto.NTYPE_COMMPAY,
            NRELPROCEDURE_NUM_ORIG = dto.NRELPROCEDURE_NUM_ORIG,
            NRELPROCEDURE_NUM_GEN = dto.NRELPROCEDURE_NUM_GEN,
        };
    }

    public static void UpdateEntity(this MASTERCL_DETAIL entity, UpdateMASTERCL_DETAILDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NORD_PROCEDURE = dto.NORD_PROCEDURE;
        entity.NID = dto.NID;
        entity.SBENEFIT = dto.SBENEFIT;
        entity.SSAME_INCISION = dto.SSAME_INCISION;
        entity.NPERCENTAGE_PROC = dto.NPERCENTAGE_PROC;
        entity.SILLNESS = dto.SILLNESS;
        entity.NCOD_REJECT = dto.NCOD_REJECT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SREJECTALERT = dto.SREJECTALERT;
        entity.NAPPLY_EXCLU = dto.NAPPLY_EXCLU;
        entity.SILLNES_DETECT = dto.SILLNES_DETECT;
        entity.NACCEPT_EVALMED = dto.NACCEPT_EVALMED;
        entity.SMEDICAL_REJEC = dto.SMEDICAL_REJEC;
        entity.SREJECTOBSV = dto.SREJECTOBSV;
        entity.NORDER_NUM = dto.NORDER_NUM;
        entity.NRELPROCEDURE_ID = dto.NRELPROCEDURE_ID;
        entity.NBALANCE = dto.NBALANCE;
        entity.NAMOUNT_DOCU = dto.NAMOUNT_DOCU;
        entity.NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN;
        entity.NPERCEN_COVERAGE = dto.NPERCEN_COVERAGE;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NIND_DONOTRECALCULATE = dto.NIND_DONOTRECALCULATE;
        entity.NAMOUNT_DIFFERENCETARIFF = dto.NAMOUNT_DIFFERENCETARIFF;
        entity.NIND_REOPENCL = dto.NIND_REOPENCL;
        entity.NCAUSEREOPENCL = dto.NCAUSEREOPENCL;
        entity.NTYPE_COMMPAY = dto.NTYPE_COMMPAY;
        entity.NRELPROCEDURE_NUM_ORIG = dto.NRELPROCEDURE_NUM_ORIG;
        entity.NRELPROCEDURE_NUM_GEN = dto.NRELPROCEDURE_NUM_GEN;
    }
}
