using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_VOUCHER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETT_VOUCHERMappingExtensions
{
    public static CLAIM_SETT_VOUCHERDto ToDto(this CLAIM_SETT_VOUCHER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETT_VOUCHERDto
        {
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            CLAIM_SETTLEMENTSCLIENT2 = entity.CLAIM_SETTLEMENT?.SCLIENT2,
            NCLAIM_VOUCHER = entity.NCLAIM_VOUCHER,
            CLAIM_VOUCHERSCLINUMDOCU = entity.CLAIM_VOUCHER?.SCLINUMDOCU,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NAMOUNT_TOTAL = entity.NAMOUNT_TOTAL,
            NAMOUNT_PAY = entity.NAMOUNT_PAY,
            NAMOUNT_VAT = entity.NAMOUNT_VAT,
            NAMOUNT_FTT = entity.NAMOUNT_FTT,
            NAMOUNT_AGREE = entity.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = entity.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = entity.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = entity.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = entity.NAMOUNT_FTT_LOSS,
            NTYPEDISC_PROV = entity.NTYPEDISC_PROV,
            TABLE9254SDESCRIPT = entity.TABLE9254?.SDESCRIPT,
            NAMOUNT_BASE = entity.NAMOUNT_BASE,
            NAGREE_DISCOUNT = entity.NAGREE_DISCOUNT,
        };
    }

    public static CLAIM_SETT_VOUCHER ToEntity(this CreateCLAIM_SETT_VOUCHERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETT_VOUCHER
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL,
            NAMOUNT_PAY = dto.NAMOUNT_PAY,
            NAMOUNT_VAT = dto.NAMOUNT_VAT,
            NAMOUNT_FTT = dto.NAMOUNT_FTT,
            NAMOUNT_AGREE = dto.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS,
            NTYPEDISC_PROV = dto.NTYPEDISC_PROV,
            NAMOUNT_BASE = dto.NAMOUNT_BASE,
            NAGREE_DISCOUNT = dto.NAGREE_DISCOUNT,
        };
    }

    public static void UpdateEntity(this CLAIM_SETT_VOUCHER entity, UpdateCLAIM_SETT_VOUCHERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL;
        entity.NAMOUNT_PAY = dto.NAMOUNT_PAY;
        entity.NAMOUNT_VAT = dto.NAMOUNT_VAT;
        entity.NAMOUNT_FTT = dto.NAMOUNT_FTT;
        entity.NAMOUNT_AGREE = dto.NAMOUNT_AGREE;
        entity.NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST;
        entity.NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY;
        entity.NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS;
        entity.NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS;
        entity.NTYPEDISC_PROV = dto.NTYPEDISC_PROV;
        entity.NAMOUNT_BASE = dto.NAMOUNT_BASE;
        entity.NAGREE_DISCOUNT = dto.NAGREE_DISCOUNT;
    }
}
