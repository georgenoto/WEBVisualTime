using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CLAUSE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_CLAUSEMappingExtensions
{
    public static TAB_CLAUSEDto ToDto(this TAB_CLAUSE entity)
    {
        if (entity == null) return null!;
        return new TAB_CLAUSEDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCLAUSE = entity.NCLAUSE,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SDESCRIPT = entity.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            SMODIFIED = entity.SMODIFIED,
            NTYPE = entity.NTYPE,
            TABLE7509SDESCRIPT = entity.TABLE7509?.SDESCRIPT,
            STYPE_CLAUSE = entity.STYPE_CLAUSE,
            SDOC_ATTACH = entity.SDOC_ATTACH,
            NORDEN = entity.NORDEN,
            STITCLAUSE = entity.STITCLAUSE,
        };
    }

    public static TAB_CLAUSE ToEntity(this CreateTAB_CLAUSEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_CLAUSE
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SDESCRIPT = dto.SDESCRIPT,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SMODIFIED = dto.SMODIFIED,
            NTYPE = dto.NTYPE,
            STYPE_CLAUSE = dto.STYPE_CLAUSE,
            SDOC_ATTACH = dto.SDOC_ATTACH,
            NORDEN = dto.NORDEN,
            STITCLAUSE = dto.STITCLAUSE,
        };
    }

    public static void UpdateEntity(this TAB_CLAUSE entity, UpdateTAB_CLAUSEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SMODIFIED = dto.SMODIFIED;
        entity.NTYPE = dto.NTYPE;
        entity.STYPE_CLAUSE = dto.STYPE_CLAUSE;
        entity.SDOC_ATTACH = dto.SDOC_ATTACH;
        entity.NORDEN = dto.NORDEN;
        entity.STITCLAUSE = dto.STITCLAUSE;
    }
}
