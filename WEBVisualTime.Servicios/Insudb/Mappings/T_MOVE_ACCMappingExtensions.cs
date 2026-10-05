using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MOVE_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_MOVE_ACCMappingExtensions
{
    public static T_MOVE_ACCDto ToDto(this T_MOVE_ACC entity)
    {
        if (entity == null) return null!;
        return new T_MOVE_ACCDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NSEQUENCE = entity.NSEQUENCE,
            NTYP_ACCO = entity.NTYP_ACCO,
            NCURRENCY = entity.NCURRENCY,
            SCLIENT = entity.SCLIENT,
            NCREDIT = entity.NCREDIT,
            NDEBIT = entity.NDEBIT,
            NTYPE_MOVE = entity.NTYPE_MOVE,
            NBRANCH = entity.NBRANCH,
            SAUTORIZA = entity.SAUTORIZA,
            NEXCHANGE = entity.NEXCHANGE,
            SNUMFORM = entity.SNUMFORM,
            NINTERMED = entity.NINTERMED,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NRECEIPT = entity.NRECEIPT,
            NPROPONUM = entity.NPROPONUM,
            NCERTIF = entity.NCERTIF,
            STYPE_ACC = entity.STYPE_ACC,
            DOPERDATE = entity.DOPERDATE,
            NIDCONSEC = entity.NIDCONSEC,
            NAMOUNT = entity.NAMOUNT,
            NBANKEXT = entity.NBANKEXT,
            SCHEQUE = entity.SCHEQUE,
            NCLAIM = entity.NCLAIM,
            SDESCRIPT = entity.SDESCRIPT,
            SMANUALMOV = entity.SMANUALMOV,
            NPAYNUMBE = entity.NPAYNUMBE,
            SSTATREGT = entity.SSTATREGT,
            NTRANSAC = entity.NTRANSAC,
            NTRANSACTIO = entity.NTRANSACTIO,
            NTYPE_PAY = entity.NTYPE_PAY,
            NTYPE_TRAN = entity.NTYPE_TRAN,
            NUSERCODE = entity.NUSERCODE,
            NPROVINCE = entity.NPROVINCE,
            DCOMPDATE = entity.DCOMPDATE,
            NIDDOCUMENT = entity.NIDDOCUMENT,
            NREQUEST_NU = entity.NREQUEST_NU,
            SPROCESS = entity.SPROCESS,
            NORIGCURR = entity.NORIGCURR,
            DVALUEDATE = entity.DVALUEDATE,
            SNULL_RECOR = entity.SNULL_RECOR,
            NCASHNUM = entity.NCASHNUM,
            NAMOAFECT = entity.NAMOAFECT,
            NAMOEXENT = entity.NAMOEXENT,
            NPAY_COMM = entity.NPAY_COMM,
            NCURR_ACC = entity.NCURR_ACC,
            DPOSTED = entity.DPOSTED,
            SPROCESS_IND = entity.SPROCESS_IND,
            NBULLETINS = entity.NBULLETINS,
            NNOTENUM = entity.NNOTENUM,
            SACTION = entity.SACTION,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NCOD_AGREE = entity.NCOD_AGREE,
            NORI_AMOUNT = entity.NORI_AMOUNT,
        };
    }

    public static T_MOVE_ACC ToEntity(this CreateT_MOVE_ACCDto dto)
    {
        if (dto == null) return null!;
        return new T_MOVE_ACC
        {
            NTYP_ACCO = dto.NTYP_ACCO,
            NCURRENCY = dto.NCURRENCY,
            SCLIENT = dto.SCLIENT,
            NCREDIT = dto.NCREDIT,
            NDEBIT = dto.NDEBIT,
            NTYPE_MOVE = dto.NTYPE_MOVE,
            NBRANCH = dto.NBRANCH,
            SAUTORIZA = dto.SAUTORIZA,
            NEXCHANGE = dto.NEXCHANGE,
            SNUMFORM = dto.SNUMFORM,
            NINTERMED = dto.NINTERMED,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NRECEIPT = dto.NRECEIPT,
            NPROPONUM = dto.NPROPONUM,
            NCERTIF = dto.NCERTIF,
            STYPE_ACC = dto.STYPE_ACC,
            DOPERDATE = dto.DOPERDATE,
            NIDCONSEC = dto.NIDCONSEC,
            NAMOUNT = dto.NAMOUNT,
            NBANKEXT = dto.NBANKEXT,
            SCHEQUE = dto.SCHEQUE,
            NCLAIM = dto.NCLAIM,
            SDESCRIPT = dto.SDESCRIPT,
            SMANUALMOV = dto.SMANUALMOV,
            NPAYNUMBE = dto.NPAYNUMBE,
            SSTATREGT = dto.SSTATREGT,
            NTRANSAC = dto.NTRANSAC,
            NTRANSACTIO = dto.NTRANSACTIO,
            NTYPE_PAY = dto.NTYPE_PAY,
            NTYPE_TRAN = dto.NTYPE_TRAN,
            NUSERCODE = dto.NUSERCODE,
            NPROVINCE = dto.NPROVINCE,
            DCOMPDATE = dto.DCOMPDATE,
            NIDDOCUMENT = dto.NIDDOCUMENT,
            NREQUEST_NU = dto.NREQUEST_NU,
            SPROCESS = dto.SPROCESS,
            NORIGCURR = dto.NORIGCURR,
            DVALUEDATE = dto.DVALUEDATE,
            SNULL_RECOR = dto.SNULL_RECOR,
            NCASHNUM = dto.NCASHNUM,
            NAMOAFECT = dto.NAMOAFECT,
            NAMOEXENT = dto.NAMOEXENT,
            NPAY_COMM = dto.NPAY_COMM,
            NCURR_ACC = dto.NCURR_ACC,
            DPOSTED = dto.DPOSTED,
            SPROCESS_IND = dto.SPROCESS_IND,
            NBULLETINS = dto.NBULLETINS,
            NNOTENUM = dto.NNOTENUM,
            SACTION = dto.SACTION,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NCOD_AGREE = dto.NCOD_AGREE,
            NORI_AMOUNT = dto.NORI_AMOUNT,
        };
    }

    public static void UpdateEntity(this T_MOVE_ACC entity, UpdateT_MOVE_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCREDIT = dto.NCREDIT;
        entity.NDEBIT = dto.NDEBIT;
        entity.NTYPE_MOVE = dto.NTYPE_MOVE;
        entity.NBRANCH = dto.NBRANCH;
        entity.SAUTORIZA = dto.SAUTORIZA;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.NINTERMED = dto.NINTERMED;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NCERTIF = dto.NCERTIF;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.DOPERDATE = dto.DOPERDATE;
        entity.NIDCONSEC = dto.NIDCONSEC;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SCHEQUE = dto.SCHEQUE;
        entity.NCLAIM = dto.NCLAIM;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SMANUALMOV = dto.SMANUALMOV;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NTRANSACTIO = dto.NTRANSACTIO;
        entity.NTYPE_PAY = dto.NTYPE_PAY;
        entity.NTYPE_TRAN = dto.NTYPE_TRAN;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NIDDOCUMENT = dto.NIDDOCUMENT;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.SPROCESS = dto.SPROCESS;
        entity.NORIGCURR = dto.NORIGCURR;
        entity.DVALUEDATE = dto.DVALUEDATE;
        entity.SNULL_RECOR = dto.SNULL_RECOR;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NAMOAFECT = dto.NAMOAFECT;
        entity.NAMOEXENT = dto.NAMOEXENT;
        entity.NPAY_COMM = dto.NPAY_COMM;
        entity.NCURR_ACC = dto.NCURR_ACC;
        entity.DPOSTED = dto.DPOSTED;
        entity.SPROCESS_IND = dto.SPROCESS_IND;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SACTION = dto.SACTION;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NORI_AMOUNT = dto.NORI_AMOUNT;
    }
}
