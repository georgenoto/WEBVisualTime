using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_ZONE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_ZONEMappingExtensions
{
    public static TAB_PROV_ZONEDto ToDto(this TAB_PROV_ZONE entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_ZONEDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NZONE = entity.NZONE,
            NORDER = entity.NORDER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DINPDATE = entity.DINPDATE,
            DOUTDATE = entity.DOUTDATE,
        };
    }

    public static TAB_PROV_ZONE ToEntity(this CreateTAB_PROV_ZONEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_ZONE
        {
            NORDER = dto.NORDER,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DINPDATE = dto.DINPDATE,
            DOUTDATE = dto.DOUTDATE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_ZONE entity, UpdateTAB_PROV_ZONEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NORDER = dto.NORDER;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DINPDATE = dto.DINPDATE;
        entity.DOUTDATE = dto.DOUTDATE;
    }
}
