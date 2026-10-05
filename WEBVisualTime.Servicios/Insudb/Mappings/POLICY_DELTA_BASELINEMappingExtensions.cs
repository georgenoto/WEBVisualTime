using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_DELTA_BASELINE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class POLICY_DELTA_BASELINEMappingExtensions
{
    public static POLICY_DELTA_BASELINEDto ToDto(this POLICY_DELTA_BASELINE entity)
    {
        if (entity == null) return null!;
        return new POLICY_DELTA_BASELINEDto
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
            NMOVEMENT = entity.NMOVEMENT,
            STYPE = entity.STYPE,
            SCLIENT = entity.SCLIENT,
            NITEM_CODE = entity.NITEM_CODE,
            NCURRENCY = entity.NCURRENCY,
            NCAPITAL = entity.NCAPITAL,
            NPREMIUM = entity.NPREMIUM,
            NPERCENT = entity.NPERCENT,
            SSMOKER = entity.SSMOKER,
            STYP_RISK = entity.STYP_RISK,
            SSTREET = entity.SSTREET,
            STYPEOFADDRESS = entity.STYPEOFADDRESS,
            SPHONE = entity.SPHONE,
            NFUNDS = entity.NFUNDS,
            NPAY_WAY = entity.NPAY_WAY,
            NTYP_CRECARD = entity.NTYP_CRECARD,
            NTYP_ACC = entity.NTYP_ACC,
            SACCOUNT = entity.SACCOUNT,
            NBANKEXT = entity.NBANKEXT,
            SCREDI_CARD = entity.SCREDI_CARD,
            DCARDEXPIR = entity.DCARDEXPIR,
            SDIRIND = entity.SDIRIND,
            DCOMPDATE = entity.DCOMPDATE,
            NTYPERISK = entity.NTYPERISK,
            NPAYFREQ = entity.NPAYFREQ,
            NROLE = entity.NROLE,
            NMODULEC = entity.NMODULEC,
        };
    }

    public static POLICY_DELTA_BASELINE ToEntity(this CreatePOLICY_DELTA_BASELINEDto dto)
    {
        if (dto == null) return null!;
        return new POLICY_DELTA_BASELINE
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NMOVEMENT = dto.NMOVEMENT,
            STYPE = dto.STYPE,
            SCLIENT = dto.SCLIENT,
            NITEM_CODE = dto.NITEM_CODE,
            NCURRENCY = dto.NCURRENCY,
            NCAPITAL = dto.NCAPITAL,
            NPREMIUM = dto.NPREMIUM,
            NPERCENT = dto.NPERCENT,
            SSMOKER = dto.SSMOKER,
            STYP_RISK = dto.STYP_RISK,
            SSTREET = dto.SSTREET,
            STYPEOFADDRESS = dto.STYPEOFADDRESS,
            SPHONE = dto.SPHONE,
            NFUNDS = dto.NFUNDS,
            NPAY_WAY = dto.NPAY_WAY,
            NTYP_CRECARD = dto.NTYP_CRECARD,
            NTYP_ACC = dto.NTYP_ACC,
            SACCOUNT = dto.SACCOUNT,
            NBANKEXT = dto.NBANKEXT,
            SCREDI_CARD = dto.SCREDI_CARD,
            DCARDEXPIR = dto.DCARDEXPIR,
            SDIRIND = dto.SDIRIND,
            DCOMPDATE = dto.DCOMPDATE,
            NTYPERISK = dto.NTYPERISK,
            NPAYFREQ = dto.NPAYFREQ,
            NROLE = dto.NROLE,
            NMODULEC = dto.NMODULEC,
        };
    }

    public static void UpdateEntity(this POLICY_DELTA_BASELINE entity, UpdatePOLICY_DELTA_BASELINEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.STYPE = dto.STYPE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NITEM_CODE = dto.NITEM_CODE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPERCENT = dto.NPERCENT;
        entity.SSMOKER = dto.SSMOKER;
        entity.STYP_RISK = dto.STYP_RISK;
        entity.SSTREET = dto.SSTREET;
        entity.STYPEOFADDRESS = dto.STYPEOFADDRESS;
        entity.SPHONE = dto.SPHONE;
        entity.NFUNDS = dto.NFUNDS;
        entity.NPAY_WAY = dto.NPAY_WAY;
        entity.NTYP_CRECARD = dto.NTYP_CRECARD;
        entity.NTYP_ACC = dto.NTYP_ACC;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SCREDI_CARD = dto.SCREDI_CARD;
        entity.DCARDEXPIR = dto.DCARDEXPIR;
        entity.SDIRIND = dto.SDIRIND;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NTYPERISK = dto.NTYPERISK;
        entity.NPAYFREQ = dto.NPAYFREQ;
        entity.NROLE = dto.NROLE;
        entity.NMODULEC = dto.NMODULEC;
    }
}
