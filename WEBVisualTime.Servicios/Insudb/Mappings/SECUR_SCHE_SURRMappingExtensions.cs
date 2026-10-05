using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE_SURR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SECUR_SCHE_SURRMappingExtensions
{
    public static SECUR_SCHE_SURRDto ToDto(this SECUR_SCHE_SURR entity)
    {
        if (entity == null) return null!;
        return new SECUR_SCHE_SURRDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NTYPERESC = entity.NTYPERESC,
            DCOMPDATE = entity.DCOMPDATE,
            SMOD_DATE_R = entity.SMOD_DATE_R,
            SRESC_TOT = entity.SRESC_TOT,
            SRESC_PAR = entity.SRESC_PAR,
            STYPEXECUT = entity.STYPEXECUT,
            SMOD_DATE_P = entity.SMOD_DATE_P,
            NUSERCODE = entity.NUSERCODE,
            NTYPERESCV = entity.NTYPERESCV,
            SMOD_DATE_RV = entity.SMOD_DATE_RV,
            SRESC_TOTV = entity.SRESC_TOTV,
            SRESC_PARV = entity.SRESC_PARV,
            STYPEXECUTV = entity.STYPEXECUTV,
            SANULREC = entity.SANULREC,
            SMOD_DATE_PV = entity.SMOD_DATE_PV,
            SREQUEST = entity.SREQUEST,
            SREPORT = entity.SREPORT,
            NVALUE_TYP = entity.NVALUE_TYP,
        };
    }

    public static SECUR_SCHE_SURR ToEntity(this CreateSECUR_SCHE_SURRDto dto)
    {
        if (dto == null) return null!;
        return new SECUR_SCHE_SURR
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            NTYPERESC = dto.NTYPERESC,
            DCOMPDATE = dto.DCOMPDATE,
            SMOD_DATE_R = dto.SMOD_DATE_R,
            SRESC_TOT = dto.SRESC_TOT,
            SRESC_PAR = dto.SRESC_PAR,
            STYPEXECUT = dto.STYPEXECUT,
            SMOD_DATE_P = dto.SMOD_DATE_P,
            NUSERCODE = dto.NUSERCODE,
            NTYPERESCV = dto.NTYPERESCV,
            SMOD_DATE_RV = dto.SMOD_DATE_RV,
            SRESC_TOTV = dto.SRESC_TOTV,
            SRESC_PARV = dto.SRESC_PARV,
            STYPEXECUTV = dto.STYPEXECUTV,
            SANULREC = dto.SANULREC,
            SMOD_DATE_PV = dto.SMOD_DATE_PV,
            SREQUEST = dto.SREQUEST,
            SREPORT = dto.SREPORT,
            NVALUE_TYP = dto.NVALUE_TYP,
        };
    }

    public static void UpdateEntity(this SECUR_SCHE_SURR entity, UpdateSECUR_SCHE_SURRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.NTYPERESC = dto.NTYPERESC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SMOD_DATE_R = dto.SMOD_DATE_R;
        entity.SRESC_TOT = dto.SRESC_TOT;
        entity.SRESC_PAR = dto.SRESC_PAR;
        entity.STYPEXECUT = dto.STYPEXECUT;
        entity.SMOD_DATE_P = dto.SMOD_DATE_P;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPERESCV = dto.NTYPERESCV;
        entity.SMOD_DATE_RV = dto.SMOD_DATE_RV;
        entity.SRESC_TOTV = dto.SRESC_TOTV;
        entity.SRESC_PARV = dto.SRESC_PARV;
        entity.STYPEXECUTV = dto.STYPEXECUTV;
        entity.SANULREC = dto.SANULREC;
        entity.SMOD_DATE_PV = dto.SMOD_DATE_PV;
        entity.SREQUEST = dto.SREQUEST;
        entity.SREPORT = dto.SREPORT;
        entity.NVALUE_TYP = dto.NVALUE_TYP;
    }
}
