using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.APV_LED_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class APV_LED_ACCMappingExtensions
{
    public static APV_LED_ACCDto ToDto(this APV_LED_ACC entity)
    {
        if (entity == null) return null!;
        return new APV_LED_ACCDto
        {
            NTYPE_MOVE = entity.NTYPE_MOVE,
            NTYP_PROFITWORKER = entity.NTYP_PROFITWORKER,
            SLEDACC = entity.SLEDACC,
            SDESCLED = entity.SDESCLED,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static APV_LED_ACC ToEntity(this CreateAPV_LED_ACCDto dto)
    {
        if (dto == null) return null!;
        return new APV_LED_ACC
        {
            SLEDACC = dto.SLEDACC,
            SDESCLED = dto.SDESCLED,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this APV_LED_ACC entity, UpdateAPV_LED_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SLEDACC = dto.SLEDACC;
        entity.SDESCLED = dto.SDESCLED;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
