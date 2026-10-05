using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class GROUPPARAMSMappingExtensions
{
    public static GROUPPARAMSDto ToDto(this GROUPPARAMS entity)
    {
        if (entity == null) return null!;
        return new GROUPPARAMSDto
        {
            NLETT_GROUP = entity.NLETT_GROUP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            SPARAMETERS = entity.SPARAMETERS,
        };
    }

    public static GROUPPARAMS ToEntity(this CreateGROUPPARAMSDto dto)
    {
        if (dto == null) return null!;
        return new GROUPPARAMS
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            SPARAMETERS = dto.SPARAMETERS,
        };
    }

    public static void UpdateEntity(this GROUPPARAMS entity, UpdateGROUPPARAMSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPARAMETERS = dto.SPARAMETERS;
    }
}
