using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REFINAN_DRA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REFINAN_DRAMappingExtensions
{
    public static REFINAN_DRADto ToDto(this REFINAN_DRA entity)
    {
        if (entity == null) return null!;
        return new REFINAN_DRADto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NCOMMISSION = entity.NCOMMISSION,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NCONTRAT_D = entity.NCONTRAT_D,
            NCURRENCY = entity.NCURRENCY,
            NDRAFT_D = entity.NDRAFT_D,
            DSTARTDATE = entity.DSTARTDATE,
            NEXCHANGE = entity.NEXCHANGE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NPREMIUM = entity.NPREMIUM,
            SSTAT_FINPR = entity.SSTAT_FINPR,
            SSTATREGT = entity.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NOPT_DRAFT = entity.NOPT_DRAFT,
            TABLE252SDESCRIPT = entity.TABLE252?.SDESCRIPT,
        };
    }

    public static REFINAN_DRA ToEntity(this CreateREFINAN_DRADto dto)
    {
        if (dto == null) return null!;
        return new REFINAN_DRA
        {
            NBRANCH = dto.NBRANCH,
            NCOMMISSION = dto.NCOMMISSION,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            DSTARTDATE = dto.DSTARTDATE,
            NEXCHANGE = dto.NEXCHANGE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NPREMIUM = dto.NPREMIUM,
            SSTAT_FINPR = dto.SSTAT_FINPR,
            SSTATREGT = dto.SSTATREGT,
            SCLIENT = dto.SCLIENT,
            NUSERCODE = dto.NUSERCODE,
            NOPT_DRAFT = dto.NOPT_DRAFT,
        };
    }

    public static void UpdateEntity(this REFINAN_DRA entity, UpdateREFINAN_DRADto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH = dto.NBRANCH;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.SSTAT_FINPR = dto.SSTAT_FINPR;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NOPT_DRAFT = dto.NOPT_DRAFT;
    }
}
