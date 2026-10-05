using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BUSSKIND;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BUSSKINDMappingExtensions
{
    public static BUSSKINDDto ToDto(this BUSSKIND entity)
    {
        if (entity == null) return null!;
        return new BUSSKINDDto
        {
            SCOMPLCOD = entity.SCOMPLCOD,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBUSINESSTY = entity.NBUSINESSTY,
            TYPEPERGROUPNBUSINESSTYSSTATREGT = entity.TYPEPERGROUPNBUSINESSTY?.SSTATREGT,
            NCOMMERGRP = entity.NCOMMERGRP,
            TYPEPERGROUPNCOMMERGRPSSTATREGT = entity.TYPEPERGROUPNCOMMERGRP?.SSTATREGT,
            NCODKIND = entity.NCODKIND,
        };
    }

    public static BUSSKIND ToEntity(this CreateBUSSKINDDto dto)
    {
        if (dto == null) return null!;
        return new BUSSKIND
        {
            SCOMPLCOD = dto.SCOMPLCOD,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this BUSSKIND entity, UpdateBUSSKINDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCOMPLCOD = dto.SCOMPLCOD;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
