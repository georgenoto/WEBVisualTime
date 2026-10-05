using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROVISION_TYPEMappingExtensions
{
    public static PROVISION_TYPEDto ToDto(this PROVISION_TYPE entity)
    {
        if (entity == null) return null!;
        return new PROVISION_TYPEDto
        {
            NIDPROVISIONTYPE = entity.NIDPROVISIONTYPE,
            SNAME = entity.SNAME,
            SENABLE = entity.SENABLE,
            SMANEJAUF = entity.SMANEJAUF,
        };
    }

    public static PROVISION_TYPE ToEntity(this CreatePROVISION_TYPEDto dto)
    {
        if (dto == null) return null!;
        return new PROVISION_TYPE
        {
            SNAME = dto.SNAME,
            SENABLE = dto.SENABLE,
            SMANEJAUF = dto.SMANEJAUF,
        };
    }

    public static void UpdateEntity(this PROVISION_TYPE entity, UpdatePROVISION_TYPEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.SENABLE = dto.SENABLE;
        entity.SMANEJAUF = dto.SMANEJAUF;
    }
}
