using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_CUR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHEMA_CURMappingExtensions
{
    public static SCHEMA_CURDto ToDto(this SCHEMA_CUR entity)
    {
        if (entity == null) return null!;
        return new SCHEMA_CURDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            NCURRENCY = entity.NCURRENCY,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SCHEMA_CUR ToEntity(this CreateSCHEMA_CURDto dto)
    {
        if (dto == null) return null!;
        return new SCHEMA_CUR
        {
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SCHEMA_CUR entity, UpdateSCHEMA_CURDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
