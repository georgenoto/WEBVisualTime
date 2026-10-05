using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALTEAMS_FEES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MEDICALTEAMS_FEESMappingExtensions
{
    public static MEDICALTEAMS_FEESDto ToDto(this MEDICALTEAMS_FEES entity)
    {
        if (entity == null) return null!;
        return new MEDICALTEAMS_FEESDto
        {
            NOFFICE = entity.NOFFICE,
            NDOCTORROL = entity.NDOCTORROL,
            NORD_PROCEDURE = entity.NORD_PROCEDURE,
            DEFFECDATE = entity.DEFFECDATE,
            NPERCENTAGE = entity.NPERCENTAGE,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MEDICALTEAMS_FEES ToEntity(this CreateMEDICALTEAMS_FEESDto dto)
    {
        if (dto == null) return null!;
        return new MEDICALTEAMS_FEES
        {
            NPERCENTAGE = dto.NPERCENTAGE,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MEDICALTEAMS_FEES entity, UpdateMEDICALTEAMS_FEESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPERCENTAGE = dto.NPERCENTAGE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
