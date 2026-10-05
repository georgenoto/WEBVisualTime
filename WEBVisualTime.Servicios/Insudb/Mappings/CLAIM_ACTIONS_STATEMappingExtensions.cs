using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_STATE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_ACTIONS_STATEMappingExtensions
{
    public static CLAIM_ACTIONS_STATEDto ToDto(this CLAIM_ACTIONS_STATE entity)
    {
        if (entity == null) return null!;
        return new CLAIM_ACTIONS_STATEDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NSTATUS = entity.NSTATUS,
            SIND_CHANGE = entity.SIND_CHANGE,
            SIND_QUERY = entity.SIND_QUERY,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCLAIM_ENTITY = entity.NCLAIM_ENTITY,
            TABLE9262SDESCRIPT = entity.TABLE9262?.SDESCRIPT,
            NACTIONCLAIM = entity.NACTIONCLAIM,
        };
    }

    public static CLAIM_ACTIONS_STATE ToEntity(this CreateCLAIM_ACTIONS_STATEDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_ACTIONS_STATE
        {
            SIND_CHANGE = dto.SIND_CHANGE,
            SIND_QUERY = dto.SIND_QUERY,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CLAIM_ACTIONS_STATE entity, UpdateCLAIM_ACTIONS_STATEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SIND_CHANGE = dto.SIND_CHANGE;
        entity.SIND_QUERY = dto.SIND_QUERY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
