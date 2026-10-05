using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_STATE_SAAPV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_STATE_SAAPVMappingExtensions
{
    public static TAB_STATE_SAAPVDto ToDto(this TAB_STATE_SAAPV entity)
    {
        if (entity == null) return null!;
        return new TAB_STATE_SAAPVDto
        {
            NTYPE_SAAPV = entity.NTYPE_SAAPV,
            NTYPE_STATE_ORIGI = entity.NTYPE_STATE_ORIGI,
            NTYPE_STATE_END = entity.NTYPE_STATE_END,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TAB_STATE_SAAPV ToEntity(this CreateTAB_STATE_SAAPVDto dto)
    {
        if (dto == null) return null!;
        return new TAB_STATE_SAAPV
        {
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TAB_STATE_SAAPV entity, UpdateTAB_STATE_SAAPVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
