using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALBENEFITS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MEDICALBENEFITSMappingExtensions
{
    public static MEDICALBENEFITSDto ToDto(this MEDICALBENEFITS entity)
    {
        if (entity == null) return null!;
        return new MEDICALBENEFITSDto
        {
            SBENEFIT = entity.SBENEFIT,
            STYPEBENEFIT = entity.STYPEBENEFIT,
            TABLE8600SDESCRIPT = entity.TABLE8600?.SDESCRIPT,
            SBENEFITCLAS = entity.SBENEFITCLAS,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NIND_PACKAGE = entity.NIND_PACKAGE,
            TABLE23SDESCRIPT = entity.TABLE23?.SDESCRIPT,
        };
    }

    public static MEDICALBENEFITS ToEntity(this CreateMEDICALBENEFITSDto dto)
    {
        if (dto == null) return null!;
        return new MEDICALBENEFITS
        {
            STYPEBENEFIT = dto.STYPEBENEFIT,
            SBENEFITCLAS = dto.SBENEFITCLAS,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NIND_PACKAGE = dto.NIND_PACKAGE,
        };
    }

    public static void UpdateEntity(this MEDICALBENEFITS entity, UpdateMEDICALBENEFITSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STYPEBENEFIT = dto.STYPEBENEFIT;
        entity.SBENEFITCLAS = dto.SBENEFITCLAS;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NIND_PACKAGE = dto.NIND_PACKAGE;
    }
}
