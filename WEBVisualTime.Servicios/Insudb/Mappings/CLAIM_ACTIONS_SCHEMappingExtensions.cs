using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_SCHE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_ACTIONS_SCHEMappingExtensions
{
    public static CLAIM_ACTIONS_SCHEDto ToDto(this CLAIM_ACTIONS_SCHE entity)
    {
        if (entity == null) return null!;
        return new CLAIM_ACTIONS_SCHEDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NACTIONCLAIM = entity.NACTIONCLAIM,
            TABLE9244SDESCRIPT = entity.TABLE9244?.SDESCRIPT,
            NACTIONTYPE = entity.NACTIONTYPE,
            TABLE9245SDESCRIPT = entity.TABLE9245?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CLAIM_ACTIONS_SCHE ToEntity(this CreateCLAIM_ACTIONS_SCHEDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_ACTIONS_SCHE
        {
            NACTIONTYPE = dto.NACTIONTYPE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CLAIM_ACTIONS_SCHE entity, UpdateCLAIM_ACTIONS_SCHEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACTIONTYPE = dto.NACTIONTYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
