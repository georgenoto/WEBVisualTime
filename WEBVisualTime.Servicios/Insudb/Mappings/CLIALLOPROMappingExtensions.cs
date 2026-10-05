using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOPRO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIALLOPROMappingExtensions
{
    public static CLIALLOPRODto ToDto(this CLIALLOPRO entity)
    {
        if (entity == null) return null!;
        return new CLIALLOPRODto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            SPOLITYPE = entity.SPOLITYPE,
            SCOMPON = entity.SCOMPON,
            NROLE = entity.NROLE,
            DCOMPDATE = entity.DCOMPDATE,
            SDEFAULTI = entity.SDEFAULTI,
            SREQUIRE = entity.SREQUIRE,
            NMAX_ROLE = entity.NMAX_ROLE,
            NUSERCODE = entity.NUSERCODE,
            SOPTIONALQUO = entity.SOPTIONALQUO,
            DDATE_NROLE = entity.DDATE_NROLE,
            NINTERMED = entity.NINTERMED,
            NCONTRAT_PAY = entity.NCONTRAT_PAY,
            SCLIENT = entity.SCLIENT,
            SINSURABLE = entity.SINSURABLE,
        };
    }

    public static CLIALLOPRO ToEntity(this CreateCLIALLOPRODto dto)
    {
        if (dto == null) return null!;
        return new CLIALLOPRO
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDEFAULTI = dto.SDEFAULTI,
            SREQUIRE = dto.SREQUIRE,
            NMAX_ROLE = dto.NMAX_ROLE,
            NUSERCODE = dto.NUSERCODE,
            SOPTIONALQUO = dto.SOPTIONALQUO,
            DDATE_NROLE = dto.DDATE_NROLE,
            NINTERMED = dto.NINTERMED,
            NCONTRAT_PAY = dto.NCONTRAT_PAY,
            SCLIENT = dto.SCLIENT,
            SINSURABLE = dto.SINSURABLE,
        };
    }

    public static void UpdateEntity(this CLIALLOPRO entity, UpdateCLIALLOPRODto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NMAX_ROLE = dto.NMAX_ROLE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SOPTIONALQUO = dto.SOPTIONALQUO;
        entity.DDATE_NROLE = dto.DDATE_NROLE;
        entity.NINTERMED = dto.NINTERMED;
        entity.NCONTRAT_PAY = dto.NCONTRAT_PAY;
        entity.SCLIENT = dto.SCLIENT;
        entity.SINSURABLE = dto.SINSURABLE;
    }
}
