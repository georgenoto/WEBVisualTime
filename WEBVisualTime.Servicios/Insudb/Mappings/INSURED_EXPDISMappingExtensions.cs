using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INSURED_EXPDIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INSURED_EXPDISMappingExtensions
{
    public static INSURED_EXPDISDto ToDto(this INSURED_EXPDIS entity)
    {
        if (entity == null) return null!;
        return new INSURED_EXPDISDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NGROUP_INSU = entity.NGROUP_INSU,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NDISEXPRC = entity.NDISEXPRC,
            SDISEXPRI = entity.SDISEXPRI,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            DEFFECDATE = entity.DEFFECDATE,
            SUNIT = entity.SUNIT,
            NRATE = entity.NRATE,
            NAMOUNT = entity.NAMOUNT,
            DNULLDATE = entity.DNULLDATE,
            SPERM_TEMP = entity.SPERM_TEMP,
            DDATE_FR = entity.DDATE_FR,
            DDATE_TO = entity.DDATE_TO,
            NAGE = entity.NAGE,
            NNOTENUM = entity.NNOTENUM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NCAUSE = entity.NCAUSE,
            SAGREE = entity.SAGREE,
            SINITDATE_CALC = entity.SINITDATE_CALC,
            NACTIVITY = entity.NACTIVITY,
            NSPORT = entity.NSPORT,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static INSURED_EXPDIS ToEntity(this CreateINSURED_EXPDISDto dto)
    {
        if (dto == null) return null!;
        return new INSURED_EXPDIS
        {
            SDISEXPRI = dto.SDISEXPRI,
            SUNIT = dto.SUNIT,
            NRATE = dto.NRATE,
            NAMOUNT = dto.NAMOUNT,
            DNULLDATE = dto.DNULLDATE,
            SPERM_TEMP = dto.SPERM_TEMP,
            DDATE_FR = dto.DDATE_FR,
            DDATE_TO = dto.DDATE_TO,
            NAGE = dto.NAGE,
            NNOTENUM = dto.NNOTENUM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCAUSE = dto.NCAUSE,
            SAGREE = dto.SAGREE,
            SINITDATE_CALC = dto.SINITDATE_CALC,
            NACTIVITY = dto.NACTIVITY,
            NSPORT = dto.NSPORT,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this INSURED_EXPDIS entity, UpdateINSURED_EXPDISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDISEXPRI = dto.SDISEXPRI;
        entity.SUNIT = dto.SUNIT;
        entity.NRATE = dto.NRATE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SPERM_TEMP = dto.SPERM_TEMP;
        entity.DDATE_FR = dto.DDATE_FR;
        entity.DDATE_TO = dto.DDATE_TO;
        entity.NAGE = dto.NAGE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCAUSE = dto.NCAUSE;
        entity.SAGREE = dto.SAGREE;
        entity.SINITDATE_CALC = dto.SINITDATE_CALC;
        entity.NACTIVITY = dto.NACTIVITY;
        entity.NSPORT = dto.NSPORT;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
