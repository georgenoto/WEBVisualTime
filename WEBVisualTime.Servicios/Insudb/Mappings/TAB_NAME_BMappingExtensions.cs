using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_NAME_B;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_NAME_BMappingExtensions
{
    public static TAB_NAME_BDto ToDto(this TAB_NAME_B entity)
    {
        if (entity == null) return null!;
        return new TAB_NAME_BDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            STABNAME = entity.STABNAME,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_NAME_B ToEntity(this CreateTAB_NAME_BDto dto)
    {
        if (dto == null) return null!;
        return new TAB_NAME_B
        {
            DCOMPDATE = dto.DCOMPDATE,
            STABNAME = dto.STABNAME,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_NAME_B entity, UpdateTAB_NAME_BDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.STABNAME = dto.STABNAME;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
