using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PACKAGE_TABLE_MAP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PACKAGE_TABLE_MAPMappingExtensions
{
    public static PACKAGE_TABLE_MAPDto ToDto(this PACKAGE_TABLE_MAP entity)
    {
        if (entity == null) return null!;
        return new PACKAGE_TABLE_MAPDto
        {
            OWNER = entity.OWNER,
            PACKAGE_NAME = entity.PACKAGE_NAME,
            TABLE_NAME = entity.TABLE_NAME,
        };
    }

    public static PACKAGE_TABLE_MAP ToEntity(this CreatePACKAGE_TABLE_MAPDto dto)
    {
        if (dto == null) return null!;
        return new PACKAGE_TABLE_MAP
        {
            OWNER = dto.OWNER,
            PACKAGE_NAME = dto.PACKAGE_NAME,
            TABLE_NAME = dto.TABLE_NAME,
        };
    }

    public static void UpdateEntity(this PACKAGE_TABLE_MAP entity, UpdatePACKAGE_TABLE_MAPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.OWNER = dto.OWNER;
        entity.PACKAGE_NAME = dto.PACKAGE_NAME;
        entity.TABLE_NAME = dto.TABLE_NAME;
    }
}
