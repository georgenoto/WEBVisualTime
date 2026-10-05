using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREFS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_DFLT_USER_PREFSMappingExtensions
{
    public static CDI_DFLT_USER_PREFSDto ToDto(this CDI_DFLT_USER_PREFS entity)
    {
        if (entity == null) return null!;
        return new CDI_DFLT_USER_PREFSDto
        {
            P_SNAME = entity.P_SNAME,
            P_CGVERSION = entity.P_CGVERSION,
            SNAME = entity.SNAME,
            NAME = entity.NAME,
            VALUE = entity.VALUE,
            INTERNAL = entity.INTERNAL,
            TYPE = entity.TYPE,
            DESCRIPTION = entity.DESCRIPTION,
        };
    }

    public static CDI_DFLT_USER_PREFS ToEntity(this CreateCDI_DFLT_USER_PREFSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_DFLT_USER_PREFS
        {
            P_SNAME = dto.P_SNAME,
            P_CGVERSION = dto.P_CGVERSION,
            SNAME = dto.SNAME,
            NAME = dto.NAME,
            VALUE = dto.VALUE,
            INTERNAL = dto.INTERNAL,
            TYPE = dto.TYPE,
            DESCRIPTION = dto.DESCRIPTION,
        };
    }

    public static void UpdateEntity(this CDI_DFLT_USER_PREFS entity, UpdateCDI_DFLT_USER_PREFSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.P_SNAME = dto.P_SNAME;
        entity.P_CGVERSION = dto.P_CGVERSION;
        entity.SNAME = dto.SNAME;
        entity.NAME = dto.NAME;
        entity.VALUE = dto.VALUE;
        entity.INTERNAL = dto.INTERNAL;
        entity.TYPE = dto.TYPE;
        entity.DESCRIPTION = dto.DESCRIPTION;
    }
}
