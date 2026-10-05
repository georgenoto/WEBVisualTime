using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SITUATIONMappingExtensions
{
    public static SITUATIONDto ToDto(this SITUATION entity)
    {
        if (entity == null) return null!;
        return new SITUATIONDto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NSITUATION = entity.NSITUATION,
            NCOD_AGREE = entity.NCOD_AGREE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            NPARTICIP_POLEMP = entity.NPARTICIP_POLEMP,
            NPARTICIP_POLCO = entity.NPARTICIP_POLCO,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
        };
    }

    public static SITUATION ToEntity(this CreateSITUATIONDto dto)
    {
        if (dto == null) return null!;
        return new SITUATION
        {
            SCLIENT = dto.SCLIENT,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            NPARTICIP_POLEMP = dto.NPARTICIP_POLEMP,
            NPARTICIP_POLCO = dto.NPARTICIP_POLCO,
            NTYPCLIENTDOC = dto.NTYPCLIENTDOC,
        };
    }

    public static void UpdateEntity(this SITUATION entity, UpdateSITUATIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPARTICIP_POLEMP = dto.NPARTICIP_POLEMP;
        entity.NPARTICIP_POLCO = dto.NPARTICIP_POLCO;
        entity.NTYPCLIENTDOC = dto.NTYPCLIENTDOC;
    }
}
