using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_LOCATMappingExtensions
{
    public static TAB_LOCATDto ToDto(this TAB_LOCAT entity)
    {
        if (entity == null) return null!;
        return new TAB_LOCATDto
        {
            NLOCAL = entity.NLOCAL,
            SDESCRIPT = entity.SDESCRIPT,
            NPROVINCE = entity.NPROVINCE,
            PROVINCESDESCRIPT = entity.PROVINCE?.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SLEGAL_LOC = entity.SLEGAL_LOC,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_LOCAT ToEntity(this CreateTAB_LOCATDto dto)
    {
        if (dto == null) return null!;
        return new TAB_LOCAT
        {
            SDESCRIPT = dto.SDESCRIPT,
            NPROVINCE = dto.NPROVINCE,
            SSHORT_DES = dto.SSHORT_DES,
            SLEGAL_LOC = dto.SLEGAL_LOC,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_LOCAT entity, UpdateTAB_LOCATDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SLEGAL_LOC = dto.SLEGAL_LOC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
