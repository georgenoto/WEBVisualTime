using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_FRACTI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PAY_FRACTIMappingExtensions
{
    public static PAY_FRACTIDto ToDto(this PAY_FRACTI entity)
    {
        if (entity == null) return null!;
        return new PAY_FRACTIDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPAYFREQ = entity.NPAYFREQ,
            TABLE36SDESCRIPT = entity.TABLE36?.SDESCRIPT,
            NQUOTA = entity.NQUOTA,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NRATEPAYF = entity.NRATEPAYF,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PAY_FRACTI ToEntity(this CreatePAY_FRACTIDto dto)
    {
        if (dto == null) return null!;
        return new PAY_FRACTI
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NRATEPAYF = dto.NRATEPAYF,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PAY_FRACTI entity, UpdatePAY_FRACTIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRATEPAYF = dto.NRATEPAYF;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
