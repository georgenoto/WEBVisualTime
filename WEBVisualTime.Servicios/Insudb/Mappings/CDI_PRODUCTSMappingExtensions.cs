using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_PRODUCTSMappingExtensions
{
    public static CDI_PRODUCTSDto ToDto(this CDI_PRODUCTS entity)
    {
        if (entity == null) return null!;
        return new CDI_PRODUCTSDto
        {
            SNAME = entity.SNAME,
            NAME = entity.NAME,
            VERSION = entity.VERSION,
        };
    }

    public static CDI_PRODUCTS ToEntity(this CreateCDI_PRODUCTSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_PRODUCTS
        {
            SNAME = dto.SNAME,
            NAME = dto.NAME,
            VERSION = dto.VERSION,
        };
    }

    public static void UpdateEntity(this CDI_PRODUCTS entity, UpdateCDI_PRODUCTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.NAME = dto.NAME;
        entity.VERSION = dto.VERSION;
    }
}
