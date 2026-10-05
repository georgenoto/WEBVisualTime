using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CUR_ALLOW;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CUR_ALLOWMappingExtensions
{
    public static CUR_ALLOWDto ToDto(this CUR_ALLOW entity)
    {
        if (entity == null) return null!;
        return new CUR_ALLOWDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCURRENCY = entity.NCURRENCY,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            NUSERCODE = entity.NUSERCODE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
        };
    }

    public static CUR_ALLOW ToEntity(this CreateCUR_ALLOWDto dto)
    {
        if (dto == null) return null!;
        return new CUR_ALLOW
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
        };
    }

    public static void UpdateEntity(this CUR_ALLOW entity, UpdateCUR_ALLOWDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
    }
}
