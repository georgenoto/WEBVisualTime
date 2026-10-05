using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MESSAGEMappingExtensions
{
    public static MESSAGEDto ToDto(this MESSAGE entity)
    {
        if (entity == null) return null!;
        return new MESSAGEDto
        {
            NERRORNUM = entity.NERRORNUM,
            DCOMPDATE = entity.DCOMPDATE,
            SMESSAGED = entity.SMESSAGED,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MESSAGE ToEntity(this CreateMESSAGEDto dto)
    {
        if (dto == null) return null!;
        return new MESSAGE
        {
            DCOMPDATE = dto.DCOMPDATE,
            SMESSAGED = dto.SMESSAGED,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MESSAGE entity, UpdateMESSAGEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SMESSAGED = dto.SMESSAGED;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
