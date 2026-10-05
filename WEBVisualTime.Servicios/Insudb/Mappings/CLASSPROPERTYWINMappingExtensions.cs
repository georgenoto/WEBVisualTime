using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLASSPROPERTYWIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLASSPROPERTYWINMappingExtensions
{
    public static CLASSPROPERTYWINDto ToDto(this CLASSPROPERTYWIN entity)
    {
        if (entity == null) return null!;
        return new CLASSPROPERTYWINDto
        {
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NIDCLASS = entity.NIDCLASS,
            NIDPROPERTY = entity.NIDPROPERTY,
            PROPERTYLIBRARYSPROPERTY = entity.PROPERTYLIBRARY?.SPROPERTY,
            SVISIBLE = entity.SVISIBLE,
            NORDEN = entity.NORDEN,
            SCAPTION = entity.SCAPTION,
            DCOMPDATE = entity.DCOMPDATE,
            NWIDTH = entity.NWIDTH,
            NUSERCODE = entity.NUSERCODE,
            SKEY = entity.SKEY,
        };
    }

    public static CLASSPROPERTYWIN ToEntity(this CreateCLASSPROPERTYWINDto dto)
    {
        if (dto == null) return null!;
        return new CLASSPROPERTYWIN
        {
            SVISIBLE = dto.SVISIBLE,
            SCAPTION = dto.SCAPTION,
            DCOMPDATE = dto.DCOMPDATE,
            NWIDTH = dto.NWIDTH,
            NUSERCODE = dto.NUSERCODE,
            SKEY = dto.SKEY,
        };
    }

    public static void UpdateEntity(this CLASSPROPERTYWIN entity, UpdateCLASSPROPERTYWINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SVISIBLE = dto.SVISIBLE;
        entity.SCAPTION = dto.SCAPTION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NWIDTH = dto.NWIDTH;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SKEY = dto.SKEY;
    }
}
