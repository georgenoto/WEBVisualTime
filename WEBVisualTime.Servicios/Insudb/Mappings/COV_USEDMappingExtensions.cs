using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COV_USEDMappingExtensions
{
    public static COV_USEDDto ToDto(this COV_USED entity)
    {
        if (entity == null) return null!;
        return new COV_USEDDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_CASENCLAIMSSTACASE = entity.CLAIM_CASENCLAIM?.SSTACASE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASENCASE_NUMSSTACASE = entity.CLAIM_CASENCASE_NUM?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_CASENDEMAN_TYPESSTACASE = entity.CLAIM_CASENDEMAN_TYPE?.SSTACASE,
            NGROUP_INSU = entity.NGROUP_INSU,
            NTRANSAC = entity.NTRANSAC,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCURRENCY = entity.NCURRENCY,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NSTARTDATE = entity.NSTARTDATE,
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
            NCAPITAL = entity.NCAPITAL,
            DCOMPDATE = entity.DCOMPDATE,
            NCON_ID = entity.NCON_ID,
            DEXPIRDAT = entity.DEXPIRDAT,
            NQUANTITY = entity.NQUANTITY,
            DRESTIT_DAT = entity.DRESTIT_DAT,
            NUSERCODE = entity.NUSERCODE,
            SPURPOSE = entity.SPURPOSE,
        };
    }

    public static COV_USED ToEntity(this CreateCOV_USEDDto dto)
    {
        if (dto == null) return null!;
        return new COV_USED
        {
            NGROUP_INSU = dto.NGROUP_INSU,
            NSTARTDATE = dto.NSTARTDATE,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NCAPITAL = dto.NCAPITAL,
            DCOMPDATE = dto.DCOMPDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NQUANTITY = dto.NQUANTITY,
            DRESTIT_DAT = dto.DRESTIT_DAT,
            NUSERCODE = dto.NUSERCODE,
            SPURPOSE = dto.SPURPOSE,
        };
    }

    public static void UpdateEntity(this COV_USED entity, UpdateCOV_USEDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NGROUP_INSU = dto.NGROUP_INSU;
        entity.NSTARTDATE = dto.NSTARTDATE;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.DRESTIT_DAT = dto.DRESTIT_DAT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPURPOSE = dto.SPURPOSE;
    }
}
