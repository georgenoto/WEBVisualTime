using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECT_CAUSE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REJECT_CAUSEMappingExtensions
{
    public static REJECT_CAUSEDto ToDto(this REJECT_CAUSE entity)
    {
        if (entity == null) return null!;
        return new REJECT_CAUSEDto
        {
            NREJECTCAUSE = entity.NREJECTCAUSE,
            NBANK_CODE = entity.NBANK_CODE,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SNO_ENDEAVOUR = entity.SNO_ENDEAVOUR,
        };
    }

    public static REJECT_CAUSE ToEntity(this CreateREJECT_CAUSEDto dto)
    {
        if (dto == null) return null!;
        return new REJECT_CAUSE
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SNO_ENDEAVOUR = dto.SNO_ENDEAVOUR,
        };
    }

    public static void UpdateEntity(this REJECT_CAUSE entity, UpdateREJECT_CAUSEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SNO_ENDEAVOUR = dto.SNO_ENDEAVOUR;
    }
}
