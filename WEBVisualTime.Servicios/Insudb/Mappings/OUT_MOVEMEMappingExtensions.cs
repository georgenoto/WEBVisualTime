using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_MOVEME;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class OUT_MOVEMEMappingExtensions
{
    public static OUT_MOVEMEDto ToDto(this OUT_MOVEME entity)
    {
        if (entity == null) return null!;
        return new OUT_MOVEMEDto
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
            NMOVNUMBE = entity.NMOVNUMBE,
            NDIGIT = entity.NDIGIT,
            NCAPITAL = entity.NCAPITAL,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NPREMIUM = entity.NPREMIUM,
            SSTATUS_MOV = entity.SSTATUS_MOV,
            NTAXAMOU = entity.NTAXAMOU,
            NTRATYPEI = entity.NTRATYPEI,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            SZONE = entity.SZONE,
            NPROVINCE = entity.NPROVINCE,
            DSTARTDATE = entity.DSTARTDATE,
            NINSUR_AREA = entity.NINSUR_AREA,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            NORIGI = entity.NORIGI,
            NRECEIPT = entity.NRECEIPT,
            NSITUATION = entity.NSITUATION,
            SCLIENT = entity.SCLIENT,
            NGROUP = entity.NGROUP,
            NMOVNUMBE_REL = entity.NMOVNUMBE_REL,
            NPREMIUMTEC = entity.NPREMIUMTEC,
            NMOVEMENT = entity.NMOVEMENT,
        };
    }

    public static OUT_MOVEME ToEntity(this CreateOUT_MOVEMEDto dto)
    {
        if (dto == null) return null!;
        return new OUT_MOVEME
        {
            NCAPITAL = dto.NCAPITAL,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NPREMIUM = dto.NPREMIUM,
            SSTATUS_MOV = dto.SSTATUS_MOV,
            NTAXAMOU = dto.NTAXAMOU,
            NTRATYPEI = dto.NTRATYPEI,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            SZONE = dto.SZONE,
            NPROVINCE = dto.NPROVINCE,
            DSTARTDATE = dto.DSTARTDATE,
            NINSUR_AREA = dto.NINSUR_AREA,
            NWAY_PAY = dto.NWAY_PAY,
            NORIGI = dto.NORIGI,
            NRECEIPT = dto.NRECEIPT,
            NSITUATION = dto.NSITUATION,
            SCLIENT = dto.SCLIENT,
            NGROUP = dto.NGROUP,
            NMOVNUMBE_REL = dto.NMOVNUMBE_REL,
            NPREMIUMTEC = dto.NPREMIUMTEC,
            NMOVEMENT = dto.NMOVEMENT,
        };
    }

    public static void UpdateEntity(this OUT_MOVEME entity, UpdateOUT_MOVEMEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.SSTATUS_MOV = dto.SSTATUS_MOV;
        entity.NTAXAMOU = dto.NTAXAMOU;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.SZONE = dto.SZONE;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.NORIGI = dto.NORIGI;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NSITUATION = dto.NSITUATION;
        entity.SCLIENT = dto.SCLIENT;
        entity.NGROUP = dto.NGROUP;
        entity.NMOVNUMBE_REL = dto.NMOVNUMBE_REL;
        entity.NPREMIUMTEC = dto.NPREMIUMTEC;
        entity.NMOVEMENT = dto.NMOVEMENT;
    }
}
