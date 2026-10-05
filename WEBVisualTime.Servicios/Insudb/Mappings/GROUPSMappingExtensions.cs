using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class GROUPSMappingExtensions
{
    public static GROUPSDto ToDto(this GROUPS entity)
    {
        if (entity == null) return null!;
        return new GROUPSDto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NGROUP = entity.NGROUP,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            SDESCRIPT = entity.SDESCRIPT,
            NPARTICIP = entity.NPARTICIP,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NPARTICIP_CO = entity.NPARTICIP_CO,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static GROUPS ToEntity(this CreateGROUPSDto dto)
    {
        if (dto == null) return null!;
        return new GROUPS
        {
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            SCLIENT = dto.SCLIENT,
            SDESCRIPT = dto.SDESCRIPT,
            NPARTICIP = dto.NPARTICIP,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NPARTICIP_CO = dto.NPARTICIP_CO,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this GROUPS entity, UpdateGROUPSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCLIENT = dto.SCLIENT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NPARTICIP = dto.NPARTICIP;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPARTICIP_CO = dto.NPARTICIP_CO;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
