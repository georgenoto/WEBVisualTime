using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISCO_EXPR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DISCO_EXPRMappingExtensions
{
    public static DISCO_EXPRDto ToDto(this DISCO_EXPR entity)
    {
        if (entity == null) return null!;
        return new DISCO_EXPRDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NDISEXPRC = entity.NDISEXPRC,
            DEFFECDATE = entity.DEFFECDATE,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NBILL_ITEM = entity.NBILL_ITEM,
            SCHANALLO = entity.SCHANALLO,
            NBRANCH_EST = entity.NBRANCH_EST,
            TABLE71SDESCRIPT = entity.TABLE71?.SDESCRIPT,
            SCOMMISSI_I = entity.SCOMMISSI_I,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            SDEFAULTI = entity.SDEFAULTI,
            SDESCRIPT = entity.SDESCRIPT,
            SDEVOALLO = entity.SDEVOALLO,
            NDISEXMAX = entity.NDISEXMAX,
            NDISEXMIN = entity.NDISEXMIN,
            NDISEXPRA = entity.NDISEXPRA,
            SEDPERAPL = entity.SEDPERAPL,
            DNULLDATE = entity.DNULLDATE,
            NORDER_APL = entity.NORDER_APL,
            SPRORATE = entity.SPRORATE,
            SREQUIRE = entity.SREQUIRE,
            SROUTINE = entity.SROUTINE,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
            NAMELEVEL = entity.NAMELEVEL,
            SDISEXPRI = entity.SDISEXPRI,
            TABLE30SDESCRIPT = entity.TABLE30?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            NNOTENUM = entity.NNOTENUM,
            SDEFPOL = entity.SDEFPOL,
            STYPMAR = entity.STYPMAR,
            SIVA = entity.SIVA,
            NAPLY = entity.NAPLY,
            NRATE = entity.NRATE,
            NDISEXSUBPER = entity.NDISEXSUBPER,
            NDISEXADDPER = entity.NDISEXADDPER,
            SIND_STIPENDS = entity.SIND_STIPENDS,
            NDINSUR_TYPE = entity.NDINSUR_TYPE,
        };
    }

    public static DISCO_EXPR ToEntity(this CreateDISCO_EXPRDto dto)
    {
        if (dto == null) return null!;
        return new DISCO_EXPR
        {
            NBRANCH_REI = dto.NBRANCH_REI,
            NBILL_ITEM = dto.NBILL_ITEM,
            SCHANALLO = dto.SCHANALLO,
            NBRANCH_EST = dto.NBRANCH_EST,
            SCOMMISSI_I = dto.SCOMMISSI_I,
            NBRANCH_LED = dto.NBRANCH_LED,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            SDEFAULTI = dto.SDEFAULTI,
            SDESCRIPT = dto.SDESCRIPT,
            SDEVOALLO = dto.SDEVOALLO,
            NDISEXMAX = dto.NDISEXMAX,
            NDISEXMIN = dto.NDISEXMIN,
            NDISEXPRA = dto.NDISEXPRA,
            SEDPERAPL = dto.SEDPERAPL,
            DNULLDATE = dto.DNULLDATE,
            NORDER_APL = dto.NORDER_APL,
            SPRORATE = dto.SPRORATE,
            SREQUIRE = dto.SREQUIRE,
            SROUTINE = dto.SROUTINE,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
            NAMELEVEL = dto.NAMELEVEL,
            SDISEXPRI = dto.SDISEXPRI,
            SSTATREGT = dto.SSTATREGT,
            NNOTENUM = dto.NNOTENUM,
            SDEFPOL = dto.SDEFPOL,
            STYPMAR = dto.STYPMAR,
            SIVA = dto.SIVA,
            NAPLY = dto.NAPLY,
            NRATE = dto.NRATE,
            NDISEXSUBPER = dto.NDISEXSUBPER,
            NDISEXADDPER = dto.NDISEXADDPER,
            SIND_STIPENDS = dto.SIND_STIPENDS,
            NDINSUR_TYPE = dto.NDINSUR_TYPE,
        };
    }

    public static void UpdateEntity(this DISCO_EXPR entity, UpdateDISCO_EXPRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.SCHANALLO = dto.SCHANALLO;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.SCOMMISSI_I = dto.SCOMMISSI_I;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SDEFAULTI = dto.SDEFAULTI;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SDEVOALLO = dto.SDEVOALLO;
        entity.NDISEXMAX = dto.NDISEXMAX;
        entity.NDISEXMIN = dto.NDISEXMIN;
        entity.NDISEXPRA = dto.NDISEXPRA;
        entity.SEDPERAPL = dto.SEDPERAPL;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NORDER_APL = dto.NORDER_APL;
        entity.SPRORATE = dto.SPRORATE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.SROUTINE = dto.SROUTINE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NAMELEVEL = dto.NAMELEVEL;
        entity.SDISEXPRI = dto.SDISEXPRI;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SDEFPOL = dto.SDEFPOL;
        entity.STYPMAR = dto.STYPMAR;
        entity.SIVA = dto.SIVA;
        entity.NAPLY = dto.NAPLY;
        entity.NRATE = dto.NRATE;
        entity.NDISEXSUBPER = dto.NDISEXSUBPER;
        entity.NDISEXADDPER = dto.NDISEXADDPER;
        entity.SIND_STIPENDS = dto.SIND_STIPENDS;
        entity.NDINSUR_TYPE = dto.NDINSUR_TYPE;
    }
}
