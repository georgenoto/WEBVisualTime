using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_NET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PL_ASP_NETMappingExtensions
{
    public static PL_ASP_NETDto ToDto(this PL_ASP_NET entity)
    {
        if (entity == null) return null!;
        return new PL_ASP_NETDto
        {
            NIDPROPERTY = entity.NIDPROPERTY,
            SPROPERTY = entity.SPROPERTY,
            SFORMAT = entity.SFORMAT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PL_ASP_NET ToEntity(this CreatePL_ASP_NETDto dto)
    {
        if (dto == null) return null!;
        return new PL_ASP_NET
        {
            NIDPROPERTY = dto.NIDPROPERTY,
            SPROPERTY = dto.SPROPERTY,
            SFORMAT = dto.SFORMAT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PL_ASP_NET entity, UpdatePL_ASP_NETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NIDPROPERTY = dto.NIDPROPERTY;
        entity.SPROPERTY = dto.SPROPERTY;
        entity.SFORMAT = dto.SFORMAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
