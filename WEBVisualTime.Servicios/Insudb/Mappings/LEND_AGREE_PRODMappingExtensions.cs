using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LEND_AGREE_PRODMappingExtensions
{
    public static LEND_AGREE_PRODDto ToDto(this LEND_AGREE_PROD entity)
    {
        if (entity == null) return null!;
        return new LEND_AGREE_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCOD_AGREE = entity.NCOD_AGREE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static LEND_AGREE_PROD ToEntity(this CreateLEND_AGREE_PRODDto dto)
    {
        if (dto == null) return null!;
        return new LEND_AGREE_PROD
        {
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this LEND_AGREE_PROD entity, UpdateLEND_AGREE_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
