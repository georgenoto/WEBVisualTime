using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_PRODUCTION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BOOK_PRODUCTIONMappingExtensions
{
    public static BOOK_PRODUCTIONDto ToDto(this BOOK_PRODUCTION entity)
    {
        if (entity == null) return null!;
        return new BOOK_PRODUCTIONDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NRECEIPT = entity.NRECEIPT,
            NTRANSAC = entity.NTRANSAC,
            SKEY = entity.SKEY,
            SCLIENTSPONSOR = entity.SCLIENTSPONSOR,
            DSTARTDATE = entity.DSTARTDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NCERTIF = entity.NCERTIF,
            DDATE_ACCEPT = entity.DDATE_ACCEPT,
            SCLIENT_ASEG = entity.SCLIENT_ASEG,
            NCURRENCY = entity.NCURRENCY,
            NPREMIUME_MO = entity.NPREMIUME_MO,
            NPREMIUMA_MO = entity.NPREMIUMA_MO,
            NPREMIUM_MO = entity.NPREMIUM_MO,
            NPREMIUME = entity.NPREMIUME,
            NPREMIUMA = entity.NPREMIUMA,
            SCLIENT_AGEN = entity.SCLIENT_AGEN,
            NPREMIUM = entity.NPREMIUM,
            NCOMAMOU_MO = entity.NCOMAMOU_MO,
            NCOMAMOU_PES = entity.NCOMAMOU_PES,
            DPOSTED = entity.DPOSTED,
            NBRANCH_LED = entity.NBRANCH_LED,
            NCOMPANY = entity.NCOMPANY,
            NINSUR_AREA = entity.NINSUR_AREA,
            DSTARTDATE_REP = entity.DSTARTDATE_REP,
            DEXPIRDATE_REP = entity.DEXPIRDATE_REP,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NPROPONUM = entity.NPROPONUM,
            DLEDGERDAT = entity.DLEDGERDAT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            NTRATYPEI = entity.NTRATYPEI,
            TABLE24SDESCRIPT = entity.TABLE24?.SDESCRIPT,
            NTYPE = entity.NTYPE,
            NTYPE_TRAN = entity.NTYPE_TRAN,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            NTAXAMOUNT_MO = entity.NTAXAMOUNT_MO,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NACCCRITERION = entity.NACCCRITERION,
        };
    }

    public static BOOK_PRODUCTION ToEntity(this CreateBOOK_PRODUCTIONDto dto)
    {
        if (dto == null) return null!;
        return new BOOK_PRODUCTION
        {
            SCLIENTSPONSOR = dto.SCLIENTSPONSOR,
            DSTARTDATE = dto.DSTARTDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            DDATE_ACCEPT = dto.DDATE_ACCEPT,
            SCLIENT_ASEG = dto.SCLIENT_ASEG,
            NCURRENCY = dto.NCURRENCY,
            NPREMIUME_MO = dto.NPREMIUME_MO,
            NPREMIUMA_MO = dto.NPREMIUMA_MO,
            NPREMIUM_MO = dto.NPREMIUM_MO,
            NPREMIUME = dto.NPREMIUME,
            NPREMIUMA = dto.NPREMIUMA,
            SCLIENT_AGEN = dto.SCLIENT_AGEN,
            NPREMIUM = dto.NPREMIUM,
            NCOMAMOU_MO = dto.NCOMAMOU_MO,
            NCOMAMOU_PES = dto.NCOMAMOU_PES,
            DPOSTED = dto.DPOSTED,
            NCOMPANY = dto.NCOMPANY,
            NINSUR_AREA = dto.NINSUR_AREA,
            DSTARTDATE_REP = dto.DSTARTDATE_REP,
            DEXPIRDATE_REP = dto.DEXPIRDATE_REP,
            NOFFICE = dto.NOFFICE,
            NPROPONUM = dto.NPROPONUM,
            DLEDGERDAT = dto.DLEDGERDAT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            NTRATYPEI = dto.NTRATYPEI,
            NTYPE = dto.NTYPE,
            NTYPE_TRAN = dto.NTYPE_TRAN,
            NTAXAMOUNT_MO = dto.NTAXAMOUNT_MO,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NACCCRITERION = dto.NACCCRITERION,
        };
    }

    public static void UpdateEntity(this BOOK_PRODUCTION entity, UpdateBOOK_PRODUCTIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENTSPONSOR = dto.SCLIENTSPONSOR;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.DDATE_ACCEPT = dto.DDATE_ACCEPT;
        entity.SCLIENT_ASEG = dto.SCLIENT_ASEG;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPREMIUME_MO = dto.NPREMIUME_MO;
        entity.NPREMIUMA_MO = dto.NPREMIUMA_MO;
        entity.NPREMIUM_MO = dto.NPREMIUM_MO;
        entity.NPREMIUME = dto.NPREMIUME;
        entity.NPREMIUMA = dto.NPREMIUMA;
        entity.SCLIENT_AGEN = dto.SCLIENT_AGEN;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NCOMAMOU_MO = dto.NCOMAMOU_MO;
        entity.NCOMAMOU_PES = dto.NCOMAMOU_PES;
        entity.DPOSTED = dto.DPOSTED;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.DSTARTDATE_REP = dto.DSTARTDATE_REP;
        entity.DEXPIRDATE_REP = dto.DEXPIRDATE_REP;
        entity.NOFFICE = dto.NOFFICE;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.NTYPE = dto.NTYPE;
        entity.NTYPE_TRAN = dto.NTYPE_TRAN;
        entity.NTAXAMOUNT_MO = dto.NTAXAMOUNT_MO;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NACCCRITERION = dto.NACCCRITERION;
    }
}
