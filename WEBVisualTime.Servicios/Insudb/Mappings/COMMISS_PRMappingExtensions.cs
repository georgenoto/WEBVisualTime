using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISS_PR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMISS_PRMappingExtensions
{
    public static COMMISS_PRDto ToDto(this COMMISS_PR entity)
    {
        if (entity == null) return null!;
        return new COMMISS_PRDto
        {
            NRECEIPT = entity.NRECEIPT,
            PREMIUMNRECEIPTSCESSIONS = entity.PREMIUMNRECEIPT?.SCESSIONS,
            NPRODUCT = entity.NPRODUCT,
            PREMIUMNPRODUCTSCESSIONS = entity.PREMIUMNPRODUCT?.SCESSIONS,
            NBRANCH = entity.NBRANCH,
            PREMIUMNBRANCHSCESSIONS = entity.PREMIUMNBRANCH?.SCESSIONS,
            SCERTYPE = entity.SCERTYPE,
            PREMIUMSCERTYPESCESSIONS = entity.PREMIUMSCERTYPE?.SCESSIONS,
            NDIGIT = entity.NDIGIT,
            PREMIUMNDIGITSCESSIONS = entity.PREMIUMNDIGIT?.SCESSIONS,
            NPAYNUMBE = entity.NPAYNUMBE,
            PREMIUMNPAYNUMBESCESSIONS = entity.PREMIUMNPAYNUMBE?.SCESSIONS,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NPROVINCE = entity.NPROVINCE,
            PROVINCESDESCRIPT = entity.PROVINCE?.SDESCRIPT,
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NPERCENT = entity.NPERCENT,
            NROLE = entity.NROLE,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            NSHARE = entity.NSHARE,
            NUSERCODE = entity.NUSERCODE,
            NCOM_AFEC = entity.NCOM_AFEC,
            NCOM_EXEN = entity.NCOM_EXEN,
            NDISC_AMOUNT = entity.NDISC_AMOUNT,
            NCATEGORY = entity.NCATEGORY,
            NID_CAMPAIGN = entity.NID_CAMPAIGN,
        };
    }

    public static COMMISS_PR ToEntity(this CreateCOMMISS_PRDto dto)
    {
        if (dto == null) return null!;
        return new COMMISS_PR
        {
            NPROVINCE = dto.NPROVINCE,
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NPERCENT = dto.NPERCENT,
            NROLE = dto.NROLE,
            NSHARE = dto.NSHARE,
            NUSERCODE = dto.NUSERCODE,
            NCOM_AFEC = dto.NCOM_AFEC,
            NCOM_EXEN = dto.NCOM_EXEN,
            NDISC_AMOUNT = dto.NDISC_AMOUNT,
            NCATEGORY = dto.NCATEGORY,
            NID_CAMPAIGN = dto.NID_CAMPAIGN,
        };
    }

    public static void UpdateEntity(this COMMISS_PR entity, UpdateCOMMISS_PRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NPERCENT = dto.NPERCENT;
        entity.NROLE = dto.NROLE;
        entity.NSHARE = dto.NSHARE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCOM_AFEC = dto.NCOM_AFEC;
        entity.NCOM_EXEN = dto.NCOM_EXEN;
        entity.NDISC_AMOUNT = dto.NDISC_AMOUNT;
        entity.NCATEGORY = dto.NCATEGORY;
        entity.NID_CAMPAIGN = dto.NID_CAMPAIGN;
    }
}
