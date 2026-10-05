using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_PART_CONDITIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASSIVE_PART_CONDITIONSMappingExtensions
{
    public static MASSIVE_PART_CONDITIONSDto ToDto(this MASSIVE_PART_CONDITIONS entity)
    {
        if (entity == null) return null!;
        return new MASSIVE_PART_CONDITIONSDto
        {
            NIDCONDI = entity.NIDCONDI,
            SDESCRIPT = entity.SDESCRIPT,
            SENABLED = entity.SENABLED,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            STYP_CONDI = entity.STYP_CONDI,
            NSECTION = entity.NSECTION,
            NSHEET = entity.NSHEET,
        };
    }

    public static MASSIVE_PART_CONDITIONS ToEntity(this CreateMASSIVE_PART_CONDITIONSDto dto)
    {
        if (dto == null) return null!;
        return new MASSIVE_PART_CONDITIONS
        {
            SDESCRIPT = dto.SDESCRIPT,
            SENABLED = dto.SENABLED,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NSHEET = dto.NSHEET,
        };
    }

    public static void UpdateEntity(this MASSIVE_PART_CONDITIONS entity, UpdateMASSIVE_PART_CONDITIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SENABLED = dto.SENABLED;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NSHEET = dto.NSHEET;
    }
}
