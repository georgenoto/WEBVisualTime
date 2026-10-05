using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOC_REQ_CLI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DOC_REQ_CLIMappingExtensions
{
    public static DOC_REQ_CLIDto ToDto(this DOC_REQ_CLI entity)
    {
        if (entity == null) return null!;
        return new DOC_REQ_CLIDto
        {
            NEVAL = entity.NEVAL,
            EVAL_MASTERSCERTYPE = entity.EVAL_MASTER?.SCERTYPE,
            NID = entity.NID,
            NTYPEDOC = entity.NTYPEDOC,
            TABLE32SDESCRIPT = entity.TABLE32?.SDESCRIPT,
            NSTATUSDOC = entity.NSTATUSDOC,
            TABLE275SDESCRIPT = entity.TABLE275?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            DDOCREQ = entity.DDOCREQ,
            DDOCREC = entity.DDOCREC,
            DDOCDATE = entity.DDOCDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NCAPITAL = entity.NCAPITAL,
            NNOTENUM = entity.NNOTENUM,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DCOMPDATE = entity.DCOMPDATE,
            DDATETO = entity.DDATETO,
            DDATEFREE = entity.DDATEFREE,
            SREQUEST = entity.SREQUEST,
        };
    }

    public static DOC_REQ_CLI ToEntity(this CreateDOC_REQ_CLIDto dto)
    {
        if (dto == null) return null!;
        return new DOC_REQ_CLI
        {
            NTYPEDOC = dto.NTYPEDOC,
            NSTATUSDOC = dto.NSTATUSDOC,
            SDESCRIPT = dto.SDESCRIPT,
            DDOCREQ = dto.DDOCREQ,
            DDOCREC = dto.DDOCREC,
            DDOCDATE = dto.DDOCDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NCAPITAL = dto.NCAPITAL,
            NNOTENUM = dto.NNOTENUM,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DDATETO = dto.DDATETO,
            DDATEFREE = dto.DDATEFREE,
            SREQUEST = dto.SREQUEST,
        };
    }

    public static void UpdateEntity(this DOC_REQ_CLI entity, UpdateDOC_REQ_CLIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEDOC = dto.NTYPEDOC;
        entity.NSTATUSDOC = dto.NSTATUSDOC;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DDOCREQ = dto.DDOCREQ;
        entity.DDOCREC = dto.DDOCREC;
        entity.DDOCDATE = dto.DDOCDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDATETO = dto.DDATETO;
        entity.DDATEFREE = dto.DDATEFREE;
        entity.SREQUEST = dto.SREQUEST;
    }
}
