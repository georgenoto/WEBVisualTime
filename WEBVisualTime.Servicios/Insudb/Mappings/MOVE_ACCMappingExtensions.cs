using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MOVE_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MOVE_ACCMappingExtensions
{
    public static MOVE_ACCDto ToDto(this MOVE_ACC entity)
    {
        if (entity == null) return null!;
        return new MOVE_ACCDto
        {
            NTYP_ACCO = entity.NTYP_ACCO,
            CURR_ACCNTYP_ACCOSSTATREGT = entity.CURR_ACCNTYP_ACCO?.SSTATREGT,
            STYPE_ACC = entity.STYPE_ACC,
            CURR_ACCSTYPE_ACCSSTATREGT = entity.CURR_ACCSTYPE_ACC?.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            CURR_ACCSCLIENTSSTATREGT = entity.CURR_ACCSCLIENT?.SSTATREGT,
            NCURRENCY = entity.NCURRENCY,
            CURR_ACCNCURRENCYSSTATREGT = entity.CURR_ACCNCURRENCY?.SSTATREGT,
            DOPERDATE = entity.DOPERDATE,
            NIDCONSEC = entity.NIDCONSEC,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NAMOUNT = entity.NAMOUNT,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NBRANCH = entity.NBRANCH,
            NCERTIF = entity.NCERTIF,
            SCHEQUE = entity.SCHEQUE,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCREDIT = entity.NCREDIT,
            NDEBIT = entity.NDEBIT,
            SDESCRIPT = entity.SDESCRIPT,
            SMANUALMOV = entity.SMANUALMOV,
            NPAYNUMBE = entity.NPAYNUMBE,
            NPOLICY = entity.NPOLICY,
            NRECEIPT = entity.NRECEIPT,
            SSTATREGT = entity.SSTATREGT,
            NTRANSAC = entity.NTRANSAC,
            NTRANSACTIO = entity.NTRANSACTIO,
            NTYPE_MOVE = entity.NTYPE_MOVE,
            TABLE401SDESCRIPT = entity.TABLE401?.SDESCRIPT,
            NTYPE_PAY = entity.NTYPE_PAY,
            TABLE137SDESCRIPT = entity.TABLE137?.SDESCRIPT,
            NTYPE_TRAN = entity.NTYPE_TRAN,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            NPROVINCE = entity.NPROVINCE,
            PROVINCESDESCRIPT = entity.PROVINCE?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NIDDOCUMENT = entity.NIDDOCUMENT,
            NREQUEST_NU = entity.NREQUEST_NU,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            SPROCESS = entity.SPROCESS,
            SNUMFORM = entity.SNUMFORM,
            NORIGCURR = entity.NORIGCURR,
            NEXCHANGE = entity.NEXCHANGE,
            SAUTORIZA = entity.SAUTORIZA,
            DVALUEDATE = entity.DVALUEDATE,
            NPRODUCT = entity.NPRODUCT,
            SNULL_RECOR = entity.SNULL_RECOR,
            NCASHNUM = entity.NCASHNUM,
            NAMOAFECT = entity.NAMOAFECT,
            NAMOEXEN = entity.NAMOEXEN,
            NPAY_COMM = entity.NPAY_COMM,
            NCURR_ACC = entity.NCURR_ACC,
            DPOSTED = entity.DPOSTED,
            SPROCESS_IND = entity.SPROCESS_IND,
            NPROPONUM = entity.NPROPONUM,
            NBULLETINS = entity.NBULLETINS,
            NNOTENUM = entity.NNOTENUM,
            NID = entity.NID,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NOBLIGATION = entity.NOBLIGATION,
            NSERV_ORDER = entity.NSERV_ORDER,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            NDOCUMENT = entity.NDOCUMENT,
            NAMOUNT_LOC = entity.NAMOUNT_LOC,
            NBALANCE = entity.NBALANCE,
            SCLIENT_REL = entity.SCLIENT_REL,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE182SDESCRIPT = entity.TABLE182?.SDESCRIPT,
            NCOD_AGREE = entity.NCOD_AGREE,
            NBILLNUM = entity.NBILLNUM,
            SDEP_NUMBER = entity.SDEP_NUMBER,
            NTODAYSDEPOSIT = entity.NTODAYSDEPOSIT,
            NRETENTIONTAXCODE = entity.NRETENTIONTAXCODE,
            NRETENTIONCODE = entity.NRETENTIONCODE,
            NRETENTIONSERIES = entity.NRETENTIONSERIES,
            DENDINGDATE = entity.DENDINGDATE,
            NRETENTION = entity.NRETENTION,
            NTAXRETENTION = entity.NTAXRETENTION,
            NRETENTIONBASE = entity.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = entity.NAUTORIZATIONNUMBER,
            DAUTORIZATIONDATE = entity.DAUTORIZATIONDATE,
            DCTB_DATE = entity.DCTB_DATE,
            SPOSTEDSEQUENCE = entity.SPOSTEDSEQUENCE,
            NORI_AMOUNT = entity.NORI_AMOUNT,
            SSCAB = entity.SSCAB,
            DDATE_SCAB = entity.DDATE_SCAB,
            NSEQ = entity.NSEQ,
        };
    }

    public static MOVE_ACC ToEntity(this CreateMOVE_ACCDto dto)
    {
        if (dto == null) return null!;
        return new MOVE_ACC
        {
            NINTERMED = dto.NINTERMED,
            NAMOUNT = dto.NAMOUNT,
            NBANKEXT = dto.NBANKEXT,
            NBRANCH = dto.NBRANCH,
            NCERTIF = dto.NCERTIF,
            SCHEQUE = dto.SCHEQUE,
            NCLAIM = dto.NCLAIM,
            NCREDIT = dto.NCREDIT,
            NDEBIT = dto.NDEBIT,
            SDESCRIPT = dto.SDESCRIPT,
            SMANUALMOV = dto.SMANUALMOV,
            NPAYNUMBE = dto.NPAYNUMBE,
            NPOLICY = dto.NPOLICY,
            NRECEIPT = dto.NRECEIPT,
            SSTATREGT = dto.SSTATREGT,
            NTRANSAC = dto.NTRANSAC,
            NTRANSACTIO = dto.NTRANSACTIO,
            NTYPE_MOVE = dto.NTYPE_MOVE,
            NTYPE_PAY = dto.NTYPE_PAY,
            NTYPE_TRAN = dto.NTYPE_TRAN,
            NUSERCODE = dto.NUSERCODE,
            NPROVINCE = dto.NPROVINCE,
            DCOMPDATE = dto.DCOMPDATE,
            NIDDOCUMENT = dto.NIDDOCUMENT,
            NREQUEST_NU = dto.NREQUEST_NU,
            NBORDEREAUX = dto.NBORDEREAUX,
            SPROCESS = dto.SPROCESS,
            SNUMFORM = dto.SNUMFORM,
            NORIGCURR = dto.NORIGCURR,
            NEXCHANGE = dto.NEXCHANGE,
            SAUTORIZA = dto.SAUTORIZA,
            DVALUEDATE = dto.DVALUEDATE,
            NPRODUCT = dto.NPRODUCT,
            SNULL_RECOR = dto.SNULL_RECOR,
            NCASHNUM = dto.NCASHNUM,
            NAMOAFECT = dto.NAMOAFECT,
            NAMOEXEN = dto.NAMOEXEN,
            NPAY_COMM = dto.NPAY_COMM,
            NCURR_ACC = dto.NCURR_ACC,
            DPOSTED = dto.DPOSTED,
            SPROCESS_IND = dto.SPROCESS_IND,
            NPROPONUM = dto.NPROPONUM,
            NBULLETINS = dto.NBULLETINS,
            NNOTENUM = dto.NNOTENUM,
            NID = dto.NID,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NOBLIGATION = dto.NOBLIGATION,
            NSERV_ORDER = dto.NSERV_ORDER,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NDOCUMENT = dto.NDOCUMENT,
            NAMOUNT_LOC = dto.NAMOUNT_LOC,
            NBALANCE = dto.NBALANCE,
            SCLIENT_REL = dto.SCLIENT_REL,
            SPAY_FORM = dto.SPAY_FORM,
            NCOD_AGREE = dto.NCOD_AGREE,
            NBILLNUM = dto.NBILLNUM,
            SDEP_NUMBER = dto.SDEP_NUMBER,
            NTODAYSDEPOSIT = dto.NTODAYSDEPOSIT,
            NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE,
            NRETENTIONCODE = dto.NRETENTIONCODE,
            NRETENTIONSERIES = dto.NRETENTIONSERIES,
            DENDINGDATE = dto.DENDINGDATE,
            NRETENTION = dto.NRETENTION,
            NTAXRETENTION = dto.NTAXRETENTION,
            NRETENTIONBASE = dto.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER,
            DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE,
            DCTB_DATE = dto.DCTB_DATE,
            SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE,
            NORI_AMOUNT = dto.NORI_AMOUNT,
            SSCAB = dto.SSCAB,
            DDATE_SCAB = dto.DDATE_SCAB,
            NSEQ = dto.NSEQ,
        };
    }

    public static void UpdateEntity(this MOVE_ACC entity, UpdateMOVE_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINTERMED = dto.NINTERMED;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCHEQUE = dto.SCHEQUE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCREDIT = dto.NCREDIT;
        entity.NDEBIT = dto.NDEBIT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SMANUALMOV = dto.SMANUALMOV;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NPOLICY = dto.NPOLICY;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NTRANSACTIO = dto.NTRANSACTIO;
        entity.NTYPE_MOVE = dto.NTYPE_MOVE;
        entity.NTYPE_PAY = dto.NTYPE_PAY;
        entity.NTYPE_TRAN = dto.NTYPE_TRAN;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NIDDOCUMENT = dto.NIDDOCUMENT;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.SPROCESS = dto.SPROCESS;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.NORIGCURR = dto.NORIGCURR;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.SAUTORIZA = dto.SAUTORIZA;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NAMOAFECT = dto.NAMOAFECT;
        entity.NAMOEXEN = dto.NAMOEXEN;
        entity.NPAY_COMM = dto.NPAY_COMM;
        entity.NCURR_ACC = dto.NCURR_ACC;
        entity.DPOSTED = dto.DPOSTED;
        entity.SPROCESS_IND = dto.SPROCESS_IND;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NID = dto.NID;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NOBLIGATION = dto.NOBLIGATION;
        entity.NSERV_ORDER = dto.NSERV_ORDER;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NDOCUMENT = dto.NDOCUMENT;
        entity.NAMOUNT_LOC = dto.NAMOUNT_LOC;
        entity.NBALANCE = dto.NBALANCE;
        entity.SCLIENT_REL = dto.SCLIENT_REL;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SDEP_NUMBER = dto.SDEP_NUMBER;
        entity.NTODAYSDEPOSIT = dto.NTODAYSDEPOSIT;
        entity.NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE;
        entity.NRETENTIONCODE = dto.NRETENTIONCODE;
        entity.NRETENTIONSERIES = dto.NRETENTIONSERIES;
        entity.DENDINGDATE = dto.DENDINGDATE;
        entity.NRETENTION = dto.NRETENTION;
        entity.NTAXRETENTION = dto.NTAXRETENTION;
        entity.NRETENTIONBASE = dto.NRETENTIONBASE;
        entity.NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER;
        entity.DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE;
        entity.DCTB_DATE = dto.DCTB_DATE;
        entity.SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE;
        entity.NORI_AMOUNT = dto.NORI_AMOUNT;
        entity.SSCAB = dto.SSCAB;
        entity.DDATE_SCAB = dto.DDATE_SCAB;
        entity.NSEQ = dto.NSEQ;
    }
}
