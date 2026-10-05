using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FONASA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_FONASAMappingExtensions
{
    public static TAB_FONASADto ToDto(this TAB_FONASA entity)
    {
        if (entity == null) return null!;
        return new TAB_FONASADto
        {
            NYEAR = entity.NYEAR,
            SSERVICE = entity.SSERVICE,
            SSUBSERVICE = entity.SSUBSERVICE,
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NAMOUNT = entity.NAMOUNT,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DCOMPDATE = entity.DCOMPDATE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
        };
    }

    public static TAB_FONASA ToEntity(this CreateTAB_FONASADto dto)
    {
        if (dto == null) return null!;
        return new TAB_FONASA
        {
            DNULLDATE = dto.DNULLDATE,
            NAMOUNT = dto.NAMOUNT,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
        };
    }

    public static void UpdateEntity(this TAB_FONASA entity, UpdateTAB_FONASADto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
    }
}
