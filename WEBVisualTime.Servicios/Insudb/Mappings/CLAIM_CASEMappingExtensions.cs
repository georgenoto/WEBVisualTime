using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_CASEMappingExtensions
{
    public static CLAIM_CASEDto ToDto(this CLAIM_CASE entity)
    {
        if (entity == null) return null!;
        return new CLAIM_CASEDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTACASE = entity.SSTACASE,
            TABLE135SDESCRIPT = entity.TABLE135?.SDESCRIPT,
            NNOTEDAMA = entity.NNOTEDAMA,
            SCLAIM_AFFE = entity.SCLAIM_AFFE,
            NGROWTH_RATEI = entity.NGROWTH_RATEI,
            NGROWTH_RATEE = entity.NGROWTH_RATEE,
            NAPV_CAPITAL = entity.NAPV_CAPITAL,
            DSUMMON_LIMIT = entity.DSUMMON_LIMIT,
            SHAS_SURV_PENSION_BENEFS = entity.SHAS_SURV_PENSION_BENEFS,
            DSUMMON = entity.DSUMMON,
            SAFP_TRANS_TYPE = entity.SAFP_TRANS_TYPE,
            NSTAY_BONUS = entity.NSTAY_BONUS,
            NAPV_BALANCE_BC2052 = entity.NAPV_BALANCE_BC2052,
            NAPV_BALANCE_AC2052 = entity.NAPV_BALANCE_AC2052,
            NTRANSF_AMOUNT = entity.NTRANSF_AMOUNT,
            NAPV_TAX = entity.NAPV_TAX,
            NAPV_BENEF_BALANCE = entity.NAPV_BENEF_BALANCE,
            NAFP = entity.NAFP,
            TABLE5524SDESCRIPT = entity.TABLE5524?.SDESCRIPT,
            NSENDTO_LGM = entity.NSENDTO_LGM,
            DNULLDATE = entity.DNULLDATE,
            NNULLCODE = entity.NNULLCODE,
            TABLE136SDESCRIPT = entity.TABLE136?.SDESCRIPT,
        };
    }

    public static CLAIM_CASE ToEntity(this CreateCLAIM_CASEDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_CASE
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTACASE = dto.SSTACASE,
            NNOTEDAMA = dto.NNOTEDAMA,
            SCLAIM_AFFE = dto.SCLAIM_AFFE,
            NGROWTH_RATEI = dto.NGROWTH_RATEI,
            NGROWTH_RATEE = dto.NGROWTH_RATEE,
            NAPV_CAPITAL = dto.NAPV_CAPITAL,
            DSUMMON_LIMIT = dto.DSUMMON_LIMIT,
            SHAS_SURV_PENSION_BENEFS = dto.SHAS_SURV_PENSION_BENEFS,
            DSUMMON = dto.DSUMMON,
            SAFP_TRANS_TYPE = dto.SAFP_TRANS_TYPE,
            NSTAY_BONUS = dto.NSTAY_BONUS,
            NAPV_BALANCE_BC2052 = dto.NAPV_BALANCE_BC2052,
            NAPV_BALANCE_AC2052 = dto.NAPV_BALANCE_AC2052,
            NTRANSF_AMOUNT = dto.NTRANSF_AMOUNT,
            NAPV_TAX = dto.NAPV_TAX,
            NAPV_BENEF_BALANCE = dto.NAPV_BENEF_BALANCE,
            NAFP = dto.NAFP,
            NSENDTO_LGM = dto.NSENDTO_LGM,
            DNULLDATE = dto.DNULLDATE,
            NNULLCODE = dto.NNULLCODE,
        };
    }

    public static void UpdateEntity(this CLAIM_CASE entity, UpdateCLAIM_CASEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTACASE = dto.SSTACASE;
        entity.NNOTEDAMA = dto.NNOTEDAMA;
        entity.SCLAIM_AFFE = dto.SCLAIM_AFFE;
        entity.NGROWTH_RATEI = dto.NGROWTH_RATEI;
        entity.NGROWTH_RATEE = dto.NGROWTH_RATEE;
        entity.NAPV_CAPITAL = dto.NAPV_CAPITAL;
        entity.DSUMMON_LIMIT = dto.DSUMMON_LIMIT;
        entity.SHAS_SURV_PENSION_BENEFS = dto.SHAS_SURV_PENSION_BENEFS;
        entity.DSUMMON = dto.DSUMMON;
        entity.SAFP_TRANS_TYPE = dto.SAFP_TRANS_TYPE;
        entity.NSTAY_BONUS = dto.NSTAY_BONUS;
        entity.NAPV_BALANCE_BC2052 = dto.NAPV_BALANCE_BC2052;
        entity.NAPV_BALANCE_AC2052 = dto.NAPV_BALANCE_AC2052;
        entity.NTRANSF_AMOUNT = dto.NTRANSF_AMOUNT;
        entity.NAPV_TAX = dto.NAPV_TAX;
        entity.NAPV_BENEF_BALANCE = dto.NAPV_BENEF_BALANCE;
        entity.NAFP = dto.NAFP;
        entity.NSENDTO_LGM = dto.NSENDTO_LGM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNULLCODE = dto.NNULLCODE;
    }
}
