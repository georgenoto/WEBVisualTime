using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_INTLRECAUDACION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REP_INTLRECAUDACIONMappingExtensions
{
    public static REP_INTLRECAUDACIONDto ToDto(this REP_INTLRECAUDACION entity)
    {
        if (entity == null) return null!;
        return new REP_INTLRECAUDACIONDto
        {
            SKEY = entity.SKEY,
            NSEQ = entity.NSEQ,
            SCLIENT = entity.SCLIENT,
            SDIGIT = entity.SDIGIT,
            NPOLICY = entity.NPOLICY,
            NPROPONUM = entity.NPROPONUM,
            NPRODUCT = entity.NPRODUCT,
            NAMOUNT_LOCAL = entity.NAMOUNT_LOCAL,
            NAMOUNT = entity.NAMOUNT,
            NRECEIPT = entity.NRECEIPT,
            NBORDEREAUX = entity.NBORDEREAUX,
            SDESCRIPTOLD = entity.SDESCRIPTOLD,
            SDESCRIPTACC = entity.SDESCRIPTACC,
            NSHEET = entity.NSHEET,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NSTATUSREND = entity.NSTATUSREND,
            NTYPEREJEC = entity.NTYPEREJEC,
            NBULLETINS = entity.NBULLETINS,
            NSECTION = entity.NSECTION,
            NORDER = entity.NORDER,
            NCERTIF = entity.NCERTIF,
            NBANK = entity.NBANK,
        };
    }

    public static REP_INTLRECAUDACION ToEntity(this CreateREP_INTLRECAUDACIONDto dto)
    {
        if (dto == null) return null!;
        return new REP_INTLRECAUDACION
        {
            SKEY = dto.SKEY,
            NSEQ = dto.NSEQ,
            SCLIENT = dto.SCLIENT,
            SDIGIT = dto.SDIGIT,
            NPOLICY = dto.NPOLICY,
            NPROPONUM = dto.NPROPONUM,
            NPRODUCT = dto.NPRODUCT,
            NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL,
            NAMOUNT = dto.NAMOUNT,
            NRECEIPT = dto.NRECEIPT,
            NBORDEREAUX = dto.NBORDEREAUX,
            SDESCRIPTOLD = dto.SDESCRIPTOLD,
            SDESCRIPTACC = dto.SDESCRIPTACC,
            NSHEET = dto.NSHEET,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NSTATUSREND = dto.NSTATUSREND,
            NTYPEREJEC = dto.NTYPEREJEC,
            NBULLETINS = dto.NBULLETINS,
            NSECTION = dto.NSECTION,
            NORDER = dto.NORDER,
            NCERTIF = dto.NCERTIF,
            NBANK = dto.NBANK,
        };
    }

    public static void UpdateEntity(this REP_INTLRECAUDACION entity, UpdateREP_INTLRECAUDACIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NSEQ = dto.NSEQ;
        entity.SCLIENT = dto.SCLIENT;
        entity.SDIGIT = dto.SDIGIT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.SDESCRIPTOLD = dto.SDESCRIPTOLD;
        entity.SDESCRIPTACC = dto.SDESCRIPTACC;
        entity.NSHEET = dto.NSHEET;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NSTATUSREND = dto.NSTATUSREND;
        entity.NTYPEREJEC = dto.NTYPEREJEC;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NSECTION = dto.NSECTION;
        entity.NORDER = dto.NORDER;
        entity.NCERTIF = dto.NCERTIF;
        entity.NBANK = dto.NBANK;
    }
}
