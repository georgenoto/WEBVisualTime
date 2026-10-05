using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPESUBTYPE_RELATIONSHIP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TYPESUBTYPE_RELATIONSHIPMappingExtensions
{
    public static TYPESUBTYPE_RELATIONSHIPDto ToDto(this TYPESUBTYPE_RELATIONSHIP entity)
    {
        if (entity == null) return null!;
        return new TYPESUBTYPE_RELATIONSHIPDto
        {
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            SCARECLASS = entity.SCARECLASS,
            TABLE8605SDESCRIPT = entity.TABLE8605?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
        };
    }

    public static TYPESUBTYPE_RELATIONSHIP ToEntity(this CreateTYPESUBTYPE_RELATIONSHIPDto dto)
    {
        if (dto == null) return null!;
        return new TYPESUBTYPE_RELATIONSHIP
        {
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TYPESUBTYPE_RELATIONSHIP entity, UpdateTYPESUBTYPE_RELATIONSHIPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
