using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DOCU;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_DOCUMappingExtensions
{
    public static TAB_DOCUDto ToDto(this TAB_DOCU entity)
    {
        if (entity == null) return null!;
        return new TAB_DOCUDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NDOC_CODE = entity.NDOC_CODE,
            NPRODUCT = entity.NPRODUCT,
            NCOVER = entity.NCOVER,
            NMODULEC = entity.NMODULEC,
            NCAUSECOD = entity.NCAUSECOD,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SCLAIMPAY = entity.SCLAIMPAY,
            NDAYS_PRESC = entity.NDAYS_PRESC,
            STEXT = entity.STEXT,
            SREQUIERED = entity.SREQUIERED,
            NPERSON_TYP = entity.NPERSON_TYP,
            NDOC_TYPE = entity.NDOC_TYPE,
            TABLE9217SDESCRIPT = entity.TABLE9217?.SDESCRIPT,
        };
    }

    public static TAB_DOCU ToEntity(this CreateTAB_DOCUDto dto)
    {
        if (dto == null) return null!;
        return new TAB_DOCU
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SCLAIMPAY = dto.SCLAIMPAY,
            NDAYS_PRESC = dto.NDAYS_PRESC,
            STEXT = dto.STEXT,
            SREQUIERED = dto.SREQUIERED,
            NPERSON_TYP = dto.NPERSON_TYP,
            NDOC_TYPE = dto.NDOC_TYPE,
        };
    }

    public static void UpdateEntity(this TAB_DOCU entity, UpdateTAB_DOCUDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCLAIMPAY = dto.SCLAIMPAY;
        entity.NDAYS_PRESC = dto.NDAYS_PRESC;
        entity.STEXT = dto.STEXT;
        entity.SREQUIERED = dto.SREQUIERED;
        entity.NPERSON_TYP = dto.NPERSON_TYP;
        entity.NDOC_TYPE = dto.NDOC_TYPE;
    }
}
