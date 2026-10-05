using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROPERTYLIBRARYMappingExtensions
{
    public static PROPERTYLIBRARYDto ToDto(this PROPERTYLIBRARY entity)
    {
        if (entity == null) return null!;
        return new PROPERTYLIBRARYDto
        {
            NIDPROPERTY = entity.NIDPROPERTY,
            SPROPERTY = entity.SPROPERTY,
            SFORMAT = entity.SFORMAT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PROPERTYLIBRARY ToEntity(this CreatePROPERTYLIBRARYDto dto)
    {
        if (dto == null) return null!;
        return new PROPERTYLIBRARY
        {
            SPROPERTY = dto.SPROPERTY,
            SFORMAT = dto.SFORMAT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PROPERTYLIBRARY entity, UpdatePROPERTYLIBRARYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPROPERTY = dto.SPROPERTY;
        entity.SFORMAT = dto.SFORMAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
