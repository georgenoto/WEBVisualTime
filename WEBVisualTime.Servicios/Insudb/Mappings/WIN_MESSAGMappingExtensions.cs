using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_MESSAG;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WIN_MESSAGMappingExtensions
{
    public static WIN_MESSAGDto ToDto(this WIN_MESSAG entity)
    {
        if (entity == null) return null!;
        return new WIN_MESSAGDto
        {
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NERRORNUM = entity.NERRORNUM,
            MESSAGESMESSAGED = entity.MESSAGE?.SMESSAGED,
            SACTION_ERR = entity.SACTION_ERR,
            DCOMPDATE = entity.DCOMPDATE,
            SERRORTYP = entity.SERRORTYP,
            TABLE153SDESCRIPT = entity.TABLE153?.SDESCRIPT,
            NLEVEL = entity.NLEVEL,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static WIN_MESSAG ToEntity(this CreateWIN_MESSAGDto dto)
    {
        if (dto == null) return null!;
        return new WIN_MESSAG
        {
            SACTION_ERR = dto.SACTION_ERR,
            DCOMPDATE = dto.DCOMPDATE,
            SERRORTYP = dto.SERRORTYP,
            NLEVEL = dto.NLEVEL,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this WIN_MESSAG entity, UpdateWIN_MESSAGDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACTION_ERR = dto.SACTION_ERR;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SERRORTYP = dto.SERRORTYP;
        entity.NLEVEL = dto.NLEVEL;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
