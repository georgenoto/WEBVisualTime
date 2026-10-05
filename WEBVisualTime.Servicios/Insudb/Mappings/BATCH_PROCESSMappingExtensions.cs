using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PROCESS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BATCH_PROCESSMappingExtensions
{
    public static BATCH_PROCESSDto ToDto(this BATCH_PROCESS entity)
    {
        if (entity == null) return null!;
        return new BATCH_PROCESSDto
        {
            NBATCH = entity.NBATCH,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            SPROC = entity.SPROC,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            SDESCRIPT = entity.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static BATCH_PROCESS ToEntity(this CreateBATCH_PROCESSDto dto)
    {
        if (dto == null) return null!;
        return new BATCH_PROCESS
        {
            SCODISPL = dto.SCODISPL,
            SPROC = dto.SPROC,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this BATCH_PROCESS entity, UpdateBATCH_PROCESSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.SPROC = dto.SPROC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
