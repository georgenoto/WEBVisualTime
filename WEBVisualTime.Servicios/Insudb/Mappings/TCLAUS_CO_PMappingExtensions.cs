using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_P;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TCLAUS_CO_PMappingExtensions
{
    public static TCLAUS_CO_PDto ToDto(this TCLAUS_CO_P entity)
    {
        if (entity == null) return null!;
        return new TCLAUS_CO_PDto
        {
            SKEY = entity.SKEY,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCLAUSE = entity.NCLAUSE,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            STYPE_CLAUSE = entity.STYPE_CLAUSE,
            SDOC_ATTACH = entity.SDOC_ATTACH,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SMODIFIED = entity.SMODIFIED,
            SSELECTED = entity.SSELECTED,
            IND_INPOLICY = entity.IND_INPOLICY,
        };
    }

    public static TCLAUS_CO_P ToEntity(this CreateTCLAUS_CO_PDto dto)
    {
        if (dto == null) return null!;
        return new TCLAUS_CO_P
        {
            SKEY = dto.SKEY,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCLAUSE = dto.NCLAUSE,
            DEFFECDATE = dto.DEFFECDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            STYPE_CLAUSE = dto.STYPE_CLAUSE,
            SDOC_ATTACH = dto.SDOC_ATTACH,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            SMODIFIED = dto.SMODIFIED,
            SSELECTED = dto.SSELECTED,
            IND_INPOLICY = dto.IND_INPOLICY,
        };
    }

    public static void UpdateEntity(this TCLAUS_CO_P entity, UpdateTCLAUS_CO_PDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCLAUSE = dto.NCLAUSE;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.STYPE_CLAUSE = dto.STYPE_CLAUSE;
        entity.SDOC_ATTACH = dto.SDOC_ATTACH;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.SMODIFIED = dto.SMODIFIED;
        entity.SSELECTED = dto.SSELECTED;
        entity.IND_INPOLICY = dto.IND_INPOLICY;
    }
}
