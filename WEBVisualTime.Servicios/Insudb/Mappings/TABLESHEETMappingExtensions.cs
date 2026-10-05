using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLESHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLESHEETMappingExtensions
{
    public static TABLESHEETDto ToDto(this TABLESHEET entity)
    {
        if (entity == null) return null!;
        return new TABLESHEETDto
        {
            NSHEET = entity.NSHEET,
            STABLE = entity.STABLE,
            SALIAS = entity.SALIAS,
            NORDER = entity.NORDER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLESHEET ToEntity(this CreateTABLESHEETDto dto)
    {
        if (dto == null) return null!;
        return new TABLESHEET
        {
            SALIAS = dto.SALIAS,
            NORDER = dto.NORDER,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLESHEET entity, UpdateTABLESHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SALIAS = dto.SALIAS;
        entity.NORDER = dto.NORDER;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
