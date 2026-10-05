using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_M_COVER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CL_M_COVERMappingExtensions
{
    public static CL_M_COVERDto ToDto(this CL_M_COVER entity)
    {
        if (entity == null) return null!;
        return new CL_M_COVERDto
        {
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            NTRANSAC = entity.NTRANSAC,
            NCOVER = entity.NCOVER,
            NMODULEC = entity.NMODULEC,
            NCURRENCY = entity.NCURRENCY,
            NAMOUNT = entity.NAMOUNT,
            SCLIENT = entity.SCLIENT,
            SAUT_ADJUST = entity.SAUT_ADJUST,
            DCOMPDATE = entity.DCOMPDATE,
            NDED_AMOUNT = entity.NDED_AMOUNT,
            NEXCHANGE = entity.NEXCHANGE,
            NEXP_AMOUNT = entity.NEXP_AMOUNT,
            NGROUP = entity.NGROUP,
            NLOC_AMOUNT = entity.NLOC_AMOUNT,
            NQUANTITY = entity.NQUANTITY,
            NUSERCODE = entity.NUSERCODE,
            NVA_TAX = entity.NVA_TAX,
            NVAT_AMOUNT = entity.NVAT_AMOUNT,
            NLOC_COS_RE = entity.NLOC_COS_RE,
            SCESCATAS = entity.SCESCATAS,
            NSETTLECODE = entity.NSETTLECODE,
            SPOSTEDSEQUENCE = entity.SPOSTEDSEQUENCE,
        };
    }

    public static CL_M_COVER ToEntity(this CreateCL_M_COVERDto dto)
    {
        if (dto == null) return null!;
        return new CL_M_COVER
        {
            NAMOUNT = dto.NAMOUNT,
            SAUT_ADJUST = dto.SAUT_ADJUST,
            DCOMPDATE = dto.DCOMPDATE,
            NDED_AMOUNT = dto.NDED_AMOUNT,
            NEXCHANGE = dto.NEXCHANGE,
            NEXP_AMOUNT = dto.NEXP_AMOUNT,
            NGROUP = dto.NGROUP,
            NLOC_AMOUNT = dto.NLOC_AMOUNT,
            NQUANTITY = dto.NQUANTITY,
            NUSERCODE = dto.NUSERCODE,
            NVA_TAX = dto.NVA_TAX,
            NVAT_AMOUNT = dto.NVAT_AMOUNT,
            NLOC_COS_RE = dto.NLOC_COS_RE,
            SCESCATAS = dto.SCESCATAS,
            NSETTLECODE = dto.NSETTLECODE,
            SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE,
        };
    }

    public static void UpdateEntity(this CL_M_COVER entity, UpdateCL_M_COVERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SAUT_ADJUST = dto.SAUT_ADJUST;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NDED_AMOUNT = dto.NDED_AMOUNT;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NEXP_AMOUNT = dto.NEXP_AMOUNT;
        entity.NGROUP = dto.NGROUP;
        entity.NLOC_AMOUNT = dto.NLOC_AMOUNT;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NVA_TAX = dto.NVA_TAX;
        entity.NVAT_AMOUNT = dto.NVAT_AMOUNT;
        entity.NLOC_COS_RE = dto.NLOC_COS_RE;
        entity.SCESCATAS = dto.SCESCATAS;
        entity.NSETTLECODE = dto.NSETTLECODE;
        entity.SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE;
    }
}
