using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_GROUP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BENEFITS_GROUPMappingExtensions
{
    public static BENEFITS_GROUPDto ToDto(this BENEFITS_GROUP entity)
    {
        if (entity == null) return null!;
        return new BENEFITS_GROUPDto
        {
            SBENEFITGROUP = entity.SBENEFITGROUP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTYPE_GROUP = entity.NTYPE_GROUP,
            TABLE8606SDESCRIPT = entity.TABLE8606?.SDESCRIPT,
            SCLARIFICACT = entity.SCLARIFICACT,
        };
    }

    public static BENEFITS_GROUP ToEntity(this CreateBENEFITS_GROUPDto dto)
    {
        if (dto == null) return null!;
        return new BENEFITS_GROUP
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTYPE_GROUP = dto.NTYPE_GROUP,
            SCLARIFICACT = dto.SCLARIFICACT,
        };
    }

    public static void UpdateEntity(this BENEFITS_GROUP entity, UpdateBENEFITS_GROUPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPE_GROUP = dto.NTYPE_GROUP;
        entity.SCLARIFICACT = dto.SCLARIFICACT;
    }
}
