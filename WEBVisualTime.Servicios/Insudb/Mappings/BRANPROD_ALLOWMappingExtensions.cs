using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BRANPROD_ALLOW;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BRANPROD_ALLOWMappingExtensions
{
    public static BRANPROD_ALLOWDto ToDto(this BRANPROD_ALLOW entity)
    {
        if (entity == null) return null!;
        return new BRANPROD_ALLOWDto
        {
            NINTERMED = entity.NINTERMED,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NMODULEC = entity.NMODULEC,
            NINSTALLMENTS = entity.NINSTALLMENTS,
            NSTARTMONTH = entity.NSTARTMONTH,
            NENDMONTH = entity.NENDMONTH,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NNOTE_INT = entity.NNOTE_INT,
            NCATEGORY = entity.NCATEGORY,
            TABLE9202SDESCRIPT = entity.TABLE9202?.SDESCRIPT,
        };
    }

    public static BRANPROD_ALLOW ToEntity(this CreateBRANPROD_ALLOWDto dto)
    {
        if (dto == null) return null!;
        return new BRANPROD_ALLOW
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NNOTE_INT = dto.NNOTE_INT,
            NCATEGORY = dto.NCATEGORY,
        };
    }

    public static void UpdateEntity(this BRANPROD_ALLOW entity, UpdateBRANPROD_ALLOWDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NNOTE_INT = dto.NNOTE_INT;
        entity.NCATEGORY = dto.NCATEGORY;
    }
}
