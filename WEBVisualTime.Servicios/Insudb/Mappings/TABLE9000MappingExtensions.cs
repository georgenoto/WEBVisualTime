using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9000MappingExtensions
{
    public static TABLE9000Dto ToDto(this TABLE9000 entity)
    {
        if (entity == null) return null!;
        return new TABLE9000Dto
        {
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NCOMMERGRP = entity.NCOMMERGRP,
        };
    }

    public static TABLE9000 ToEntity(this CreateTABLE9000Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9000
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9000 entity, UpdateTABLE9000Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
