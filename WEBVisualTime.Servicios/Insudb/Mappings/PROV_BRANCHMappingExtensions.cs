using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_BRANCH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROV_BRANCHMappingExtensions
{
    public static PROV_BRANCHDto ToDto(this PROV_BRANCH entity)
    {
        if (entity == null) return null!;
        return new PROV_BRANCHDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PROV_BRANCH ToEntity(this CreatePROV_BRANCHDto dto)
    {
        if (dto == null) return null!;
        return new PROV_BRANCH
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PROV_BRANCH entity, UpdatePROV_BRANCHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
