using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ODWA_HELP_NODESMappingExtensions
{
    public static ODWA_HELP_NODESDto ToDto(this ODWA_HELP_NODES entity)
    {
        if (entity == null) return null!;
        return new ODWA_HELP_NODESDto
        {
            ID = entity.ID,
            PARENT_NODE = entity.PARENT_NODE,
            SEQ_IN_PARENT = entity.SEQ_IN_PARENT,
            TREE_LEVEL = entity.TREE_LEVEL,
            DISPLAY_LABEL = entity.DISPLAY_LABEL,
            HIM_ID = entity.HIM_ID,
        };
    }

    public static ODWA_HELP_NODES ToEntity(this CreateODWA_HELP_NODESDto dto)
    {
        if (dto == null) return null!;
        return new ODWA_HELP_NODES
        {
            PARENT_NODE = dto.PARENT_NODE,
            SEQ_IN_PARENT = dto.SEQ_IN_PARENT,
            TREE_LEVEL = dto.TREE_LEVEL,
            DISPLAY_LABEL = dto.DISPLAY_LABEL,
            HIM_ID = dto.HIM_ID,
        };
    }

    public static void UpdateEntity(this ODWA_HELP_NODES entity, UpdateODWA_HELP_NODESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.PARENT_NODE = dto.PARENT_NODE;
        entity.SEQ_IN_PARENT = dto.SEQ_IN_PARENT;
        entity.TREE_LEVEL = dto.TREE_LEVEL;
        entity.DISPLAY_LABEL = dto.DISPLAY_LABEL;
        entity.HIM_ID = dto.HIM_ID;
    }
}
