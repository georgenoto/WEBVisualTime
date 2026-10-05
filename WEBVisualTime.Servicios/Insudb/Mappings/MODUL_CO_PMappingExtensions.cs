using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_CO_P;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MODUL_CO_PMappingExtensions
{
    public static MODUL_CO_PDto ToDto(this MODUL_CO_P entity)
    {
        if (entity == null) return null!;
        return new MODUL_CO_PDto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NMODULEC = entity.NMODULEC,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            NPREMIRAT = entity.NPREMIRAT,
            STYP_RAT = entity.STYP_RAT,
            NGEOGRAPHAREA = entity.NGEOGRAPHAREA,
            TABLE9214SDESCRIPT = entity.TABLE9214?.SDESCRIPT,
            NATTENSYSTEM = entity.NATTENSYSTEM,
            TABLE9215SDESCRIPT = entity.TABLE9215?.SDESCRIPT,
        };
    }

    public static MODUL_CO_P ToEntity(this CreateMODUL_CO_PDto dto)
    {
        if (dto == null) return null!;
        return new MODUL_CO_P
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            NPREMIRAT = dto.NPREMIRAT,
            STYP_RAT = dto.STYP_RAT,
            NGEOGRAPHAREA = dto.NGEOGRAPHAREA,
            NATTENSYSTEM = dto.NATTENSYSTEM,
        };
    }

    public static void UpdateEntity(this MODUL_CO_P entity, UpdateMODUL_CO_PDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPREMIRAT = dto.NPREMIRAT;
        entity.STYP_RAT = dto.STYP_RAT;
        entity.NGEOGRAPHAREA = dto.NGEOGRAPHAREA;
        entity.NATTENSYSTEM = dto.NATTENSYSTEM;
    }
}
