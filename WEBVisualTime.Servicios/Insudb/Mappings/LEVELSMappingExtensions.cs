using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEVELS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LEVELSMappingExtensions
{
    public static LEVELSDto ToDto(this LEVELS entity)
    {
        if (entity == null) return null!;
        return new LEVELSDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            SIND_TYPE = entity.SIND_TYPE,
            TABLE511SDESCRIPT = entity.TABLE511?.SDESCRIPT,
            SCODE_MT = entity.SCODE_MT,
            NAMELEVEL = entity.NAMELEVEL,
            DCOMPDATE = entity.DCOMPDATE,
            NINQLEVEL = entity.NINQLEVEL,
            SSUPERVIS = entity.SSUPERVIS,
            NUSERCODE = entity.NUSERCODE,
            SPERMITTED = entity.SPERMITTED,
            SENCRYPTED = entity.SENCRYPTED,
        };
    }

    public static LEVELS ToEntity(this CreateLEVELSDto dto)
    {
        if (dto == null) return null!;
        return new LEVELS
        {
            NAMELEVEL = dto.NAMELEVEL,
            DCOMPDATE = dto.DCOMPDATE,
            NINQLEVEL = dto.NINQLEVEL,
            SSUPERVIS = dto.SSUPERVIS,
            NUSERCODE = dto.NUSERCODE,
            SPERMITTED = dto.SPERMITTED,
            SENCRYPTED = dto.SENCRYPTED,
        };
    }

    public static void UpdateEntity(this LEVELS entity, UpdateLEVELSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMELEVEL = dto.NAMELEVEL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NINQLEVEL = dto.NINQLEVEL;
        entity.SSUPERVIS = dto.SSUPERVIS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPERMITTED = dto.SPERMITTED;
        entity.SENCRYPTED = dto.SENCRYPTED;
    }
}
