using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FN_INSTITUTION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_FN_INSTITUTIONMappingExtensions
{
    public static TAB_FN_INSTITUTIONDto ToDto(this TAB_FN_INSTITUTION entity)
    {
        if (entity == null) return null!;
        return new TAB_FN_INSTITUTIONDto
        {
            NINSTITUTION = entity.NINSTITUTION,
            NTYPEINSTITU = entity.NTYPEINSTITU,
            TABLE5634SDESCRIPT = entity.TABLE5634?.SDESCRIPT,
            SNAME = entity.SNAME,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
            SINSTITUTION = entity.SINSTITUTION,
            SCLIENT = entity.SCLIENT,
            SDIGIT = entity.SDIGIT,
        };
    }

    public static TAB_FN_INSTITUTION ToEntity(this CreateTAB_FN_INSTITUTIONDto dto)
    {
        if (dto == null) return null!;
        return new TAB_FN_INSTITUTION
        {
            NTYPEINSTITU = dto.NTYPEINSTITU,
            SNAME = dto.SNAME,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
            SINSTITUTION = dto.SINSTITUTION,
            SCLIENT = dto.SCLIENT,
            SDIGIT = dto.SDIGIT,
        };
    }

    public static void UpdateEntity(this TAB_FN_INSTITUTION entity, UpdateTAB_FN_INSTITUTIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEINSTITU = dto.NTYPEINSTITU;
        entity.SNAME = dto.SNAME;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SINSTITUTION = dto.SINSTITUTION;
        entity.SCLIENT = dto.SCLIENT;
        entity.SDIGIT = dto.SDIGIT;
    }
}
