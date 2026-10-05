using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CI_ELEMENT_TYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CI_ELEMENT_TYPESMappingExtensions
{
    public static CI_ELEMENT_TYPESDto ToDto(this CI_ELEMENT_TYPES entity)
    {
        if (entity == null) return null!;
        return new CI_ELEMENT_TYPESDto
        {
            NAME = entity.NAME,
            SHORT_NAME = entity.SHORT_NAME,
            EL_TYPE_OF = entity.EL_TYPE_OF,
            PRODUCT = entity.PRODUCT,
            RELEASE = entity.RELEASE,
            PACK_GEN = entity.PACK_GEN,
            VIEW_GEN = entity.VIEW_GEN,
            SUPERTYPE = entity.SUPERTYPE,
            PARENT = entity.PARENT,
            ADDED_TYPE = entity.ADDED_TYPE,
            EXTENSIBLE = entity.EXTENSIBLE,
        };
    }

    public static CI_ELEMENT_TYPES ToEntity(this CreateCI_ELEMENT_TYPESDto dto)
    {
        if (dto == null) return null!;
        return new CI_ELEMENT_TYPES
        {
            NAME = dto.NAME,
            SHORT_NAME = dto.SHORT_NAME,
            EL_TYPE_OF = dto.EL_TYPE_OF,
            PRODUCT = dto.PRODUCT,
            RELEASE = dto.RELEASE,
            PACK_GEN = dto.PACK_GEN,
            VIEW_GEN = dto.VIEW_GEN,
            SUPERTYPE = dto.SUPERTYPE,
            PARENT = dto.PARENT,
            ADDED_TYPE = dto.ADDED_TYPE,
            EXTENSIBLE = dto.EXTENSIBLE,
        };
    }

    public static void UpdateEntity(this CI_ELEMENT_TYPES entity, UpdateCI_ELEMENT_TYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAME = dto.NAME;
        entity.SHORT_NAME = dto.SHORT_NAME;
        entity.EL_TYPE_OF = dto.EL_TYPE_OF;
        entity.PRODUCT = dto.PRODUCT;
        entity.RELEASE = dto.RELEASE;
        entity.PACK_GEN = dto.PACK_GEN;
        entity.VIEW_GEN = dto.VIEW_GEN;
        entity.SUPERTYPE = dto.SUPERTYPE;
        entity.PARENT = dto.PARENT;
        entity.ADDED_TYPE = dto.ADDED_TYPE;
        entity.EXTENSIBLE = dto.EXTENSIBLE;
    }
}
