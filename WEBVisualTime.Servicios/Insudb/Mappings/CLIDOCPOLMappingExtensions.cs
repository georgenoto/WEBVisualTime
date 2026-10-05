using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCPOL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIDOCPOLMappingExtensions
{
    public static CLIDOCPOLDto ToDto(this CLIDOCPOL entity)
    {
        if (entity == null) return null!;
        return new CLIDOCPOLDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            NCLASSTYPDOC = entity.NCLASSTYPDOC,
            FORMATVALUESNCLASSTYPDOCSDESCRIPT = entity.FORMATVALUESNCLASSTYPDOC?.SDESCRIPT,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            FORMATVALUESNTYPCLIENTDOCSDESCRIPT = entity.FORMATVALUESNTYPCLIENTDOC?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            DRECEP_DATE = entity.DRECEP_DATE,
            DDATEVIG = entity.DDATEVIG,
            NSTAT_DOCREQ = entity.NSTAT_DOCREQ,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DLIMIT_DATE = entity.DLIMIT_DATE,
            NID_SECUENCIA = entity.NID_SECUENCIA,
        };
    }

    public static CLIDOCPOL ToEntity(this CreateCLIDOCPOLDto dto)
    {
        if (dto == null) return null!;
        return new CLIDOCPOL
        {
            DNULLDATE = dto.DNULLDATE,
            DRECEP_DATE = dto.DRECEP_DATE,
            DDATEVIG = dto.DDATEVIG,
            NSTAT_DOCREQ = dto.NSTAT_DOCREQ,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DLIMIT_DATE = dto.DLIMIT_DATE,
            NID_SECUENCIA = dto.NID_SECUENCIA,
        };
    }

    public static void UpdateEntity(this CLIDOCPOL entity, UpdateCLIDOCPOLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DRECEP_DATE = dto.DRECEP_DATE;
        entity.DDATEVIG = dto.DDATEVIG;
        entity.NSTAT_DOCREQ = dto.NSTAT_DOCREQ;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DLIMIT_DATE = dto.DLIMIT_DATE;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
    }
}
