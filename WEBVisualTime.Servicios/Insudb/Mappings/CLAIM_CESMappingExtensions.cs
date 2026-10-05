using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_CESMappingExtensions
{
    public static CLAIM_CESDto ToDto(this CLAIM_CES entity)
    {
        if (entity == null) return null!;
        return new CLAIM_CESDto
        {
            NCLAIM = entity.NCLAIM,
            CL_M_COVERNCLAIMSAUT_ADJUST = entity.CL_M_COVERNCLAIM?.SAUT_ADJUST,
            NCASE_NUM = entity.NCASE_NUM,
            CL_M_COVERNCASE_NUMSAUT_ADJUST = entity.CL_M_COVERNCASE_NUM?.SAUT_ADJUST,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CL_M_COVERNDEMAN_TYPESAUT_ADJUST = entity.CL_M_COVERNDEMAN_TYPE?.SAUT_ADJUST,
            NID = entity.NID,
            NTRANSAC = entity.NTRANSAC,
            CL_M_COVERNTRANSACSAUT_ADJUST = entity.CL_M_COVERNTRANSAC?.SAUT_ADJUST,
            NNUMBER = entity.NNUMBER,
            CONTRPROCNNUMBERSCAP_NOM_RI = entity.CONTRPROCNNUMBER?.SCAP_NOM_RI,
            NCESS_NU = entity.NCESS_NU,
            NBRANCH_REI = entity.NBRANCH_REI,
            CONTRPROCNBRANCH_REISCAP_NOM_RI = entity.CONTRPROCNBRANCH_REI?.SCAP_NOM_RI,
            NNUM_CESS = entity.NNUM_CESS,
            NCURRENCY = entity.NCURRENCY,
            CL_M_COVERNCURRENCYSAUT_ADJUST = entity.CL_M_COVERNCURRENCY?.SAUT_ADJUST,
            NCED_AMNT = entity.NCED_AMNT,
            NCED_PER = entity.NCED_PER,
            NCESS_CONC = entity.NCESS_CONC,
            TABLE140SDESCRIPT = entity.TABLE140?.SDESCRIPT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NCESS_TYPE = entity.NCESS_TYPE,
            TABLE534SDESCRIPT = entity.TABLE534?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            DEND_DATE = entity.DEND_DATE,
            DINIT_DATE = entity.DINIT_DATE,
            DOCCURDATE = entity.DOCCURDATE,
            NPOLICY = entity.NPOLICY,
            SPRINT_C = entity.SPRINT_C,
            NUSERCODE = entity.NUSERCODE,
            DEFFECDATE = entity.DEFFECDATE,
            CONTRPROCDEFFECDATESCAP_NOM_RI = entity.CONTRPROCDEFFECDATE?.SCAP_NOM_RI,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NMODULEC = entity.NMODULEC,
            CL_M_COVERNMODULECSAUT_ADJUST = entity.CL_M_COVERNMODULEC?.SAUT_ADJUST,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CL_M_COVERSCLIENTSAUT_ADJUST = entity.CL_M_COVERSCLIENT?.SAUT_ADJUST,
            NCOVER = entity.NCOVER,
            CL_M_COVERNCOVERSAUT_ADJUST = entity.CL_M_COVERNCOVER?.SAUT_ADJUST,
            NYEARMONTH = entity.NYEARMONTH,
            NGROUP_INSU = entity.NGROUP_INSU,
            NTYPE = entity.NTYPE,
            CONTRPROCNTYPESCAP_NOM_RI = entity.CONTRPROCNTYPE?.SCAP_NOM_RI,
            SSTACLAIM = entity.SSTACLAIM,
            NRET_AMNT = entity.NRET_AMNT,
            NCLA_AMNT = entity.NCLA_AMNT,
            DCLAIM_PAY = entity.DCLAIM_PAY,
            DLEDGERDAT = entity.DLEDGERDAT,
            DPOSTED = entity.DPOSTED,
        };
    }

    public static CLAIM_CES ToEntity(this CreateCLAIM_CESDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_CES
        {
            NTRANSAC = dto.NTRANSAC,
            NNUMBER = dto.NNUMBER,
            NBRANCH_REI = dto.NBRANCH_REI,
            NNUM_CESS = dto.NNUM_CESS,
            NCURRENCY = dto.NCURRENCY,
            NCED_AMNT = dto.NCED_AMNT,
            NCED_PER = dto.NCED_PER,
            NCESS_CONC = dto.NCESS_CONC,
            NCOMPANY = dto.NCOMPANY,
            NCESS_TYPE = dto.NCESS_TYPE,
            DCOMPDATE = dto.DCOMPDATE,
            DEND_DATE = dto.DEND_DATE,
            DINIT_DATE = dto.DINIT_DATE,
            DOCCURDATE = dto.DOCCURDATE,
            NPOLICY = dto.NPOLICY,
            SPRINT_C = dto.SPRINT_C,
            NUSERCODE = dto.NUSERCODE,
            DEFFECDATE = dto.DEFFECDATE,
            NBRANCH_LED = dto.NBRANCH_LED,
            NMODULEC = dto.NMODULEC,
            NINSUR_AREA = dto.NINSUR_AREA,
            SCLIENT = dto.SCLIENT,
            NCOVER = dto.NCOVER,
            NYEARMONTH = dto.NYEARMONTH,
            NGROUP_INSU = dto.NGROUP_INSU,
            NTYPE = dto.NTYPE,
            SSTACLAIM = dto.SSTACLAIM,
            NRET_AMNT = dto.NRET_AMNT,
            NCLA_AMNT = dto.NCLA_AMNT,
            DCLAIM_PAY = dto.DCLAIM_PAY,
            DLEDGERDAT = dto.DLEDGERDAT,
            DPOSTED = dto.DPOSTED,
        };
    }

    public static void UpdateEntity(this CLAIM_CES entity, UpdateCLAIM_CESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NNUMBER = dto.NNUMBER;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NNUM_CESS = dto.NNUM_CESS;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCED_AMNT = dto.NCED_AMNT;
        entity.NCED_PER = dto.NCED_PER;
        entity.NCESS_CONC = dto.NCESS_CONC;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NCESS_TYPE = dto.NCESS_TYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DEND_DATE = dto.DEND_DATE;
        entity.DINIT_DATE = dto.DINIT_DATE;
        entity.DOCCURDATE = dto.DOCCURDATE;
        entity.NPOLICY = dto.NPOLICY;
        entity.SPRINT_C = dto.SPRINT_C;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NMODULEC = dto.NMODULEC;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCOVER = dto.NCOVER;
        entity.NYEARMONTH = dto.NYEARMONTH;
        entity.NGROUP_INSU = dto.NGROUP_INSU;
        entity.NTYPE = dto.NTYPE;
        entity.SSTACLAIM = dto.SSTACLAIM;
        entity.NRET_AMNT = dto.NRET_AMNT;
        entity.NCLA_AMNT = dto.NCLA_AMNT;
        entity.DCLAIM_PAY = dto.DCLAIM_PAY;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.DPOSTED = dto.DPOSTED;
    }
}
