using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMPRO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_COMPROMappingExtensions
{
    public static TAB_COMPRODto ToDto(this TAB_COMPRO entity)
    {
        if (entity == null) return null!;
        return new TAB_COMPRODto
        {
            NTYPE_TRAN = entity.NTYPE_TRAN,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            NLINE = entity.NLINE,
            NTYP_ACCO = entity.NTYP_ACCO,
            SDEBITSIDE = entity.SDEBITSIDE,
            NTYP_AMOUNT = entity.NTYP_AMOUNT,
            TABLE532SDESCRIPT = entity.TABLE532?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_COMPRO ToEntity(this CreateTAB_COMPRODto dto)
    {
        if (dto == null) return null!;
        return new TAB_COMPRO
        {
            NTYP_ACCO = dto.NTYP_ACCO,
            SDEBITSIDE = dto.SDEBITSIDE,
            NTYP_AMOUNT = dto.NTYP_AMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_COMPRO entity, UpdateTAB_COMPRODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.SDEBITSIDE = dto.SDEBITSIDE;
        entity.NTYP_AMOUNT = dto.NTYP_AMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
