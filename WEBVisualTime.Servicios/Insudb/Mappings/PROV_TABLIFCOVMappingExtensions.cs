using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_TABLIFCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROV_TABLIFCOVMappingExtensions
{
    public static PROV_TABLIFCOVDto ToDto(this PROV_TABLIFCOV entity)
    {
        if (entity == null) return null!;
        return new PROV_TABLIFCOVDto
        {
            NCOVERGEN = entity.NCOVERGEN,
            TAB_LIFCOVSCACALFRI = entity.TAB_LIFCOV?.SCACALFRI,
            NCOD_AGREE = entity.NCOD_AGREE,
            AGREEMENTSSTATREGT = entity.AGREEMENT?.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
        };
    }

    public static PROV_TABLIFCOV ToEntity(this CreatePROV_TABLIFCOVDto dto)
    {
        if (dto == null) return null!;
        return new PROV_TABLIFCOV
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PROV_TABLIFCOV entity, UpdatePROV_TABLIFCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
