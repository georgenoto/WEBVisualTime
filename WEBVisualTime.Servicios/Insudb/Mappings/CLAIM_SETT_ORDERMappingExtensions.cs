using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_ORDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETT_ORDERMappingExtensions
{
    public static CLAIM_SETT_ORDERDto ToDto(this CLAIM_SETT_ORDER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETT_ORDERDto
        {
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            CLAIM_SETTLEMENTSCLIENT2 = entity.CLAIM_SETTLEMENT?.SCLIENT2,
            NORDER_NUM = entity.NORDER_NUM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NAMOUNT_ORDEN = entity.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = entity.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = entity.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = entity.NAMOUNT_PAY,
            NAMOUNT_VAT = entity.NAMOUNT_VAT,
            NAMOUNT_FTT = entity.NAMOUNT_FTT,
            NAMOUNT_AGREE = entity.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = entity.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = entity.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = entity.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = entity.NAMOUNT_FTT_LOSS,
            NAMOUNT_BASE = entity.NAMOUNT_BASE,
        };
    }

    public static CLAIM_SETT_ORDER ToEntity(this CreateCLAIM_SETT_ORDERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETT_ORDER
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = dto.NAMOUNT_PAY,
            NAMOUNT_VAT = dto.NAMOUNT_VAT,
            NAMOUNT_FTT = dto.NAMOUNT_FTT,
            NAMOUNT_AGREE = dto.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS,
            NAMOUNT_BASE = dto.NAMOUNT_BASE,
        };
    }

    public static void UpdateEntity(this CLAIM_SETT_ORDER entity, UpdateCLAIM_SETT_ORDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN;
        entity.NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL;
        entity.NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN;
        entity.NAMOUNT_PAY = dto.NAMOUNT_PAY;
        entity.NAMOUNT_VAT = dto.NAMOUNT_VAT;
        entity.NAMOUNT_FTT = dto.NAMOUNT_FTT;
        entity.NAMOUNT_AGREE = dto.NAMOUNT_AGREE;
        entity.NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST;
        entity.NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY;
        entity.NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS;
        entity.NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS;
        entity.NAMOUNT_BASE = dto.NAMOUNT_BASE;
    }
}
