using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTSHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REPORTSHEETMappingExtensions
{
    public static REPORTSHEETDto ToDto(this REPORTSHEET entity)
    {
        if (entity == null) return null!;
        return new REPORTSHEETDto
        {
            SCODE_REPORT = entity.SCODE_REPORT,
            NBOX = entity.NBOX,
            NCOLUMN = entity.NCOLUMN,
            NROW = entity.NROW,
            DEFFECDATE = entity.DEFFECDATE,
            NTYP_SECTION = entity.NTYP_SECTION,
            SCONTENT = entity.SCONTENT,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
        };
    }

    public static REPORTSHEET ToEntity(this CreateREPORTSHEETDto dto)
    {
        if (dto == null) return null!;
        return new REPORTSHEET
        {
            NTYP_SECTION = dto.NTYP_SECTION,
            SCONTENT = dto.SCONTENT,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
        };
    }

    public static void UpdateEntity(this REPORTSHEET entity, UpdateREPORTSHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYP_SECTION = dto.NTYP_SECTION;
        entity.SCONTENT = dto.SCONTENT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
    }
}
