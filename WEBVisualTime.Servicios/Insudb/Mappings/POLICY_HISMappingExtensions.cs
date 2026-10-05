using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class POLICY_HISMappingExtensions
{
    public static POLICY_HISDto ToDto(this POLICY_HIS entity)
    {
        if (entity == null) return null!;
        return new POLICY_HISDto
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
            DCOMPDATE = entity.DCOMPDATE,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            SNULL_MOVE = entity.SNULL_MOVE,
            DNULLDATE = entity.DNULLDATE,
            NRECEIPT = entity.NRECEIPT,
            NTRANSACTIO = entity.NTRANSACTIO,
            NTYPE_HIST = entity.NTYPE_HIST,
            TABLE165SDESCRIPT = entity.TABLE165?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DLEDGERDAT = entity.DLEDGERDAT,
            NOFICIAL_P = entity.NOFICIAL_P,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            NSERV_ORDER = entity.NSERV_ORDER,
            NNOTENUM = entity.NNOTENUM,
            SINTERMEI = entity.SINTERMEI,
            DFER = entity.DFER,
            NPROPONUM = entity.NPROPONUM,
            NAGENCY = entity.NAGENCY,
            NWAIT_CODE = entity.NWAIT_CODE,
            TAB_WAITPOSDESCRIPT = entity.TAB_WAITPO?.SDESCRIPT,
            NSTATQUOTA = entity.NSTATQUOTA,
            TABLE5526SDESCRIPT = entity.TABLE5526?.SDESCRIPT,
            NNO_CONVERS = entity.NNO_CONVERS,
            NOCONVERSSDESCRIPT = entity.NOCONVERS?.SDESCRIPT,
            NCARTPOL = entity.NCARTPOL,
            NNUMCART = entity.NNUMCART,
            NPOLREF = entity.NPOLREF,
            NCERREF = entity.NCERREF,
            NPAYFREQ = entity.NPAYFREQ,
            NNULLCODE = entity.NNULLCODE,
            SFILE_REPORT = entity.SFILE_REPORT,
            SPROCESS_NUM = entity.SPROCESS_NUM,
            DSTARPROCESS = entity.DSTARPROCESS,
            DENDPROCESS = entity.DENDPROCESS,
            SIND_TRANFER = entity.SIND_TRANFER,
            SKEY = entity.SKEY,
            NSYSTEM = entity.NSYSTEM,
            SLOT = entity.SLOT,
            NWAY_PAY = entity.NWAY_PAY,
            NBILL_DAY = entity.NBILL_DAY,
            NCOD_AGREE = entity.NCOD_AGREE,
            AGREEMENTSSTATREGT = entity.AGREEMENT?.SSTATREGT,
            NNUMCERT = entity.NNUMCERT,
        };
    }

    public static POLICY_HIS ToEntity(this CreatePOLICY_HISDto dto)
    {
        if (dto == null) return null!;
        return new POLICY_HIS
        {
            DCOMPDATE = dto.DCOMPDATE,
            NCLAIM = dto.NCLAIM,
            NCURRENCY = dto.NCURRENCY,
            DEFFECDATE = dto.DEFFECDATE,
            SNULL_MOVE = dto.SNULL_MOVE,
            DNULLDATE = dto.DNULLDATE,
            NRECEIPT = dto.NRECEIPT,
            NTRANSACTIO = dto.NTRANSACTIO,
            NTYPE_HIST = dto.NTYPE_HIST,
            NUSERCODE = dto.NUSERCODE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NOFICIAL_P = dto.NOFICIAL_P,
            NTYPE_AMEND = dto.NTYPE_AMEND,
            NSERV_ORDER = dto.NSERV_ORDER,
            NNOTENUM = dto.NNOTENUM,
            SINTERMEI = dto.SINTERMEI,
            DFER = dto.DFER,
            NPROPONUM = dto.NPROPONUM,
            NAGENCY = dto.NAGENCY,
            NWAIT_CODE = dto.NWAIT_CODE,
            NSTATQUOTA = dto.NSTATQUOTA,
            NNO_CONVERS = dto.NNO_CONVERS,
            NCARTPOL = dto.NCARTPOL,
            NNUMCART = dto.NNUMCART,
            NPOLREF = dto.NPOLREF,
            NCERREF = dto.NCERREF,
            NPAYFREQ = dto.NPAYFREQ,
            NNULLCODE = dto.NNULLCODE,
            SFILE_REPORT = dto.SFILE_REPORT,
            SPROCESS_NUM = dto.SPROCESS_NUM,
            DSTARPROCESS = dto.DSTARPROCESS,
            DENDPROCESS = dto.DENDPROCESS,
            SIND_TRANFER = dto.SIND_TRANFER,
            SKEY = dto.SKEY,
            NSYSTEM = dto.NSYSTEM,
            SLOT = dto.SLOT,
            NWAY_PAY = dto.NWAY_PAY,
            NBILL_DAY = dto.NBILL_DAY,
            NCOD_AGREE = dto.NCOD_AGREE,
            NNUMCERT = dto.NNUMCERT,
        };
    }

    public static void UpdateEntity(this POLICY_HIS entity, UpdatePOLICY_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.SNULL_MOVE = dto.SNULL_MOVE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NTRANSACTIO = dto.NTRANSACTIO;
        entity.NTYPE_HIST = dto.NTYPE_HIST;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NOFICIAL_P = dto.NOFICIAL_P;
        entity.NTYPE_AMEND = dto.NTYPE_AMEND;
        entity.NSERV_ORDER = dto.NSERV_ORDER;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SINTERMEI = dto.SINTERMEI;
        entity.DFER = dto.DFER;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NAGENCY = dto.NAGENCY;
        entity.NWAIT_CODE = dto.NWAIT_CODE;
        entity.NSTATQUOTA = dto.NSTATQUOTA;
        entity.NNO_CONVERS = dto.NNO_CONVERS;
        entity.NCARTPOL = dto.NCARTPOL;
        entity.NNUMCART = dto.NNUMCART;
        entity.NPOLREF = dto.NPOLREF;
        entity.NCERREF = dto.NCERREF;
        entity.NPAYFREQ = dto.NPAYFREQ;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.SFILE_REPORT = dto.SFILE_REPORT;
        entity.SPROCESS_NUM = dto.SPROCESS_NUM;
        entity.DSTARPROCESS = dto.DSTARPROCESS;
        entity.DENDPROCESS = dto.DENDPROCESS;
        entity.SIND_TRANFER = dto.SIND_TRANFER;
        entity.SKEY = dto.SKEY;
        entity.NSYSTEM = dto.NSYSTEM;
        entity.SLOT = dto.SLOT;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.NBILL_DAY = dto.NBILL_DAY;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NNUMCERT = dto.NNUMCERT;
    }
}
