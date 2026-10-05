using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_PRESCRIPTION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_PRESCRIPTIONMappingExtensions
{
    public static CLAIM_PRESCRIPTIONDto ToDto(this CLAIM_PRESCRIPTION entity)
    {
        if (entity == null) return null!;
        return new CLAIM_PRESCRIPTIONDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NMONTHS = entity.NMONTHS,
            NDAYS = entity.NDAYS,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NCLA_LI_TYP = entity.NCLA_LI_TYP,
        };
    }

    public static CLAIM_PRESCRIPTION ToEntity(this CreateCLAIM_PRESCRIPTIONDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_PRESCRIPTION
        {
            NMONTHS = dto.NMONTHS,
            NDAYS = dto.NDAYS,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this CLAIM_PRESCRIPTION entity, UpdateCLAIM_PRESCRIPTIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NMONTHS = dto.NMONTHS;
        entity.NDAYS = dto.NDAYS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
