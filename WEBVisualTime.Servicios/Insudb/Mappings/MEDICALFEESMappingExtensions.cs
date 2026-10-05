using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALFEES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MEDICALFEESMappingExtensions
{
    public static MEDICALFEESDto ToDto(this MEDICALFEES entity)
    {
        if (entity == null) return null!;
        return new MEDICALFEESDto
        {
            NIDMEDICALFEE = entity.NIDMEDICALFEE,
            SBENEFITCODE = entity.SBENEFITCODE,
            DEFFECDATE = entity.DEFFECDATE,
            NVALUE = entity.NVALUE,
            NCURRENCY = entity.NCURRENCY,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SHOMOLOG_BENEFIT = entity.SHOMOLOG_BENEFIT,
        };
    }

    public static MEDICALFEES ToEntity(this CreateMEDICALFEESDto dto)
    {
        if (dto == null) return null!;
        return new MEDICALFEES
        {
            NVALUE = dto.NVALUE,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SHOMOLOG_BENEFIT = dto.SHOMOLOG_BENEFIT,
        };
    }

    public static void UpdateEntity(this MEDICALFEES entity, UpdateMEDICALFEESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NVALUE = dto.NVALUE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SHOMOLOG_BENEFIT = dto.SHOMOLOG_BENEFIT;
    }
}
