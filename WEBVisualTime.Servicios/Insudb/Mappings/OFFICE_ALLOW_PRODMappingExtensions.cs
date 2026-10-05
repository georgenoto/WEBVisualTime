using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OFFICE_ALLOW_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class OFFICE_ALLOW_PRODMappingExtensions
{
    public static OFFICE_ALLOW_PRODDto ToDto(this OFFICE_ALLOW_PROD entity)
    {
        if (entity == null) return null!;
        return new OFFICE_ALLOW_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NOFFICE_PROD = entity.NOFFICE_PROD,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
        };
    }

    public static OFFICE_ALLOW_PROD ToEntity(this CreateOFFICE_ALLOW_PRODDto dto)
    {
        if (dto == null) return null!;
        return new OFFICE_ALLOW_PROD
        {
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
        };
    }

    public static void UpdateEntity(this OFFICE_ALLOW_PROD entity, UpdateOFFICE_ALLOW_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
    }
}
