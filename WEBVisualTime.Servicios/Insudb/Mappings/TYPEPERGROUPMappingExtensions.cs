using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPEPERGROUP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TYPEPERGROUPMappingExtensions
{
    public static TYPEPERGROUPDto ToDto(this TYPEPERGROUP entity)
    {
        if (entity == null) return null!;
        return new TYPEPERGROUPDto
        {
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBUSINESSTY = entity.NBUSINESSTY,
            TABLE9005SDESCRIPT = entity.TABLE9005?.SDESCRIPT,
            NCOMMERGRP = entity.NCOMMERGRP,
            TABLE9000SDESCRIPT = entity.TABLE9000?.SDESCRIPT,
        };
    }

    public static TYPEPERGROUP ToEntity(this CreateTYPEPERGROUPDto dto)
    {
        if (dto == null) return null!;
        return new TYPEPERGROUP
        {
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TYPEPERGROUP entity, UpdateTYPEPERGROUPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
