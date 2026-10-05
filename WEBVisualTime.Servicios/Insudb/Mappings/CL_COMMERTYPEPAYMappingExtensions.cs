using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CL_COMMERTYPEPAYMappingExtensions
{
    public static CL_COMMERTYPEPAYDto ToDto(this CL_COMMERTYPEPAY entity)
    {
        if (entity == null) return null!;
        return new CL_COMMERTYPEPAYDto
        {
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            SDESCRIPT = entity.SDESCRIPT,
            SIND_CONTROL = entity.SIND_CONTROL,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CL_COMMERTYPEPAY ToEntity(this CreateCL_COMMERTYPEPAYDto dto)
    {
        if (dto == null) return null!;
        return new CL_COMMERTYPEPAY
        {
            SDESCRIPT = dto.SDESCRIPT,
            SIND_CONTROL = dto.SIND_CONTROL,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CL_COMMERTYPEPAY entity, UpdateCL_COMMERTYPEPAYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SIND_CONTROL = dto.SIND_CONTROL;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
