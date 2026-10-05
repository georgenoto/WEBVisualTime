using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_CE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PREMIUM_CEMappingExtensions
{
    public static PREMIUM_CEDto ToDto(this PREMIUM_CE entity)
    {
        if (entity == null) return null!;
        return new PREMIUM_CEDto
        {
            SCERTYPE = entity.SCERTYPE,
            PREMIUMSCERTYPESCESSIONS = entity.PREMIUMSCERTYPE?.SCESSIONS,
            NPRODUCT = entity.NPRODUCT,
            PREMIUMNPRODUCTSCESSIONS = entity.PREMIUMNPRODUCT?.SCESSIONS,
            NBRANCH = entity.NBRANCH,
            PREMIUMNBRANCHSCESSIONS = entity.PREMIUMNBRANCH?.SCESSIONS,
            NRECEIPT = entity.NRECEIPT,
            PREMIUMNRECEIPTSCESSIONS = entity.PREMIUMNRECEIPT?.SCESSIONS,
            NDIGIT = entity.NDIGIT,
            PREMIUMNDIGITSCESSIONS = entity.PREMIUMNDIGIT?.SCESSIONS,
            NPAYNUMBE = entity.NPAYNUMBE,
            PREMIUMNPAYNUMBESCESSIONS = entity.PREMIUMNPAYNUMBE?.SCESSIONS,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            STYPE_DETAI = entity.STYPE_DETAI,
            NID_BILL = entity.NID_BILL,
            NCODE_DETAI = entity.NCODE_DETAI,
            NBILL_ITEM = entity.NBILL_ITEM,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NPREMIUM = entity.NPREMIUM,
            NPREMIUMN = entity.NPREMIUMN,
            DSTARTDATE = entity.DSTARTDATE,
            NTRATYPEI = entity.NTRATYPEI,
            TABLE24SDESCRIPT = entity.TABLE24?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            NPREMANUAL = entity.NPREMANUAL,
            NCOMANUAL = entity.NCOMANUAL,
            SADDTAX = entity.SADDTAX,
            NPREMIUMA = entity.NPREMIUMA,
            NPREMIUME = entity.NPREMIUME,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NRECAMOUNT = entity.NRECAMOUNT,
            NDESCAMOUNT = entity.NDESCAMOUNT,
            NORIGI = entity.NORIGI,
            NREL_IDBILL = entity.NREL_IDBILL,
            SCLIENT = entity.SCLIENT,
            NCAPITAL = entity.NCAPITAL,
            NCOMMI_RATE = entity.NCOMMI_RATE,
            NCOMMISION = entity.NCOMMISION,
            NDISSUR_TYPE = entity.NDISSUR_TYPE,
        };
    }

    public static PREMIUM_CE ToEntity(this CreatePREMIUM_CEDto dto)
    {
        if (dto == null) return null!;
        return new PREMIUM_CE
        {
            STYPE_DETAI = dto.STYPE_DETAI,
            NCODE_DETAI = dto.NCODE_DETAI,
            NBILL_ITEM = dto.NBILL_ITEM,
            NBRANCH_REI = dto.NBRANCH_REI,
            DCOMPDATE = dto.DCOMPDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NPREMIUM = dto.NPREMIUM,
            NPREMIUMN = dto.NPREMIUMN,
            DSTARTDATE = dto.DSTARTDATE,
            NTRATYPEI = dto.NTRATYPEI,
            NUSERCODE = dto.NUSERCODE,
            NPREMANUAL = dto.NPREMANUAL,
            NCOMANUAL = dto.NCOMANUAL,
            SADDTAX = dto.SADDTAX,
            NPREMIUMA = dto.NPREMIUMA,
            NPREMIUME = dto.NPREMIUME,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NRECAMOUNT = dto.NRECAMOUNT,
            NDESCAMOUNT = dto.NDESCAMOUNT,
            NORIGI = dto.NORIGI,
            NREL_IDBILL = dto.NREL_IDBILL,
            SCLIENT = dto.SCLIENT,
            NCAPITAL = dto.NCAPITAL,
            NCOMMI_RATE = dto.NCOMMI_RATE,
            NCOMMISION = dto.NCOMMISION,
            NDISSUR_TYPE = dto.NDISSUR_TYPE,
        };
    }

    public static void UpdateEntity(this PREMIUM_CE entity, UpdatePREMIUM_CEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STYPE_DETAI = dto.STYPE_DETAI;
        entity.NCODE_DETAI = dto.NCODE_DETAI;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPREMIUMN = dto.NPREMIUMN;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPREMANUAL = dto.NPREMANUAL;
        entity.NCOMANUAL = dto.NCOMANUAL;
        entity.SADDTAX = dto.SADDTAX;
        entity.NPREMIUMA = dto.NPREMIUMA;
        entity.NPREMIUME = dto.NPREMIUME;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NRECAMOUNT = dto.NRECAMOUNT;
        entity.NDESCAMOUNT = dto.NDESCAMOUNT;
        entity.NORIGI = dto.NORIGI;
        entity.NREL_IDBILL = dto.NREL_IDBILL;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMI_RATE = dto.NCOMMI_RATE;
        entity.NCOMMISION = dto.NCOMMISION;
        entity.NDISSUR_TYPE = dto.NDISSUR_TYPE;
    }
}
