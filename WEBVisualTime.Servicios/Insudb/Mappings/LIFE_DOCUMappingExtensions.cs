using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_DOCU;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LIFE_DOCUMappingExtensions
{
    public static LIFE_DOCUDto ToDto(this LIFE_DOCU entity)
    {
        if (entity == null) return null!;
        return new LIFE_DOCUDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NMODULEC = entity.NMODULEC,
            NCRTHECNI = entity.NCRTHECNI,
            NCOVER = entity.NCOVER,
            DRECEP_DATE = entity.DRECEP_DATE,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NSTAT_DOCREQ = entity.NSTAT_DOCREQ,
            TABLE275SDESCRIPT = entity.TABLE275?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DDATE_TO = entity.DDATE_TO,
            DDATEFREE = entity.DDATEFREE,
            NEVAL = entity.NEVAL,
            EVAL_MASTERSCERTYPE = entity.EVAL_MASTER?.SCERTYPE,
            DDATEVIG = entity.DDATEVIG,
            NNOTENUM = entity.NNOTENUM,
            SREQUEST = entity.SREQUEST,
            NREASON = entity.NREASON,
            TABLE5719SDESCRIPT = entity.TABLE5719?.SDESCRIPT,
            SRANDOM = entity.SRANDOM,
            NID_SECUENCIA = entity.NID_SECUENCIA,
        };
    }

    public static LIFE_DOCU ToEntity(this CreateLIFE_DOCUDto dto)
    {
        if (dto == null) return null!;
        return new LIFE_DOCU
        {
            DNULLDATE = dto.DNULLDATE,
            DRECEP_DATE = dto.DRECEP_DATE,
            NSTAT_DOCREQ = dto.NSTAT_DOCREQ,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DDATE_TO = dto.DDATE_TO,
            DDATEFREE = dto.DDATEFREE,
            NEVAL = dto.NEVAL,
            DDATEVIG = dto.DDATEVIG,
            NNOTENUM = dto.NNOTENUM,
            SREQUEST = dto.SREQUEST,
            NREASON = dto.NREASON,
            SRANDOM = dto.SRANDOM,
            NID_SECUENCIA = dto.NID_SECUENCIA,
        };
    }

    public static void UpdateEntity(this LIFE_DOCU entity, UpdateLIFE_DOCUDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DRECEP_DATE = dto.DRECEP_DATE;
        entity.NSTAT_DOCREQ = dto.NSTAT_DOCREQ;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DDATE_TO = dto.DDATE_TO;
        entity.DDATEFREE = dto.DDATEFREE;
        entity.NEVAL = dto.NEVAL;
        entity.DDATEVIG = dto.DDATEVIG;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SREQUEST = dto.SREQUEST;
        entity.NREASON = dto.NREASON;
        entity.SRANDOM = dto.SRANDOM;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
    }
}
