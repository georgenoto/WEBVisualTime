using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WAITPO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_WAITPOMappingExtensions
{
    public static TAB_WAITPODto ToDto(this TAB_WAITPO entity)
    {
        if (entity == null) return null!;
        return new TAB_WAITPODto
        {
            NWAIT_CODE = entity.NWAIT_CODE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NAREAWAIT = entity.NAREAWAIT,
            TABLE5603SDESCRIPT = entity.TABLE5603?.SDESCRIPT,
            NORDER = entity.NORDER,
            SCONVERT = entity.SCONVERT,
        };
    }

    public static TAB_WAITPO ToEntity(this CreateTAB_WAITPODto dto)
    {
        if (dto == null) return null!;
        return new TAB_WAITPO
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NAREAWAIT = dto.NAREAWAIT,
            NORDER = dto.NORDER,
            SCONVERT = dto.SCONVERT,
        };
    }

    public static void UpdateEntity(this TAB_WAITPO entity, UpdateTAB_WAITPODto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NAREAWAIT = dto.NAREAWAIT;
        entity.NORDER = dto.NORDER;
        entity.SCONVERT = dto.SCONVERT;
    }
}
