using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REPORT_PRODMappingExtensions
{
    public static REPORT_PRODDto ToDto(this REPORT_PROD entity)
    {
        if (entity == null) return null!;
        return new REPORT_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            DEFFECDATE = entity.DEFFECDATE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NREPTYPE = entity.NREPTYPE,
            NTRATYPEP = entity.NTRATYPEP,
            SREPORT = entity.SREPORT,
        };
    }

    public static REPORT_PROD ToEntity(this CreateREPORT_PRODDto dto)
    {
        if (dto == null) return null!;
        return new REPORT_PROD
        {
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NREPTYPE = dto.NREPTYPE,
            SREPORT = dto.SREPORT,
        };
    }

    public static void UpdateEntity(this REPORT_PROD entity, UpdateREPORT_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NREPTYPE = dto.NREPTYPE;
        entity.SREPORT = dto.SREPORT;
    }
}
