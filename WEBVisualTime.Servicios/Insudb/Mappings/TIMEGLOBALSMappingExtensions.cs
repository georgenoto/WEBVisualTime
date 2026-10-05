using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TIMEGLOBALSMappingExtensions
{
    public static TIMEGLOBALSDto ToDto(this TIMEGLOBALS entity)
    {
        if (entity == null) return null!;
        return new TIMEGLOBALSDto
        {
            SCODE = entity.SCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NTYPEDATA = entity.NTYPEDATA,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TIMEGLOBALS ToEntity(this CreateTIMEGLOBALSDto dto)
    {
        if (dto == null) return null!;
        return new TIMEGLOBALS
        {
            DCOMPDATE = dto.DCOMPDATE,
            NTYPEDATA = dto.NTYPEDATA,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TIMEGLOBALS entity, UpdateTIMEGLOBALSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NTYPEDATA = dto.NTYPEDATA;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
