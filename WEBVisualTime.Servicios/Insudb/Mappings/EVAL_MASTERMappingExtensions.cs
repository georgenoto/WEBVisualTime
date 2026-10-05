using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class EVAL_MASTERMappingExtensions
{
    public static EVAL_MASTERDto ToDto(this EVAL_MASTER entity)
    {
        if (entity == null) return null!;
        return new EVAL_MASTERDto
        {
            NEVAL = entity.NEVAL,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            DSTARTDATE = entity.DSTARTDATE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NSTATUS_EVAL = entity.NSTATUS_EVAL,
            TABLE5572SDESCRIPT = entity.TABLE5572?.SDESCRIPT,
            NCAPITAL = entity.NCAPITAL,
            NNOTEREST = entity.NNOTEREST,
            NCURRENCY = entity.NCURRENCY,
            NCUMUL = entity.NCUMUL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
        };
    }

    public static EVAL_MASTER ToEntity(this CreateEVAL_MASTERDto dto)
    {
        if (dto == null) return null!;
        return new EVAL_MASTER
        {
            SCLIENT = dto.SCLIENT,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            DSTARTDATE = dto.DSTARTDATE,
            NCERTIF = dto.NCERTIF,
            DEXPIRDAT = dto.DEXPIRDAT,
            NSTATUS_EVAL = dto.NSTATUS_EVAL,
            NCAPITAL = dto.NCAPITAL,
            NNOTEREST = dto.NNOTEREST,
            NCURRENCY = dto.NCURRENCY,
            NCUMUL = dto.NCUMUL,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCERTYPE = dto.SCERTYPE,
        };
    }

    public static void UpdateEntity(this EVAL_MASTER entity, UpdateEVAL_MASTERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NCERTIF = dto.NCERTIF;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NSTATUS_EVAL = dto.NSTATUS_EVAL;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NNOTEREST = dto.NNOTEREST;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCUMUL = dto.NCUMUL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCERTYPE = dto.SCERTYPE;
    }
}
