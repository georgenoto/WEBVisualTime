using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ACTIONSMappingExtensions
{
    public static ACTIONSDto ToDto(this ACTIONS entity)
    {
        if (entity == null) return null!;
        return new ACTIONSDto
        {
            NACTION = entity.NACTION,
            SCONTROLKEY = entity.SCONTROLKEY,
            SDESCRIPT = entity.SDESCRIPT,
            SHEL_ACTIO = entity.SHEL_ACTIO,
            SSHORT_ACTI = entity.SSHORT_ACTI,
            SSTATREGT = entity.SSTATREGT,
            STYPE_ACTIO = entity.STYPE_ACTIO,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SPATHIMAGE = entity.SPATHIMAGE,
        };
    }

    public static ACTIONS ToEntity(this CreateACTIONSDto dto)
    {
        if (dto == null) return null!;
        return new ACTIONS
        {
            SCONTROLKEY = dto.SCONTROLKEY,
            SDESCRIPT = dto.SDESCRIPT,
            SHEL_ACTIO = dto.SHEL_ACTIO,
            SSHORT_ACTI = dto.SSHORT_ACTI,
            SSTATREGT = dto.SSTATREGT,
            STYPE_ACTIO = dto.STYPE_ACTIO,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SPATHIMAGE = dto.SPATHIMAGE,
        };
    }

    public static void UpdateEntity(this ACTIONS entity, UpdateACTIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCONTROLKEY = dto.SCONTROLKEY;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SHEL_ACTIO = dto.SHEL_ACTIO;
        entity.SSHORT_ACTI = dto.SSHORT_ACTI;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.STYPE_ACTIO = dto.STYPE_ACTIO;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPATHIMAGE = dto.SPATHIMAGE;
    }
}
