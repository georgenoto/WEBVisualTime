using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_NPR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CESSION_NPRMappingExtensions
{
    public static CESSION_NPRDto ToDto(this CESSION_NPR entity)
    {
        if (entity == null) return null!;
        return new CESSION_NPRDto
        {
            NCESSION_NU = entity.NCESSION_NU,
            NID = entity.NID,
            NCOMPANY = entity.NCOMPANY,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            NBRANCH_REI = entity.NBRANCH_REI,
            NTYPE_CESSI = entity.NTYPE_CESSI,
            NCONCEPT = entity.NCONCEPT,
            NCOMMISSION = entity.NCOMMISSION,
            NCURRENCY = entity.NCURRENCY,
            SPRINT_CE = entity.SPRINT_CE,
            NSHARE = entity.NSHARE,
            NYEARMONTH = entity.NYEARMONTH,
            DSTARTDATE = entity.DSTARTDATE,
            DENDDATE = entity.DENDDATE,
            NPREM_DEP = entity.NPREM_DEP,
            NCESS_PREM = entity.NCESS_PREM,
            NTAXRATE = entity.NTAXRATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCESS_CL = entity.NCESS_CL,
            NCAPITAL_EXP = entity.NCAPITAL_EXP,
            NCAPITAL_EXP_I = entity.NCAPITAL_EXP_I,
            NAVG_CAPITALEXP = entity.NAVG_CAPITALEXP,
            NINSURANCE_EXP = entity.NINSURANCE_EXP,
            NINSURANCE_EXP_I = entity.NINSURANCE_EXP_I,
            NAVG_INS_EXP = entity.NAVG_INS_EXP,
            NCLAIMCES_PEND = entity.NCLAIMCES_PEND,
            NCLAIMCES_PAY = entity.NCLAIMCES_PAY,
            NTOTAL_CESS = entity.NTOTAL_CESS,
            NRATE_ADJ = entity.NRATE_ADJ,
            NFACTOR_ADJ = entity.NFACTOR_ADJ,
            NRATE = entity.NRATE,
            NPREMIUM = entity.NPREMIUM,
            NPREMWTAX = entity.NPREMWTAX,
            NFACTOR_ADJ_B = entity.NFACTOR_ADJ_B,
            NRATE_B = entity.NRATE_B,
            NPREMIUM_B = entity.NPREMIUM_B,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SCLIENT = entity.SCLIENT,
            NRECEIPT = entity.NRECEIPT,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
        };
    }

    public static CESSION_NPR ToEntity(this CreateCESSION_NPRDto dto)
    {
        if (dto == null) return null!;
        return new CESSION_NPR
        {
            NCESSION_NU = dto.NCESSION_NU,
            NID = dto.NID,
            NCOMPANY = dto.NCOMPANY,
            NNUMBER = dto.NNUMBER,
            NTYPE = dto.NTYPE,
            NBRANCH_REI = dto.NBRANCH_REI,
            NTYPE_CESSI = dto.NTYPE_CESSI,
            NCONCEPT = dto.NCONCEPT,
            NCOMMISSION = dto.NCOMMISSION,
            NCURRENCY = dto.NCURRENCY,
            SPRINT_CE = dto.SPRINT_CE,
            NSHARE = dto.NSHARE,
            NYEARMONTH = dto.NYEARMONTH,
            DSTARTDATE = dto.DSTARTDATE,
            DENDDATE = dto.DENDDATE,
            NPREM_DEP = dto.NPREM_DEP,
            NCESS_PREM = dto.NCESS_PREM,
            NTAXRATE = dto.NTAXRATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCESS_CL = dto.NCESS_CL,
            NCAPITAL_EXP = dto.NCAPITAL_EXP,
            NCAPITAL_EXP_I = dto.NCAPITAL_EXP_I,
            NAVG_CAPITALEXP = dto.NAVG_CAPITALEXP,
            NINSURANCE_EXP = dto.NINSURANCE_EXP,
            NINSURANCE_EXP_I = dto.NINSURANCE_EXP_I,
            NAVG_INS_EXP = dto.NAVG_INS_EXP,
            NCLAIMCES_PEND = dto.NCLAIMCES_PEND,
            NCLAIMCES_PAY = dto.NCLAIMCES_PAY,
            NTOTAL_CESS = dto.NTOTAL_CESS,
            NRATE_ADJ = dto.NRATE_ADJ,
            NFACTOR_ADJ = dto.NFACTOR_ADJ,
            NRATE = dto.NRATE,
            NPREMIUM = dto.NPREMIUM,
            NPREMWTAX = dto.NPREMWTAX,
            NFACTOR_ADJ_B = dto.NFACTOR_ADJ_B,
            NRATE_B = dto.NRATE_B,
            NPREMIUM_B = dto.NPREMIUM_B,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            SCLIENT = dto.SCLIENT,
            NRECEIPT = dto.NRECEIPT,
            NDIGIT = dto.NDIGIT,
            NPAYNUMBE = dto.NPAYNUMBE,
        };
    }

    public static void UpdateEntity(this CESSION_NPR entity, UpdateCESSION_NPRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCESSION_NU = dto.NCESSION_NU;
        entity.NID = dto.NID;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NNUMBER = dto.NNUMBER;
        entity.NTYPE = dto.NTYPE;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NTYPE_CESSI = dto.NTYPE_CESSI;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SPRINT_CE = dto.SPRINT_CE;
        entity.NSHARE = dto.NSHARE;
        entity.NYEARMONTH = dto.NYEARMONTH;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DENDDATE = dto.DENDDATE;
        entity.NPREM_DEP = dto.NPREM_DEP;
        entity.NCESS_PREM = dto.NCESS_PREM;
        entity.NTAXRATE = dto.NTAXRATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCESS_CL = dto.NCESS_CL;
        entity.NCAPITAL_EXP = dto.NCAPITAL_EXP;
        entity.NCAPITAL_EXP_I = dto.NCAPITAL_EXP_I;
        entity.NAVG_CAPITALEXP = dto.NAVG_CAPITALEXP;
        entity.NINSURANCE_EXP = dto.NINSURANCE_EXP;
        entity.NINSURANCE_EXP_I = dto.NINSURANCE_EXP_I;
        entity.NAVG_INS_EXP = dto.NAVG_INS_EXP;
        entity.NCLAIMCES_PEND = dto.NCLAIMCES_PEND;
        entity.NCLAIMCES_PAY = dto.NCLAIMCES_PAY;
        entity.NTOTAL_CESS = dto.NTOTAL_CESS;
        entity.NRATE_ADJ = dto.NRATE_ADJ;
        entity.NFACTOR_ADJ = dto.NFACTOR_ADJ;
        entity.NRATE = dto.NRATE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPREMWTAX = dto.NPREMWTAX;
        entity.NFACTOR_ADJ_B = dto.NFACTOR_ADJ_B;
        entity.NRATE_B = dto.NRATE_B;
        entity.NPREMIUM_B = dto.NPREMIUM_B;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.SCLIENT = dto.SCLIENT;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NDIGIT = dto.NDIGIT;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
    }
}
