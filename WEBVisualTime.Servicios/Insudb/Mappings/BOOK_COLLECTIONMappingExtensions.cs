using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_COLLECTION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BOOK_COLLECTIONMappingExtensions
{
    public static BOOK_COLLECTIONDto ToDto(this BOOK_COLLECTION entity)
    {
        if (entity == null) return null!;
        return new BOOK_COLLECTIONDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NRECEIPT = entity.NRECEIPT,
            NBRANCH_LED = entity.NBRANCH_LED,
            NTRANSAC = entity.NTRANSAC,
            SKEY = entity.SKEY,
            NEXCHANGE = entity.NEXCHANGE,
            NBORDEREAUX = entity.NBORDEREAUX,
            NTRATYPEI = entity.NTRATYPEI,
            TABLE24SDESCRIPT = entity.TABLE24?.SDESCRIPT,
            DCOLLECTION = entity.DCOLLECTION,
            DEFFECDATE = entity.DEFFECDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NTYPE = entity.NTYPE,
            NCONTRAT = entity.NCONTRAT,
            NDRAFT = entity.NDRAFT,
            NINTEREST = entity.NINTEREST,
            NINTAMMOU_AFE = entity.NINTAMMOU_AFE,
            NINTAMMOU_IVA = entity.NINTAMMOU_IVA,
            DVALUEDATE = entity.DVALUEDATE,
            DPOSTED = entity.DPOSTED,
            NWAY_PAY = entity.NWAY_PAY,
            NCURRENCY = entity.NCURRENCY,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            DLEDGERDAT = entity.DLEDGERDAT,
            DSTATDATE = entity.DSTATDATE,
            SPAY_FORM = entity.SPAY_FORM,
            NCOVBAS = entity.NCOVBAS,
            NCOVADD = entity.NCOVADD,
            NTAX = entity.NTAX,
            NREC_DESC = entity.NREC_DESC,
            NBORDERUSED = entity.NBORDERUSED,
            NBORDEREAUX_USERCOD = entity.NBORDEREAUX_USERCOD,
            NCASHNUM = entity.NCASHNUM,
            SCLIENTSPONSOR = entity.SCLIENTSPONSOR,
            SCLIENT_ASEG = entity.SCLIENT_ASEG,
            NPREMIUME_MO = entity.NPREMIUME_MO,
            NPREMIUMA_MO = entity.NPREMIUMA_MO,
            NTAXAMOUNT_MO = entity.NTAXAMOUNT_MO,
            NPREMIUM_MO = entity.NPREMIUM_MO,
            NPREMIUME = entity.NPREMIUME,
            NPREMIUMA = entity.NPREMIUMA,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NPREMIUM = entity.NPREMIUM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYPE_TRAN = entity.NTYPE_TRAN,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            DSTATDATE_NEW = entity.DSTATDATE_NEW,
            DSTATDATE_OLD = entity.DSTATDATE_OLD,
            NBILLNUM = entity.NBILLNUM,
            NUSER_OLD = entity.NUSER_OLD,
            NUSER = entity.NUSER,
        };
    }

    public static BOOK_COLLECTION ToEntity(this CreateBOOK_COLLECTIONDto dto)
    {
        if (dto == null) return null!;
        return new BOOK_COLLECTION
        {
            NEXCHANGE = dto.NEXCHANGE,
            NBORDEREAUX = dto.NBORDEREAUX,
            NTRATYPEI = dto.NTRATYPEI,
            DCOLLECTION = dto.DCOLLECTION,
            DEFFECDATE = dto.DEFFECDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NTYPE = dto.NTYPE,
            NCONTRAT = dto.NCONTRAT,
            NDRAFT = dto.NDRAFT,
            NINTEREST = dto.NINTEREST,
            NINTAMMOU_AFE = dto.NINTAMMOU_AFE,
            NINTAMMOU_IVA = dto.NINTAMMOU_IVA,
            DVALUEDATE = dto.DVALUEDATE,
            DPOSTED = dto.DPOSTED,
            NWAY_PAY = dto.NWAY_PAY,
            NCURRENCY = dto.NCURRENCY,
            NOFFICE = dto.NOFFICE,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            DLEDGERDAT = dto.DLEDGERDAT,
            DSTATDATE = dto.DSTATDATE,
            SPAY_FORM = dto.SPAY_FORM,
            NCOVBAS = dto.NCOVBAS,
            NCOVADD = dto.NCOVADD,
            NTAX = dto.NTAX,
            NREC_DESC = dto.NREC_DESC,
            NBORDERUSED = dto.NBORDERUSED,
            NBORDEREAUX_USERCOD = dto.NBORDEREAUX_USERCOD,
            NCASHNUM = dto.NCASHNUM,
            SCLIENTSPONSOR = dto.SCLIENTSPONSOR,
            SCLIENT_ASEG = dto.SCLIENT_ASEG,
            NPREMIUME_MO = dto.NPREMIUME_MO,
            NPREMIUMA_MO = dto.NPREMIUMA_MO,
            NTAXAMOUNT_MO = dto.NTAXAMOUNT_MO,
            NPREMIUM_MO = dto.NPREMIUM_MO,
            NPREMIUME = dto.NPREMIUME,
            NPREMIUMA = dto.NPREMIUMA,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NPREMIUM = dto.NPREMIUM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYPE_TRAN = dto.NTYPE_TRAN,
            DSTATDATE_NEW = dto.DSTATDATE_NEW,
            DSTATDATE_OLD = dto.DSTATDATE_OLD,
            NBILLNUM = dto.NBILLNUM,
            NUSER_OLD = dto.NUSER_OLD,
            NUSER = dto.NUSER,
        };
    }

    public static void UpdateEntity(this BOOK_COLLECTION entity, UpdateBOOK_COLLECTIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NTRATYPEI = dto.NTRATYPEI;
        entity.DCOLLECTION = dto.DCOLLECTION;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NTYPE = dto.NTYPE;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NDRAFT = dto.NDRAFT;
        entity.NINTEREST = dto.NINTEREST;
        entity.NINTAMMOU_AFE = dto.NINTAMMOU_AFE;
        entity.NINTAMMOU_IVA = dto.NINTAMMOU_IVA;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.DPOSTED = dto.DPOSTED;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NOFFICE = dto.NOFFICE;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.DSTATDATE = dto.DSTATDATE;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.NCOVBAS = dto.NCOVBAS;
        entity.NCOVADD = dto.NCOVADD;
        entity.NTAX = dto.NTAX;
        entity.NREC_DESC = dto.NREC_DESC;
        entity.NBORDERUSED = dto.NBORDERUSED;
        entity.NBORDEREAUX_USERCOD = dto.NBORDEREAUX_USERCOD;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.SCLIENTSPONSOR = dto.SCLIENTSPONSOR;
        entity.SCLIENT_ASEG = dto.SCLIENT_ASEG;
        entity.NPREMIUME_MO = dto.NPREMIUME_MO;
        entity.NPREMIUMA_MO = dto.NPREMIUMA_MO;
        entity.NTAXAMOUNT_MO = dto.NTAXAMOUNT_MO;
        entity.NPREMIUM_MO = dto.NPREMIUM_MO;
        entity.NPREMIUME = dto.NPREMIUME;
        entity.NPREMIUMA = dto.NPREMIUMA;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPE_TRAN = dto.NTYPE_TRAN;
        entity.DSTATDATE_NEW = dto.DSTATDATE_NEW;
        entity.DSTATDATE_OLD = dto.DSTATDATE_OLD;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.NUSER_OLD = dto.NUSER_OLD;
        entity.NUSER = dto.NUSER;
    }
}
