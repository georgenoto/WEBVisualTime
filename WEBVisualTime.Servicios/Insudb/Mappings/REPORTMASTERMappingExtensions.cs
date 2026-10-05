using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTMASTER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REPORTMASTERMappingExtensions
{
    public static REPORTMASTERDto ToDto(this REPORTMASTER entity)
    {
        if (entity == null) return null!;
        return new REPORTMASTERDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCOD_AGREE = entity.NCOD_AGREE,
            SCODE_REPORT = entity.SCODE_REPORT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static REPORTMASTER ToEntity(this CreateREPORTMASTERDto dto)
    {
        if (dto == null) return null!;
        return new REPORTMASTER
        {
            SCODE_REPORT = dto.SCODE_REPORT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this REPORTMASTER entity, UpdateREPORTMASTERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODE_REPORT = dto.SCODE_REPORT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
