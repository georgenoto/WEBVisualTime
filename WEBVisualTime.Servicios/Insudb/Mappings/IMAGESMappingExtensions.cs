using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.IMAGES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class IMAGESMappingExtensions
{
    public static IMAGESDto ToDto(this IMAGES entity)
    {
        if (entity == null) return null!;
        return new IMAGESDto
        {
            NIMAGENUM = entity.NIMAGENUM,
            DCOMPDATE = entity.DCOMPDATE,
            NCONSEC = entity.NCONSEC,
            SDESCRIPT = entity.SDESCRIPT,
            IIMAGE = entity.IIMAGE,
            DNULLDATE = entity.DNULLDATE,
            NRECTYPE = entity.NRECTYPE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static IMAGES ToEntity(this CreateIMAGESDto dto)
    {
        if (dto == null) return null!;
        return new IMAGES
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            IIMAGE = dto.IIMAGE,
            DNULLDATE = dto.DNULLDATE,
            NRECTYPE = dto.NRECTYPE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this IMAGES entity, UpdateIMAGESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.IIMAGE = dto.IIMAGE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRECTYPE = dto.NRECTYPE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
