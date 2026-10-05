using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_CLASICO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PL_ASP_CLASICOMappingExtensions
{
    public static PL_ASP_CLASICODto ToDto(this PL_ASP_CLASICO entity)
    {
        if (entity == null) return null!;
        return new PL_ASP_CLASICODto
        {
            NIDPROPERTY = entity.NIDPROPERTY,
            SPROPERTY = entity.SPROPERTY,
            SFORMAT = entity.SFORMAT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PL_ASP_CLASICO ToEntity(this CreatePL_ASP_CLASICODto dto)
    {
        if (dto == null) return null!;
        return new PL_ASP_CLASICO
        {
            NIDPROPERTY = dto.NIDPROPERTY,
            SPROPERTY = dto.SPROPERTY,
            SFORMAT = dto.SFORMAT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PL_ASP_CLASICO entity, UpdatePL_ASP_CLASICODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NIDPROPERTY = dto.NIDPROPERTY;
        entity.SPROPERTY = dto.SPROPERTY;
        entity.SFORMAT = dto.SFORMAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
