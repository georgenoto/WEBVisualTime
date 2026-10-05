using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUSE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAUSEMappingExtensions
{
    public static CLAUSEDto ToDto(this CLAUSE entity)
    {
        if (entity == null) return null!;
        return new CLAUSEDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NCLAUSE = entity.NCLAUSE,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NID = entity.NID,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SCLIENT = entity.SCLIENT,
            NGROUP_INSU = entity.NGROUP_INSU,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCAUSE = entity.NCAUSE,
            SAGREE = entity.SAGREE,
            STYPE_CLAUSE = entity.STYPE_CLAUSE,
            SDOC_ATTACH = entity.SDOC_ATTACH,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static CLAUSE ToEntity(this CreateCLAUSEDto dto)
    {
        if (dto == null) return null!;
        return new CLAUSE
        {
            DCOMPDATE = dto.DCOMPDATE,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SCLIENT = dto.SCLIENT,
            NGROUP_INSU = dto.NGROUP_INSU,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            NCAUSE = dto.NCAUSE,
            SAGREE = dto.SAGREE,
            STYPE_CLAUSE = dto.STYPE_CLAUSE,
            SDOC_ATTACH = dto.SDOC_ATTACH,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this CLAUSE entity, UpdateCLAUSEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NGROUP_INSU = dto.NGROUP_INSU;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.NCAUSE = dto.NCAUSE;
        entity.SAGREE = dto.SAGREE;
        entity.STYPE_CLAUSE = dto.STYPE_CLAUSE;
        entity.SDOC_ATTACH = dto.SDOC_ATTACH;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
