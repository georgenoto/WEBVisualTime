using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_II;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HIS_ASC_IIMappingExtensions
{
    public static HIS_ASC_IIDto ToDto(this HIS_ASC_II entity)
    {
        if (entity == null) return null!;
        return new HIS_ASC_IIDto
        {
            NID_UPLOAD = entity.NID_UPLOAD,
            NID = entity.NID,
            SBANK_ORI = entity.SBANK_ORI,
            NPERIOD_YEAR = entity.NPERIOD_YEAR,
            NPERIOD_MONTH = entity.NPERIOD_MONTH,
            NORDER = entity.NORDER,
            SUNIQ_CODE = entity.SUNIQ_CODE,
            NAMOUNT = entity.NAMOUNT,
            SCURRENCY = entity.SCURRENCY,
            SPAY_MET = entity.SPAY_MET,
            SCONCEPT = entity.SCONCEPT,
            SREFERENCE = entity.SREFERENCE,
            SDOC_TYPE = entity.SDOC_TYPE,
            SCLIENAME = entity.SCLIENAME,
            SPHON_BEN = entity.SPHON_BEN,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            SBANKEXT = entity.SBANKEXT,
            SSTATUS = entity.SSTATUS,
            SREASON = entity.SREASON,
            SDETAIL = entity.SDETAIL,
            NCHEQUE = entity.NCHEQUE,
            NORDER_ACH = entity.NORDER_ACH,
            DATE_UPLOAD = entity.DATE_UPLOAD,
            DATE_PAY = entity.DATE_PAY,
            NTRANSF = entity.NTRANSF,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATMOV = entity.SSTATMOV,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NREQUEST_NU = entity.NREQUEST_NU,
            SKEY = entity.SKEY,
            NDOCUMENT = entity.NDOCUMENT,
        };
    }

    public static HIS_ASC_II ToEntity(this CreateHIS_ASC_IIDto dto)
    {
        if (dto == null) return null!;
        return new HIS_ASC_II
        {
            SBANK_ORI = dto.SBANK_ORI,
            NPERIOD_YEAR = dto.NPERIOD_YEAR,
            NPERIOD_MONTH = dto.NPERIOD_MONTH,
            NORDER = dto.NORDER,
            SUNIQ_CODE = dto.SUNIQ_CODE,
            NAMOUNT = dto.NAMOUNT,
            SCURRENCY = dto.SCURRENCY,
            SPAY_MET = dto.SPAY_MET,
            SCONCEPT = dto.SCONCEPT,
            SREFERENCE = dto.SREFERENCE,
            SDOC_TYPE = dto.SDOC_TYPE,
            SCLIENAME = dto.SCLIENAME,
            SPHON_BEN = dto.SPHON_BEN,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            SBANKEXT = dto.SBANKEXT,
            SSTATUS = dto.SSTATUS,
            SREASON = dto.SREASON,
            SDETAIL = dto.SDETAIL,
            NCHEQUE = dto.NCHEQUE,
            NORDER_ACH = dto.NORDER_ACH,
            DATE_UPLOAD = dto.DATE_UPLOAD,
            DATE_PAY = dto.DATE_PAY,
            NTRANSF = dto.NTRANSF,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATMOV = dto.SSTATMOV,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NREQUEST_NU = dto.NREQUEST_NU,
            SKEY = dto.SKEY,
            NDOCUMENT = dto.NDOCUMENT,
        };
    }

    public static void UpdateEntity(this HIS_ASC_II entity, UpdateHIS_ASC_IIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SBANK_ORI = dto.SBANK_ORI;
        entity.NPERIOD_YEAR = dto.NPERIOD_YEAR;
        entity.NPERIOD_MONTH = dto.NPERIOD_MONTH;
        entity.NORDER = dto.NORDER;
        entity.SUNIQ_CODE = dto.SUNIQ_CODE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCURRENCY = dto.SCURRENCY;
        entity.SPAY_MET = dto.SPAY_MET;
        entity.SCONCEPT = dto.SCONCEPT;
        entity.SREFERENCE = dto.SREFERENCE;
        entity.SDOC_TYPE = dto.SDOC_TYPE;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.SPHON_BEN = dto.SPHON_BEN;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.SBANKEXT = dto.SBANKEXT;
        entity.SSTATUS = dto.SSTATUS;
        entity.SREASON = dto.SREASON;
        entity.SDETAIL = dto.SDETAIL;
        entity.NCHEQUE = dto.NCHEQUE;
        entity.NORDER_ACH = dto.NORDER_ACH;
        entity.DATE_UPLOAD = dto.DATE_UPLOAD;
        entity.DATE_PAY = dto.DATE_PAY;
        entity.NTRANSF = dto.NTRANSF;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATMOV = dto.SSTATMOV;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.SKEY = dto.SKEY;
        entity.NDOCUMENT = dto.NDOCUMENT;
    }
}
