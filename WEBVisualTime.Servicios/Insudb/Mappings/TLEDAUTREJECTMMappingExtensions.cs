using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TLEDAUTREJECTM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TLEDAUTREJECTMMappingExtensions
{
    public static TLEDAUTREJECTMDto ToDto(this TLEDAUTREJECTM entity)
    {
        if (entity == null) return null!;
        return new TLEDAUTREJECTMDto
        {
            NAREA_LED = entity.NAREA_LED,
            NID = entity.NID,
            NGROUP = entity.NGROUP,
            NFAILNUM = entity.NFAILNUM,
            DLEDGERDAT = entity.DLEDGERDAT,
            NAMOUNT = entity.NAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            DPOSTED = entity.DPOSTED,
            SERRDETAIL = entity.SERRDETAIL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NRECEIPT = entity.NRECEIPT,
            NACC_CASH = entity.NACC_CASH,
            NOFFICE = entity.NOFFICE,
            NTRANSAC = entity.NTRANSAC,
            NCASHNUM = entity.NCASHNUM,
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            NTYP_ACCO = entity.NTYP_ACCO,
            STYPE_ACC = entity.STYPE_ACC,
            SCLIENT = entity.SCLIENT,
            NREQUEST_NU = entity.NREQUEST_NU,
            SCHEQUE = entity.SCHEQUE,
            SCOLUMN = entity.SCOLUMN,
            NPARAMETER = entity.NPARAMETER,
            NTRANSAC_TY = entity.NTRANSAC_TY,
        };
    }

    public static TLEDAUTREJECTM ToEntity(this CreateTLEDAUTREJECTMDto dto)
    {
        if (dto == null) return null!;
        return new TLEDAUTREJECTM
        {
            NGROUP = dto.NGROUP,
            NFAILNUM = dto.NFAILNUM,
            DLEDGERDAT = dto.DLEDGERDAT,
            NAMOUNT = dto.NAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            DPOSTED = dto.DPOSTED,
            SERRDETAIL = dto.SERRDETAIL,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NRECEIPT = dto.NRECEIPT,
            NACC_CASH = dto.NACC_CASH,
            NOFFICE = dto.NOFFICE,
            NTRANSAC = dto.NTRANSAC,
            NCASHNUM = dto.NCASHNUM,
            NCLAIM = dto.NCLAIM,
            NCASE_NUM = dto.NCASE_NUM,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            NTYP_ACCO = dto.NTYP_ACCO,
            STYPE_ACC = dto.STYPE_ACC,
            SCLIENT = dto.SCLIENT,
            NREQUEST_NU = dto.NREQUEST_NU,
            SCHEQUE = dto.SCHEQUE,
            SCOLUMN = dto.SCOLUMN,
            NPARAMETER = dto.NPARAMETER,
            NTRANSAC_TY = dto.NTRANSAC_TY,
        };
    }

    public static void UpdateEntity(this TLEDAUTREJECTM entity, UpdateTLEDAUTREJECTMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NGROUP = dto.NGROUP;
        entity.NFAILNUM = dto.NFAILNUM;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DPOSTED = dto.DPOSTED;
        entity.SERRDETAIL = dto.SERRDETAIL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NACC_CASH = dto.NACC_CASH;
        entity.NOFFICE = dto.NOFFICE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.SCLIENT = dto.SCLIENT;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.SCHEQUE = dto.SCHEQUE;
        entity.SCOLUMN = dto.SCOLUMN;
        entity.NPARAMETER = dto.NPARAMETER;
        entity.NTRANSAC_TY = dto.NTRANSAC_TY;
    }
}
