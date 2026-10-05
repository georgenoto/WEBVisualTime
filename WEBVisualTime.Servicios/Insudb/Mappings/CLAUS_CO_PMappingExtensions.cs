using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUS_CO_P;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAUS_CO_PMappingExtensions
{
    public static CLAUS_CO_PDto ToDto(this CLAUS_CO_P entity)
    {
        if (entity == null) return null!;
        return new CLAUS_CO_PDto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
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
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static CLAUS_CO_P ToEntity(this CreateCLAUS_CO_PDto dto)
    {
        if (dto == null) return null!;
        return new CLAUS_CO_P
        {
            DCOMPDATE = dto.DCOMPDATE,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            STYPE_CLAUSE = dto.STYPE_CLAUSE,
            SDOC_ATTACH = dto.SDOC_ATTACH,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this CLAUS_CO_P entity, UpdateCLAUS_CO_PDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.STYPE_CLAUSE = dto.STYPE_CLAUSE;
        entity.SDOC_ATTACH = dto.SDOC_ATTACH;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
