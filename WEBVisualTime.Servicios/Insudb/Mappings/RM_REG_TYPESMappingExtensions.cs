using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_REG_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RM_REG_TYPESMappingExtensions
{
    public static RM_REG_TYPESDto ToDto(this RM_REG_TYPES entity)
    {
        if (entity == null) return null!;
        return new RM_REG_TYPESDto
        {
            TABLE_NAME = entity.TABLE_NAME,
            PRODUCT = entity.PRODUCT,
            NAME = entity.NAME,
            SHORT_NAME = entity.SHORT_NAME,
            PLURAL_NAME = entity.PLURAL_NAME,
            NLS_NAME = entity.NLS_NAME,
            NLS_PLURAL_NAME = entity.NLS_PLURAL_NAME,
            USER_EXTENSION = entity.USER_EXTENSION,
            HELP_TAG = entity.HELP_TAG,
        };
    }

    public static RM_REG_TYPES ToEntity(this CreateRM_REG_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new RM_REG_TYPES
        {
            TABLE_NAME = dto.TABLE_NAME,
            SHORT_NAME = dto.SHORT_NAME,
            PLURAL_NAME = dto.PLURAL_NAME,
            NLS_NAME = dto.NLS_NAME,
            NLS_PLURAL_NAME = dto.NLS_PLURAL_NAME,
            USER_EXTENSION = dto.USER_EXTENSION,
            HELP_TAG = dto.HELP_TAG,
        };
    }

    public static void UpdateEntity(this RM_REG_TYPES entity, UpdateRM_REG_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.TABLE_NAME = dto.TABLE_NAME;
        entity.SHORT_NAME = dto.SHORT_NAME;
        entity.PLURAL_NAME = dto.PLURAL_NAME;
        entity.NLS_NAME = dto.NLS_NAME;
        entity.NLS_PLURAL_NAME = dto.NLS_PLURAL_NAME;
        entity.USER_EXTENSION = dto.USER_EXTENSION;
        entity.HELP_TAG = dto.HELP_TAG;
    }
}
