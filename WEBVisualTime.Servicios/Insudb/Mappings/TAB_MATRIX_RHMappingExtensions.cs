using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MATRIX_RH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MATRIX_RHMappingExtensions
{
    public static TAB_MATRIX_RHDto ToDto(this TAB_MATRIX_RH entity)
    {
        if (entity == null) return null!;
        return new TAB_MATRIX_RHDto
        {
            NTYPE_MOVE = entity.NTYPE_MOVE,
            NORIGIN = entity.NORIGIN,
            NTYP_PROFITWORKER = entity.NTYP_PROFITWORKER,
            NTRANSAC = entity.NTRANSAC,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TAB_MATRIX_RH ToEntity(this CreateTAB_MATRIX_RHDto dto)
    {
        if (dto == null) return null!;
        return new TAB_MATRIX_RH
        {
            NTRANSAC = dto.NTRANSAC,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TAB_MATRIX_RH entity, UpdateTAB_MATRIX_RHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
