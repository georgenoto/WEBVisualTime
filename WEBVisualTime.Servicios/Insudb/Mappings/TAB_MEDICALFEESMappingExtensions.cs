using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDICALFEES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MEDICALFEESMappingExtensions
{
    public static TAB_MEDICALFEESDto ToDto(this TAB_MEDICALFEES entity)
    {
        if (entity == null) return null!;
        return new TAB_MEDICALFEESDto
        {
            NIDMEDICALFEE = entity.NIDMEDICALFEE,
            NOFFICE = entity.NOFFICE,
            NPROVIDER = entity.NPROVIDER,
            NCENTPROVIDER = entity.NCENTPROVIDER,
            SDESCRIPT = entity.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TAB_MEDICALFEES ToEntity(this CreateTAB_MEDICALFEESDto dto)
    {
        if (dto == null) return null!;
        return new TAB_MEDICALFEES
        {
            SDESCRIPT = dto.SDESCRIPT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TAB_MEDICALFEES entity, UpdateTAB_MEDICALFEESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
