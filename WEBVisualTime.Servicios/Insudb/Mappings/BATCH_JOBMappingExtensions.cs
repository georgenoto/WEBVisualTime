using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_JOB;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BATCH_JOBMappingExtensions
{
    public static BATCH_JOBDto ToDto(this BATCH_JOB entity)
    {
        if (entity == null) return null!;
        return new BATCH_JOBDto
        {
            SKEY = entity.SKEY,
            NBATCH = entity.NBATCH,
            BATCH_PROCESSSCODISPL = entity.BATCH_PROCESS?.SCODISPL,
            DSTART = entity.DSTART,
            DEND = entity.DEND,
            NSTATUS = entity.NSTATUS,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            SCOMMAND = entity.SCOMMAND,
            DSUBMIT = entity.DSUBMIT,
            NORAJOB = entity.NORAJOB,
            NUSERSUBMIT = entity.NUSERSUBMIT,
            NSHEET = entity.NSHEET,
            SKEY_FATHER = entity.SKEY_FATHER,
            SOUTPUTFILE = entity.SOUTPUTFILE,
            SFILE = entity.SFILE,
            SVERIFIED_PLA = entity.SVERIFIED_PLA,
        };
    }

    public static BATCH_JOB ToEntity(this CreateBATCH_JOBDto dto)
    {
        if (dto == null) return null!;
        return new BATCH_JOB
        {
            NBATCH = dto.NBATCH,
            DSTART = dto.DSTART,
            DEND = dto.DEND,
            NSTATUS = dto.NSTATUS,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCOMMAND = dto.SCOMMAND,
            DSUBMIT = dto.DSUBMIT,
            NORAJOB = dto.NORAJOB,
            NUSERSUBMIT = dto.NUSERSUBMIT,
            NSHEET = dto.NSHEET,
            SKEY_FATHER = dto.SKEY_FATHER,
            SOUTPUTFILE = dto.SOUTPUTFILE,
            SFILE = dto.SFILE,
            SVERIFIED_PLA = dto.SVERIFIED_PLA,
        };
    }

    public static void UpdateEntity(this BATCH_JOB entity, UpdateBATCH_JOBDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBATCH = dto.NBATCH;
        entity.DSTART = dto.DSTART;
        entity.DEND = dto.DEND;
        entity.NSTATUS = dto.NSTATUS;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOMMAND = dto.SCOMMAND;
        entity.DSUBMIT = dto.DSUBMIT;
        entity.NORAJOB = dto.NORAJOB;
        entity.NUSERSUBMIT = dto.NUSERSUBMIT;
        entity.NSHEET = dto.NSHEET;
        entity.SKEY_FATHER = dto.SKEY_FATHER;
        entity.SOUTPUTFILE = dto.SOUTPUTFILE;
        entity.SFILE = dto.SFILE;
        entity.SVERIFIED_PLA = dto.SVERIFIED_PLA;
    }
}
