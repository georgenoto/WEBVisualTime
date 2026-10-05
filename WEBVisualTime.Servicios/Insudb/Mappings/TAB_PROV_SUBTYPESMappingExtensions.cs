using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_SUBTYPES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_SUBTYPESMappingExtensions
{
    public static TAB_PROV_SUBTYPESDto ToDto(this TAB_PROV_SUBTYPES entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_SUBTYPESDto
        {
            NTYPEPROV = entity.NTYPEPROV,
            TABLE7027SDESCRIPT = entity.TABLE7027?.SDESCRIPT,
            NSUBTYPEPROV = entity.NSUBTYPEPROV,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_PROV_SUBTYPES ToEntity(this CreateTAB_PROV_SUBTYPESDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_SUBTYPES
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_SUBTYPES entity, UpdateTAB_PROV_SUBTYPESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
