using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_FORMS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_FORMSMappingExtensions
{
    public static CDI_FORMSDto ToDto(this CDI_FORMS entity)
    {
        if (entity == null) return null!;
        return new CDI_FORMSDto
        {
            FRM_FNAME = entity.FRM_FNAME,
            FRM_SEQ = entity.FRM_SEQ,
            FRM_DISP_NAME = entity.FRM_DISP_NAME,
            FRM_DESC = entity.FRM_DESC,
        };
    }

    public static CDI_FORMS ToEntity(this CreateCDI_FORMSDto dto)
    {
        if (dto == null) return null!;
        return new CDI_FORMS
        {
            FRM_FNAME = dto.FRM_FNAME,
            FRM_SEQ = dto.FRM_SEQ,
            FRM_DISP_NAME = dto.FRM_DISP_NAME,
            FRM_DESC = dto.FRM_DESC,
        };
    }

    public static void UpdateEntity(this CDI_FORMS entity, UpdateCDI_FORMSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.FRM_FNAME = dto.FRM_FNAME;
        entity.FRM_SEQ = dto.FRM_SEQ;
        entity.FRM_DISP_NAME = dto.FRM_DISP_NAME;
        entity.FRM_DESC = dto.FRM_DESC;
    }
}
