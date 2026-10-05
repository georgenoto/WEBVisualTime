using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_PRE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FINANC_PREMappingExtensions
{
    public static FINANC_PREDto ToDto(this FINANC_PRE entity)
    {
        if (entity == null) return null!;
        return new FINANC_PREDto
        {
            NBRANCH = entity.NBRANCH,
            NCOMMISSION = entity.NCOMMISSION,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NCURRENCY = entity.NCURRENCY,
            DSTARTDATE = entity.DSTARTDATE,
            NEXCHANGE = entity.NEXCHANGE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NPOLICY = entity.NPOLICY,
            NPREMIUM = entity.NPREMIUM,
            NRECEIPT = entity.NRECEIPT,
            SSTAT_FINPR = entity.SSTAT_FINPR,
            SSTATREGT = entity.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NPRODUCT = entity.NPRODUCT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            SEXTRECEIPT = entity.SEXTRECEIPT,
        };
    }

    public static FINANC_PRE ToEntity(this CreateFINANC_PREDto dto)
    {
        if (dto == null) return null!;
        return new FINANC_PRE
        {
            NBRANCH = dto.NBRANCH,
            NCOMMISSION = dto.NCOMMISSION,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            DSTARTDATE = dto.DSTARTDATE,
            NEXCHANGE = dto.NEXCHANGE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NINTERMED = dto.NINTERMED,
            NOFFICE = dto.NOFFICE,
            NPOLICY = dto.NPOLICY,
            NPREMIUM = dto.NPREMIUM,
            SSTAT_FINPR = dto.SSTAT_FINPR,
            SSTATREGT = dto.SSTATREGT,
            SCLIENT = dto.SCLIENT,
            NUSERCODE = dto.NUSERCODE,
            NPRODUCT = dto.NPRODUCT,
            NCOMPANY = dto.NCOMPANY,
            SEXTRECEIPT = dto.SEXTRECEIPT,
        };
    }

    public static void UpdateEntity(this FINANC_PRE entity, UpdateFINANC_PREDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH = dto.NBRANCH;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NINTERMED = dto.NINTERMED;
        entity.NOFFICE = dto.NOFFICE;
        entity.NPOLICY = dto.NPOLICY;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.SSTAT_FINPR = dto.SSTAT_FINPR;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.SEXTRECEIPT = dto.SEXTRECEIPT;
    }
}
