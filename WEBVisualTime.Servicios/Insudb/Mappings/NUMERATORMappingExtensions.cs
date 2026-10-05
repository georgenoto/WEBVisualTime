using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NUMERATOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NUMERATORMappingExtensions
{
    public static NUMERATORDto ToDto(this NUMERATOR entity)
    {
        if (entity == null) return null!;
        return new NUMERATORDto
        {
            NTYPENUM = entity.NTYPENUM,
            NORD_NUM = entity.NORD_NUM,
            DCOMPDATE = entity.DCOMPDATE,
            NEND_NUM = entity.NEND_NUM,
            NINITIAL = entity.NINITIAL,
            NLASTNUMB = entity.NLASTNUMB,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static NUMERATOR ToEntity(this CreateNUMERATORDto dto)
    {
        if (dto == null) return null!;
        return new NUMERATOR
        {
            DCOMPDATE = dto.DCOMPDATE,
            NEND_NUM = dto.NEND_NUM,
            NINITIAL = dto.NINITIAL,
            NLASTNUMB = dto.NLASTNUMB,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this NUMERATOR entity, UpdateNUMERATORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NEND_NUM = dto.NEND_NUM;
        entity.NINITIAL = dto.NINITIAL;
        entity.NLASTNUMB = dto.NLASTNUMB;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
