using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MENU_SSCHE_CODE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MENU_SSCHE_CODEMappingExtensions
{
    public static MENU_SSCHE_CODEDto ToDto(this MENU_SSCHE_CODE entity)
    {
        if (entity == null) return null!;
        return new MENU_SSCHE_CODEDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SCOD_LVL0 = entity.SCOD_LVL0,
            SLVL0 = entity.SLVL0,
            SCOD_LVL1 = entity.SCOD_LVL1,
            SLVL1 = entity.SLVL1,
            SCOD_LVL2 = entity.SCOD_LVL2,
            SLVL2 = entity.SLVL2,
            SCOD_LVL3 = entity.SCOD_LVL3,
            SLVL3 = entity.SLVL3,
            SCOD_LVL4 = entity.SCOD_LVL4,
            SLVL4 = entity.SLVL4,
            NCOUNT_LVL = entity.NCOUNT_LVL,
            SPERMITTED = entity.SPERMITTED,
            DCOMPDATE = entity.DCOMPDATE,
            NORDER = entity.NORDER,
        };
    }

    public static MENU_SSCHE_CODE ToEntity(this CreateMENU_SSCHE_CODEDto dto)
    {
        if (dto == null) return null!;
        return new MENU_SSCHE_CODE
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            SCOD_LVL0 = dto.SCOD_LVL0,
            SLVL0 = dto.SLVL0,
            SCOD_LVL1 = dto.SCOD_LVL1,
            SLVL1 = dto.SLVL1,
            SCOD_LVL2 = dto.SCOD_LVL2,
            SLVL2 = dto.SLVL2,
            SCOD_LVL3 = dto.SCOD_LVL3,
            SLVL3 = dto.SLVL3,
            SCOD_LVL4 = dto.SCOD_LVL4,
            SLVL4 = dto.SLVL4,
            NCOUNT_LVL = dto.NCOUNT_LVL,
            SPERMITTED = dto.SPERMITTED,
            DCOMPDATE = dto.DCOMPDATE,
            NORDER = dto.NORDER,
        };
    }

    public static void UpdateEntity(this MENU_SSCHE_CODE entity, UpdateMENU_SSCHE_CODEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.SCOD_LVL0 = dto.SCOD_LVL0;
        entity.SLVL0 = dto.SLVL0;
        entity.SCOD_LVL1 = dto.SCOD_LVL1;
        entity.SLVL1 = dto.SLVL1;
        entity.SCOD_LVL2 = dto.SCOD_LVL2;
        entity.SLVL2 = dto.SLVL2;
        entity.SCOD_LVL3 = dto.SCOD_LVL3;
        entity.SLVL3 = dto.SLVL3;
        entity.SCOD_LVL4 = dto.SCOD_LVL4;
        entity.SLVL4 = dto.SLVL4;
        entity.NCOUNT_LVL = dto.NCOUNT_LVL;
        entity.SPERMITTED = dto.SPERMITTED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NORDER = dto.NORDER;
    }
}
