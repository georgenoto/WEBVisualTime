using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.EXCHANGE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class EXCHANGEMappingExtensions
{
    public static EXCHANGEDto ToDto(this EXCHANGE entity)
    {
        if (entity == null) return null!;
        return new EXCHANGEDto
        {
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NEXCHANGE = entity.NEXCHANGE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static EXCHANGE ToEntity(this CreateEXCHANGEDto dto)
    {
        if (dto == null) return null!;
        return new EXCHANGE
        {
            DCOMPDATE = dto.DCOMPDATE,
            NEXCHANGE = dto.NEXCHANGE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this EXCHANGE entity, UpdateEXCHANGEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
