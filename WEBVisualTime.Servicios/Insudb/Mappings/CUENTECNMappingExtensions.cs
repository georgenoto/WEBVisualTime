using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CUENTECN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CUENTECNMappingExtensions
{
    public static CUENTECNDto ToDto(this CUENTECN entity)
    {
        if (entity == null) return null!;
        return new CUENTECNDto
        {
            NTYPE_REL = entity.NTYPE_REL,
            NIDCONSEC = entity.NIDCONSEC,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            NBRANCH = entity.NBRANCH,
            STYPE_ACC = entity.STYPE_ACC,
            NTYPE_PER = entity.NTYPE_PER,
            TABLE97SDESCRIPT = entity.TABLE97?.SDESCRIPT,
            NPERIODY = entity.NPERIODY,
            NCURRENCY = entity.NCURRENCY,
            NCLAIM_CED = entity.NCLAIM_CED,
            NCLAIM_REC = entity.NCLAIM_REC,
            NCOMISION = entity.NCOMISION,
            NCOMPANY = entity.NCOMPANY,
            DCOMPDATE = entity.DCOMPDATE,
            NDEV_RESCLA = entity.NDEV_RESCLA,
            NDEV_RESPRE = entity.NDEV_RESPRE,
            NE_CAR_PREM = entity.NE_CAR_PREM,
            NE_CAR_SIN = entity.NE_CAR_SIN,
            DEFFECDATE = entity.DEFFECDATE,
            NGASTO_REAS = entity.NGASTO_REAS,
            NIMPUESTO = entity.NIMPUESTO,
            NINTER_PREM = entity.NINTER_PREM,
            NINTER_SIN = entity.NINTER_SIN,
            SMOVE_ACC = entity.SMOVE_ACC,
            DNULLDATE = entity.DNULLDATE,
            NPART_BENEF = entity.NPART_BENEF,
            NPREM_ANU = entity.NPREM_ANU,
            NPREM_CED = entity.NPREM_CED,
            NPREM_NO_AN = entity.NPREM_NO_AN,
            NPREM_RES_A = entity.NPREM_RES_A,
            SPRINT = entity.SPRINT,
            NR_CAR_PREM = entity.NR_CAR_PREM,
            NR_CAR_SIN = entity.NR_CAR_SIN,
            NRES_AJ_SIN = entity.NRES_AJ_SIN,
            NRES_SINPEN = entity.NRES_SINPEN,
            NRET_RESPRE = entity.NRET_RESPRE,
            NSAL_F_COMP = entity.NSAL_F_COMP,
            NSAL_F_REIN = entity.NSAL_F_REIN,
            NCLAIMAMO = entity.NCLAIMAMO,
            NUSERCODE = entity.NUSERCODE,
            NYEAR = entity.NYEAR,
            NYEAR_SER = entity.NYEAR_SER,
            SACTIVE = entity.SACTIVE,
            NREQUESTNU = entity.NREQUESTNU,
            DDATEPAY = entity.DDATEPAY,
            DLEDGERDAT = entity.DLEDGERDAT,
            DPOSTED = entity.DPOSTED,
            NCORREDOR = entity.NCORREDOR,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NCITY_TAX = entity.NCITY_TAX,
            NISLR_TAX = entity.NISLR_TAX,
            NSUPER_TAX = entity.NSUPER_TAX,
            NTECH_TAX = entity.NTECH_TAX,
            NSHARE = entity.NSHARE,
            NAMOUNT_BENEF = entity.NAMOUNT_BENEF,
        };
    }

    public static CUENTECN ToEntity(this CreateCUENTECNDto dto)
    {
        if (dto == null) return null!;
        return new CUENTECN
        {
            NTYPE_REL = dto.NTYPE_REL,
            NNUMBER = dto.NNUMBER,
            NTYPE = dto.NTYPE,
            NBRANCH = dto.NBRANCH,
            STYPE_ACC = dto.STYPE_ACC,
            NTYPE_PER = dto.NTYPE_PER,
            NPERIODY = dto.NPERIODY,
            NCURRENCY = dto.NCURRENCY,
            NCLAIM_CED = dto.NCLAIM_CED,
            NCLAIM_REC = dto.NCLAIM_REC,
            NCOMISION = dto.NCOMISION,
            NCOMPANY = dto.NCOMPANY,
            DCOMPDATE = dto.DCOMPDATE,
            NDEV_RESCLA = dto.NDEV_RESCLA,
            NDEV_RESPRE = dto.NDEV_RESPRE,
            NE_CAR_PREM = dto.NE_CAR_PREM,
            NE_CAR_SIN = dto.NE_CAR_SIN,
            DEFFECDATE = dto.DEFFECDATE,
            NGASTO_REAS = dto.NGASTO_REAS,
            NIMPUESTO = dto.NIMPUESTO,
            NINTER_PREM = dto.NINTER_PREM,
            NINTER_SIN = dto.NINTER_SIN,
            SMOVE_ACC = dto.SMOVE_ACC,
            DNULLDATE = dto.DNULLDATE,
            NPART_BENEF = dto.NPART_BENEF,
            NPREM_ANU = dto.NPREM_ANU,
            NPREM_CED = dto.NPREM_CED,
            NPREM_NO_AN = dto.NPREM_NO_AN,
            NPREM_RES_A = dto.NPREM_RES_A,
            SPRINT = dto.SPRINT,
            NR_CAR_PREM = dto.NR_CAR_PREM,
            NR_CAR_SIN = dto.NR_CAR_SIN,
            NRES_AJ_SIN = dto.NRES_AJ_SIN,
            NRES_SINPEN = dto.NRES_SINPEN,
            NRET_RESPRE = dto.NRET_RESPRE,
            NSAL_F_COMP = dto.NSAL_F_COMP,
            NSAL_F_REIN = dto.NSAL_F_REIN,
            NCLAIMAMO = dto.NCLAIMAMO,
            NUSERCODE = dto.NUSERCODE,
            NYEAR = dto.NYEAR,
            NYEAR_SER = dto.NYEAR_SER,
            SACTIVE = dto.SACTIVE,
            NREQUESTNU = dto.NREQUESTNU,
            DDATEPAY = dto.DDATEPAY,
            DLEDGERDAT = dto.DLEDGERDAT,
            DPOSTED = dto.DPOSTED,
            NCORREDOR = dto.NCORREDOR,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NCITY_TAX = dto.NCITY_TAX,
            NISLR_TAX = dto.NISLR_TAX,
            NSUPER_TAX = dto.NSUPER_TAX,
            NTECH_TAX = dto.NTECH_TAX,
            NSHARE = dto.NSHARE,
            NAMOUNT_BENEF = dto.NAMOUNT_BENEF,
        };
    }

    public static void UpdateEntity(this CUENTECN entity, UpdateCUENTECNDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPE_REL = dto.NTYPE_REL;
        entity.NNUMBER = dto.NNUMBER;
        entity.NTYPE = dto.NTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.NTYPE_PER = dto.NTYPE_PER;
        entity.NPERIODY = dto.NPERIODY;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCLAIM_CED = dto.NCLAIM_CED;
        entity.NCLAIM_REC = dto.NCLAIM_REC;
        entity.NCOMISION = dto.NCOMISION;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NDEV_RESCLA = dto.NDEV_RESCLA;
        entity.NDEV_RESPRE = dto.NDEV_RESPRE;
        entity.NE_CAR_PREM = dto.NE_CAR_PREM;
        entity.NE_CAR_SIN = dto.NE_CAR_SIN;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NGASTO_REAS = dto.NGASTO_REAS;
        entity.NIMPUESTO = dto.NIMPUESTO;
        entity.NINTER_PREM = dto.NINTER_PREM;
        entity.NINTER_SIN = dto.NINTER_SIN;
        entity.SMOVE_ACC = dto.SMOVE_ACC;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPART_BENEF = dto.NPART_BENEF;
        entity.NPREM_ANU = dto.NPREM_ANU;
        entity.NPREM_CED = dto.NPREM_CED;
        entity.NPREM_NO_AN = dto.NPREM_NO_AN;
        entity.NPREM_RES_A = dto.NPREM_RES_A;
        entity.SPRINT = dto.SPRINT;
        entity.NR_CAR_PREM = dto.NR_CAR_PREM;
        entity.NR_CAR_SIN = dto.NR_CAR_SIN;
        entity.NRES_AJ_SIN = dto.NRES_AJ_SIN;
        entity.NRES_SINPEN = dto.NRES_SINPEN;
        entity.NRET_RESPRE = dto.NRET_RESPRE;
        entity.NSAL_F_COMP = dto.NSAL_F_COMP;
        entity.NSAL_F_REIN = dto.NSAL_F_REIN;
        entity.NCLAIMAMO = dto.NCLAIMAMO;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR = dto.NYEAR;
        entity.NYEAR_SER = dto.NYEAR_SER;
        entity.SACTIVE = dto.SACTIVE;
        entity.NREQUESTNU = dto.NREQUESTNU;
        entity.DDATEPAY = dto.DDATEPAY;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.DPOSTED = dto.DPOSTED;
        entity.NCORREDOR = dto.NCORREDOR;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NCITY_TAX = dto.NCITY_TAX;
        entity.NISLR_TAX = dto.NISLR_TAX;
        entity.NSUPER_TAX = dto.NSUPER_TAX;
        entity.NTECH_TAX = dto.NTECH_TAX;
        entity.NSHARE = dto.NSHARE;
        entity.NAMOUNT_BENEF = dto.NAMOUNT_BENEF;
    }
}
