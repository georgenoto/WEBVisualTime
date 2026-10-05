using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOLLIDAYS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HOLLIDAYSMappingExtensions
{
    public static HOLLIDAYSDto ToDto(this HOLLIDAYS entity)
    {
        if (entity == null) return null!;
        return new HOLLIDAYSDto
        {
            NMONTH = entity.NMONTH,
            TABLE7013SDESCRIPT = entity.TABLE7013?.SDESCRIPT,
            NDAY = entity.NDAY,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NCOUNTRY = entity.NCOUNTRY,
            NYEAR = entity.NYEAR,
        };
    }

    public static HOLLIDAYS ToEntity(this CreateHOLLIDAYSDto dto)
    {
        if (dto == null) return null!;
        return new HOLLIDAYS
        {
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NYEAR = dto.NYEAR,
        };
    }

    public static void UpdateEntity(this HOLLIDAYS entity, UpdateHOLLIDAYSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NYEAR = dto.NYEAR;
    }
}
