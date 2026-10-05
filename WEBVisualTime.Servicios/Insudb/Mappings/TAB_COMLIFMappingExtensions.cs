using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMLIF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_COMLIFMappingExtensions
{
    public static TAB_COMLIFDto ToDto(this TAB_COMLIF entity)
    {
        if (entity == null) return null!;
        return new TAB_COMLIFDto
        {
            NCOMTABLI = entity.NCOMTABLI,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
        };
    }

    public static TAB_COMLIF ToEntity(this CreateTAB_COMLIFDto dto)
    {
        if (dto == null) return null!;
        return new TAB_COMLIF
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NINTERTYP = dto.NINTERTYP,
        };
    }

    public static void UpdateEntity(this TAB_COMLIF entity, UpdateTAB_COMLIFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NINTERTYP = dto.NINTERTYP;
    }
}
