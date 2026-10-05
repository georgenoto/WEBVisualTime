using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_ADDITIONALS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLORDER_ADDITIONALSMappingExtensions
{
    public static CLORDER_ADDITIONALSDto ToDto(this CLORDER_ADDITIONALS entity)
    {
        if (entity == null) return null!;
        return new CLORDER_ADDITIONALSDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_ORDERNCLAIMSTYPECARE = entity.CLAIM_ORDERNCLAIM?.STYPECARE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_ORDERNCASE_NUMSTYPECARE = entity.CLAIM_ORDERNCASE_NUM?.STYPECARE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_ORDERNDEMAN_TYPESTYPECARE = entity.CLAIM_ORDERNDEMAN_TYPE?.STYPECARE,
            NORDER_NUM = entity.NORDER_NUM,
            CLAIM_ORDERNORDER_NUMSTYPECARE = entity.CLAIM_ORDERNORDER_NUM?.STYPECARE,
            NADDITIONAL_ORDER = entity.NADDITIONAL_ORDER,
            SMEDICATION = entity.SMEDICATION,
            NQUANTITYOFMEDICATION = entity.NQUANTITYOFMEDICATION,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CLORDER_ADDITIONALS ToEntity(this CreateCLORDER_ADDITIONALSDto dto)
    {
        if (dto == null) return null!;
        return new CLORDER_ADDITIONALS
        {
            SMEDICATION = dto.SMEDICATION,
            NQUANTITYOFMEDICATION = dto.NQUANTITYOFMEDICATION,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CLORDER_ADDITIONALS entity, UpdateCLORDER_ADDITIONALSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SMEDICATION = dto.SMEDICATION;
        entity.NQUANTITYOFMEDICATION = dto.NQUANTITYOFMEDICATION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
