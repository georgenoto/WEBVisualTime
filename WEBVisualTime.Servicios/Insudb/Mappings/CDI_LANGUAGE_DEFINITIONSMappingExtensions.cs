using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_LANGUAGE_DEFINITIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_LANGUAGE_DEFINITIONSMappingExtensions
{
    public static CDI_LANGUAGE_DEFINITIONSDto ToDto(this CDI_LANGUAGE_DEFINITIONS entity)
    {
        if (entity == null) return null!;
        return new CDI_LANGUAGE_DEFINITIONSDto
        {
            LAN_IRID = entity.LAN_IRID,
            LAN_IVID = entity.LAN_IVID,
            LAN_NAME = entity.LAN_NAME,
            LAN_SOURCE_DIRECTORY = entity.LAN_SOURCE_DIRECTORY,
            LAN_RUNTIME_DIRECTORY = entity.LAN_RUNTIME_DIRECTORY,
            LAN_PROGRAMATICAL = entity.LAN_PROGRAMATICAL,
            LAN_TYPE = entity.LAN_TYPE,
            LAN_COMMAND_LINE = entity.LAN_COMMAND_LINE,
            LAN_GENERATABLE_FLAG = entity.LAN_GENERATABLE_FLAG,
            LAN_INTERNAL_NAME = entity.LAN_INTERNAL_NAME,
            LAN_OBM_FLAG = entity.LAN_OBM_FLAG,
        };
    }

    public static CDI_LANGUAGE_DEFINITIONS ToEntity(this CreateCDI_LANGUAGE_DEFINITIONSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_LANGUAGE_DEFINITIONS
        {
            LAN_IRID = dto.LAN_IRID,
            LAN_IVID = dto.LAN_IVID,
            LAN_NAME = dto.LAN_NAME,
            LAN_SOURCE_DIRECTORY = dto.LAN_SOURCE_DIRECTORY,
            LAN_RUNTIME_DIRECTORY = dto.LAN_RUNTIME_DIRECTORY,
            LAN_PROGRAMATICAL = dto.LAN_PROGRAMATICAL,
            LAN_TYPE = dto.LAN_TYPE,
            LAN_COMMAND_LINE = dto.LAN_COMMAND_LINE,
            LAN_GENERATABLE_FLAG = dto.LAN_GENERATABLE_FLAG,
            LAN_INTERNAL_NAME = dto.LAN_INTERNAL_NAME,
            LAN_OBM_FLAG = dto.LAN_OBM_FLAG,
        };
    }

    public static void UpdateEntity(this CDI_LANGUAGE_DEFINITIONS entity, UpdateCDI_LANGUAGE_DEFINITIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.LAN_IRID = dto.LAN_IRID;
        entity.LAN_IVID = dto.LAN_IVID;
        entity.LAN_NAME = dto.LAN_NAME;
        entity.LAN_SOURCE_DIRECTORY = dto.LAN_SOURCE_DIRECTORY;
        entity.LAN_RUNTIME_DIRECTORY = dto.LAN_RUNTIME_DIRECTORY;
        entity.LAN_PROGRAMATICAL = dto.LAN_PROGRAMATICAL;
        entity.LAN_TYPE = dto.LAN_TYPE;
        entity.LAN_COMMAND_LINE = dto.LAN_COMMAND_LINE;
        entity.LAN_GENERATABLE_FLAG = dto.LAN_GENERATABLE_FLAG;
        entity.LAN_INTERNAL_NAME = dto.LAN_INTERNAL_NAME;
        entity.LAN_OBM_FLAG = dto.LAN_OBM_FLAG;
    }
}
