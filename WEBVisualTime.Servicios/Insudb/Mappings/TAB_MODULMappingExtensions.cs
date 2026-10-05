using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODUL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MODULMappingExtensions
{
    public static TAB_MODULDto ToDto(this TAB_MODUL entity)
    {
        if (entity == null) return null!;
        return new TAB_MODULDto
        {
            NBRANCH = entity.NBRANCH,
            NMODULEC = entity.NMODULEC,
            NPRODUCT = entity.NPRODUCT,
            DEFFECDATE = entity.DEFFECDATE,
            SCHANALLO = entity.SCHANALLO,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SDESCRIPT = entity.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            SREQUIRE = entity.SREQUIRE,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            SCONDSVS = entity.SCONDSVS,
            SROUTINE = entity.SROUTINE,
            NPREMIRAT = entity.NPREMIRAT,
            NCHPRELEV = entity.NCHPRELEV,
            NRATEPREADD = entity.NRATEPREADD,
            NRATEPRESUB = entity.NRATEPRESUB,
            SCHANGETYP = entity.SCHANGETYP,
            STYP_RAT = entity.STYP_RAT,
            SVIGEN = entity.SVIGEN,
            SDEPEND = entity.SDEPEND,
            SCLAIMMANDATORYFIELDS = entity.SCLAIMMANDATORYFIELDS,
            NGEOGRAPHAREA = entity.NGEOGRAPHAREA,
            TABLE9214SDESCRIPT = entity.TABLE9214?.SDESCRIPT,
            NATTENSYSTEM = entity.NATTENSYSTEM,
            TABLE9215SDESCRIPT = entity.TABLE9215?.SDESCRIPT,
        };
    }

    public static TAB_MODUL ToEntity(this CreateTAB_MODULDto dto)
    {
        if (dto == null) return null!;
        return new TAB_MODUL
        {
            SCHANALLO = dto.SCHANALLO,
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SDESCRIPT = dto.SDESCRIPT,
            DNULLDATE = dto.DNULLDATE,
            SREQUIRE = dto.SREQUIRE,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            SCONDSVS = dto.SCONDSVS,
            SROUTINE = dto.SROUTINE,
            NPREMIRAT = dto.NPREMIRAT,
            NCHPRELEV = dto.NCHPRELEV,
            NRATEPREADD = dto.NRATEPREADD,
            NRATEPRESUB = dto.NRATEPRESUB,
            SCHANGETYP = dto.SCHANGETYP,
            STYP_RAT = dto.STYP_RAT,
            SVIGEN = dto.SVIGEN,
            SDEPEND = dto.SDEPEND,
            SCLAIMMANDATORYFIELDS = dto.SCLAIMMANDATORYFIELDS,
            NGEOGRAPHAREA = dto.NGEOGRAPHAREA,
            NATTENSYSTEM = dto.NATTENSYSTEM,
        };
    }

    public static void UpdateEntity(this TAB_MODUL entity, UpdateTAB_MODULDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCHANALLO = dto.SCHANALLO;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCONDSVS = dto.SCONDSVS;
        entity.SROUTINE = dto.SROUTINE;
        entity.NPREMIRAT = dto.NPREMIRAT;
        entity.NCHPRELEV = dto.NCHPRELEV;
        entity.NRATEPREADD = dto.NRATEPREADD;
        entity.NRATEPRESUB = dto.NRATEPRESUB;
        entity.SCHANGETYP = dto.SCHANGETYP;
        entity.STYP_RAT = dto.STYP_RAT;
        entity.SVIGEN = dto.SVIGEN;
        entity.SDEPEND = dto.SDEPEND;
        entity.SCLAIMMANDATORYFIELDS = dto.SCLAIMMANDATORYFIELDS;
        entity.NGEOGRAPHAREA = dto.NGEOGRAPHAREA;
        entity.NATTENSYSTEM = dto.NATTENSYSTEM;
    }
}
