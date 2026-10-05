using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_GROUP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_GROUPMappingExtensions
{
    public static TAB_PROV_GROUPDto ToDto(this TAB_PROV_GROUP entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_GROUPDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NPROV_GROUP = entity.NPROV_GROUP,
            TABLE642SDESCRIPT = entity.TABLE642?.SDESCRIPT,
            DINPDATE = entity.DINPDATE,
            DOUTDATE = entity.DOUTDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_PROV_GROUP ToEntity(this CreateTAB_PROV_GROUPDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_GROUP
        {
            DINPDATE = dto.DINPDATE,
            DOUTDATE = dto.DOUTDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_GROUP entity, UpdateTAB_PROV_GROUPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DINPDATE = dto.DINPDATE;
        entity.DOUTDATE = dto.DOUTDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
