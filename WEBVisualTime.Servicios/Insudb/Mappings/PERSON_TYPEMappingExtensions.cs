using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PERSON_TYPEMappingExtensions
{
    public static PERSON_TYPEDto ToDto(this PERSON_TYPE entity)
    {
        if (entity == null) return null!;
        return new PERSON_TYPEDto
        {
            NIDPERSONTYPE = entity.NIDPERSONTYPE,
            SNAME = entity.SNAME,
            SENABLE = entity.SENABLE,
        };
    }

    public static PERSON_TYPE ToEntity(this CreatePERSON_TYPEDto dto)
    {
        if (dto == null) return null!;
        return new PERSON_TYPE
        {
            SNAME = dto.SNAME,
            SENABLE = dto.SENABLE,
        };
    }

    public static void UpdateEntity(this PERSON_TYPE entity, UpdatePERSON_TYPEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.SENABLE = dto.SENABLE;
    }
}
