using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER_ORDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_VOUCHER_ORDERMappingExtensions
{
    public static CLAIM_VOUCHER_ORDERDto ToDto(this CLAIM_VOUCHER_ORDER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_VOUCHER_ORDERDto
        {
            NCLAIM_VOUCHER = entity.NCLAIM_VOUCHER,
            CLAIM_VOUCHERSCLINUMDOCU = entity.CLAIM_VOUCHER?.SCLINUMDOCU,
            NORDER_NUM = entity.NORDER_NUM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBORDEREAUX_CL = entity.NBORDEREAUX_CL,
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
        };
    }

    public static CLAIM_VOUCHER_ORDER ToEntity(this CreateCLAIM_VOUCHER_ORDERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_VOUCHER_ORDER
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBORDEREAUX_CL = dto.NBORDEREAUX_CL,
            NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM,
        };
    }

    public static void UpdateEntity(this CLAIM_VOUCHER_ORDER entity, UpdateCLAIM_VOUCHER_ORDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBORDEREAUX_CL = dto.NBORDEREAUX_CL;
        entity.NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM;
    }
}
