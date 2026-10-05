using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONSHIP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RELATIONSHIPMappingExtensions
{
    public static RELATIONSHIPDto ToDto(this RELATIONSHIP entity)
    {
        if (entity == null) return null!;
        return new RELATIONSHIPDto
        {
            NIDRELATIONSHIP = entity.NIDRELATIONSHIP,
            SNAME = entity.SNAME,
            SENABLE = entity.SENABLE,
        };
    }

    public static RELATIONSHIP ToEntity(this CreateRELATIONSHIPDto dto)
    {
        if (dto == null) return null!;
        return new RELATIONSHIP
        {
            SNAME = dto.SNAME,
            SENABLE = dto.SENABLE,
        };
    }

    public static void UpdateEntity(this RELATIONSHIP entity, UpdateRELATIONSHIPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.SENABLE = dto.SENABLE;
    }
}
