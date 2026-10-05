using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECTCAUSE_PRECLAIM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REJECTCAUSE_PRECLAIMMappingExtensions
{
    public static REJECTCAUSE_PRECLAIMDto ToDto(this REJECTCAUSE_PRECLAIM entity)
    {
        if (entity == null) return null!;
        return new REJECTCAUSE_PRECLAIMDto
        {
            NIDPRECLAIM = entity.NIDPRECLAIM,
            PRECLAIMSCERTYPE = entity.PRECLAIM?.SCERTYPE,
            NREJECT_CAUSE = entity.NREJECT_CAUSE,
            TABLE9239SDESCRIPT = entity.TABLE9239?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SMESSAGE_REJECT = entity.SMESSAGE_REJECT,
        };
    }

    public static REJECTCAUSE_PRECLAIM ToEntity(this CreateREJECTCAUSE_PRECLAIMDto dto)
    {
        if (dto == null) return null!;
        return new REJECTCAUSE_PRECLAIM
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SMESSAGE_REJECT = dto.SMESSAGE_REJECT,
        };
    }

    public static void UpdateEntity(this REJECTCAUSE_PRECLAIM entity, UpdateREJECTCAUSE_PRECLAIMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SMESSAGE_REJECT = dto.SMESSAGE_REJECT;
    }
}
