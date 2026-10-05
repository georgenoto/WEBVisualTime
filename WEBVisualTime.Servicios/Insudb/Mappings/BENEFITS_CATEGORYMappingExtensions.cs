using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BENEFITS_CATEGORYMappingExtensions
{
    public static BENEFITS_CATEGORYDto ToDto(this BENEFITS_CATEGORY entity)
    {
        if (entity == null) return null!;
        return new BENEFITS_CATEGORYDto
        {
            NBENEFCATEG = entity.NBENEFCATEG,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            STABLEASOC = entity.STABLEASOC,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static BENEFITS_CATEGORY ToEntity(this CreateBENEFITS_CATEGORYDto dto)
    {
        if (dto == null) return null!;
        return new BENEFITS_CATEGORY
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            STABLEASOC = dto.STABLEASOC,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this BENEFITS_CATEGORY entity, UpdateBENEFITS_CATEGORYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.STABLEASOC = dto.STABLEASOC;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
