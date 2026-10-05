using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_POL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMM_POLMappingExtensions
{
    public static COMM_POLDto ToDto(this COMM_POL entity)
    {
        if (entity == null) return null!;
        return new COMM_POLDto
        {
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NCURRENCY = entity.NCURRENCY,
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
            NID = entity.NID,
            NTYPMOV_COMM = entity.NTYPMOV_COMM,
            TABLE5567SDESCRIPT = entity.TABLE5567?.SDESCRIPT,
            STYP_COMM = entity.STYP_COMM,
            NTOTAL_COM = entity.NTOTAL_COM,
            NINSTALLMENTS = entity.NINSTALLMENTS,
            NPEN_INSTALL = entity.NPEN_INSTALL,
            NINSTALL_AMO = entity.NINSTALL_AMO,
            NPAY_COMM = entity.NPAY_COMM,
            NCURR_ACC = entity.NCURR_ACC,
            NAVAILABLE = entity.NAVAILABLE,
            NAVAIL_AFEC = entity.NAVAIL_AFEC,
            NAVAIL_EXEN = entity.NAVAIL_EXEN,
            DEFFECDATE = entity.DEFFECDATE,
            NSTATUS_COMM = entity.NSTATUS_COMM,
            TABLE5568SDESCRIPT = entity.TABLE5568?.SDESCRIPT,
            STYPEDOCU = entity.STYPEDOCU,
            NDOCUMENT = entity.NDOCUMENT,
            NDRAFT = entity.NDRAFT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTRATYPEI = entity.NTRATYPEI,
            TABLE24SDESCRIPT = entity.TABLE24?.SDESCRIPT,
            NTYPE = entity.NTYPE,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            NTRANSAC = entity.NTRANSAC,
            NMAINYEAR_COMM = entity.NMAINYEAR_COMM,
            NRECEIPT = entity.NRECEIPT,
            NPERCADV_PAY = entity.NPERCADV_PAY,
            DACCRUALDATE = entity.DACCRUALDATE,
            NPREMIUMN_AN = entity.NPREMIUMN_AN,
            NPREMIUM_AN = entity.NPREMIUM_AN,
            NBALANCE = entity.NBALANCE,
            SIND_DESC = entity.SIND_DESC,
            SIND_BALANCE = entity.SIND_BALANCE,
            NCOD_SALDIS = entity.NCOD_SALDIS,
            NCATEGORY = entity.NCATEGORY,
            NID_CAMPAIGN = entity.NID_CAMPAIGN,
            DDATEEND_CAMP = entity.DDATEEND_CAMP,
        };
    }

    public static COMM_POL ToEntity(this CreateCOMM_POLDto dto)
    {
        if (dto == null) return null!;
        return new COMM_POL
        {
            NTYPMOV_COMM = dto.NTYPMOV_COMM,
            STYP_COMM = dto.STYP_COMM,
            NTOTAL_COM = dto.NTOTAL_COM,
            NINSTALLMENTS = dto.NINSTALLMENTS,
            NPEN_INSTALL = dto.NPEN_INSTALL,
            NINSTALL_AMO = dto.NINSTALL_AMO,
            NPAY_COMM = dto.NPAY_COMM,
            NCURR_ACC = dto.NCURR_ACC,
            NAVAILABLE = dto.NAVAILABLE,
            NAVAIL_AFEC = dto.NAVAIL_AFEC,
            NAVAIL_EXEN = dto.NAVAIL_EXEN,
            DEFFECDATE = dto.DEFFECDATE,
            NSTATUS_COMM = dto.NSTATUS_COMM,
            STYPEDOCU = dto.STYPEDOCU,
            NDOCUMENT = dto.NDOCUMENT,
            NDRAFT = dto.NDRAFT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTRATYPEI = dto.NTRATYPEI,
            NTYPE = dto.NTYPE,
            NTRANSAC = dto.NTRANSAC,
            NMAINYEAR_COMM = dto.NMAINYEAR_COMM,
            NRECEIPT = dto.NRECEIPT,
            NPERCADV_PAY = dto.NPERCADV_PAY,
            DACCRUALDATE = dto.DACCRUALDATE,
            NPREMIUMN_AN = dto.NPREMIUMN_AN,
            NPREMIUM_AN = dto.NPREMIUM_AN,
            NBALANCE = dto.NBALANCE,
            SIND_DESC = dto.SIND_DESC,
            SIND_BALANCE = dto.SIND_BALANCE,
            NCOD_SALDIS = dto.NCOD_SALDIS,
            NCATEGORY = dto.NCATEGORY,
            NID_CAMPAIGN = dto.NID_CAMPAIGN,
            DDATEEND_CAMP = dto.DDATEEND_CAMP,
        };
    }

    public static void UpdateEntity(this COMM_POL entity, UpdateCOMM_POLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPMOV_COMM = dto.NTYPMOV_COMM;
        entity.STYP_COMM = dto.STYP_COMM;
        entity.NTOTAL_COM = dto.NTOTAL_COM;
        entity.NINSTALLMENTS = dto.NINSTALLMENTS;
        entity.NPEN_INSTALL = dto.NPEN_INSTALL;
        entity.NINSTALL_AMO = dto.NINSTALL_AMO;
        entity.NPAY_COMM = dto.NPAY_COMM;
        entity.NCURR_ACC = dto.NCURR_ACC;
        entity.NAVAILABLE = dto.NAVAILABLE;
        entity.NAVAIL_AFEC = dto.NAVAIL_AFEC;
        entity.NAVAIL_EXEN = dto.NAVAIL_EXEN;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NSTATUS_COMM = dto.NSTATUS_COMM;
        entity.STYPEDOCU = dto.STYPEDOCU;
        entity.NDOCUMENT = dto.NDOCUMENT;
        entity.NDRAFT = dto.NDRAFT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.NTYPE = dto.NTYPE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NMAINYEAR_COMM = dto.NMAINYEAR_COMM;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NPERCADV_PAY = dto.NPERCADV_PAY;
        entity.DACCRUALDATE = dto.DACCRUALDATE;
        entity.NPREMIUMN_AN = dto.NPREMIUMN_AN;
        entity.NPREMIUM_AN = dto.NPREMIUM_AN;
        entity.NBALANCE = dto.NBALANCE;
        entity.SIND_DESC = dto.SIND_DESC;
        entity.SIND_BALANCE = dto.SIND_BALANCE;
        entity.NCOD_SALDIS = dto.NCOD_SALDIS;
        entity.NCATEGORY = dto.NCATEGORY;
        entity.NID_CAMPAIGN = dto.NID_CAMPAIGN;
        entity.DDATEEND_CAMP = dto.DDATEEND_CAMP;
    }
}
