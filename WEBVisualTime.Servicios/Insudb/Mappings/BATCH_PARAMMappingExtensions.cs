using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BATCH_PARAMMappingExtensions
{
    public static BATCH_PARAMDto ToDto(this BATCH_PARAM entity)
    {
        if (entity == null) return null!;
        return new BATCH_PARAMDto
        {
            NBATCH = entity.NBATCH,
            BATCH_PROCESSSCODISPL = entity.BATCH_PROCESS?.SCODISPL,
            NAREA = entity.NAREA,
            NSEQ = entity.NSEQ,
            SNAME = entity.SNAME,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static BATCH_PARAM ToEntity(this CreateBATCH_PARAMDto dto)
    {
        if (dto == null) return null!;
        return new BATCH_PARAM
        {
            SNAME = dto.SNAME,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this BATCH_PARAM entity, UpdateBATCH_PARAMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SNAME = dto.SNAME;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
