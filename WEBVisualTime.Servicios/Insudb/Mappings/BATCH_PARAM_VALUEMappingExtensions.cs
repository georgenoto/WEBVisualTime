using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM_VALUE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BATCH_PARAM_VALUEMappingExtensions
{
    public static BATCH_PARAM_VALUEDto ToDto(this BATCH_PARAM_VALUE entity)
    {
        if (entity == null) return null!;
        return new BATCH_PARAM_VALUEDto
        {
            SKEY = entity.SKEY,
            BATCH_JOBSCOMMAND = entity.BATCH_JOB?.SCOMMAND,
            NAREA = entity.NAREA,
            BATCH_PARAMNAREASNAME = entity.BATCH_PARAMNAREA?.SNAME,
            NSEQ = entity.NSEQ,
            BATCH_PARAMNSEQSNAME = entity.BATCH_PARAMNSEQ?.SNAME,
            NBATCH = entity.NBATCH,
            BATCH_PARAMNBATCHSNAME = entity.BATCH_PARAMNBATCH?.SNAME,
            SVALUE = entity.SVALUE,
            NDATATYPE = entity.NDATATYPE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
        };
    }

    public static BATCH_PARAM_VALUE ToEntity(this CreateBATCH_PARAM_VALUEDto dto)
    {
        if (dto == null) return null!;
        return new BATCH_PARAM_VALUE
        {
            SVALUE = dto.SVALUE,
            NDATATYPE = dto.NDATATYPE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
        };
    }

    public static void UpdateEntity(this BATCH_PARAM_VALUE entity, UpdateBATCH_PARAM_VALUEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SVALUE = dto.SVALUE;
        entity.NDATATYPE = dto.NDATATYPE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
    }
}
