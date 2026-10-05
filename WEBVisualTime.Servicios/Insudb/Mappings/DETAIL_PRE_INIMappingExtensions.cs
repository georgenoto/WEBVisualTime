using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DETAIL_PRE_INI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DETAIL_PRE_INIMappingExtensions
{
    public static DETAIL_PRE_INIDto ToDto(this DETAIL_PRE_INI entity)
    {
        if (entity == null) return null!;
        return new DETAIL_PRE_INIDto
        {
            NPRODUCT = entity.NPRODUCT,
            NRECEIPT = entity.NRECEIPT,
            NBRANCH = entity.NBRANCH,
            SCERTYPE = entity.SCERTYPE,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
            NID_BILL = entity.NID_BILL,
            SADDSUINI = entity.SADDSUINI,
            STYPE_DETAI = entity.STYPE_DETAI,
            NDET_CODE = entity.NDET_CODE,
            DCOMPDATE = entity.DCOMPDATE,
            NCAPITAL = entity.NCAPITAL,
            NCOMMI_RATE = entity.NCOMMI_RATE,
            NCOMMISION = entity.NCOMMISION,
            NPREMIUM = entity.NPREMIUM,
            NTAX = entity.NTAX,
            NBILL_ITEM = entity.NBILL_ITEM,
            NBRANCH_EST = entity.NBRANCH_EST,
            NBRANCH_LED = entity.NBRANCH_LED,
            NBRANCH_REI = entity.NBRANCH_REI,
            NUSERCODE = entity.NUSERCODE,
            NPREMANUAL = entity.NPREMANUAL,
            SADDTAX = entity.SADDTAX,
            NCOMANUAL = entity.NCOMANUAL,
            NPREMIUMA = entity.NPREMIUMA,
            NPREMIUME = entity.NPREMIUME,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            NRECAMOUNT = entity.NRECAMOUNT,
            NDESCAMOUNT = entity.NDESCAMOUNT,
            NREL_IDBILL = entity.NREL_IDBILL,
            SCLIENT = entity.SCLIENT,
            NREL_IDCODE = entity.NREL_IDCODE,
            NSTIPEND_AMOUNT = entity.NSTIPEND_AMOUNT,
            NSTIPEND_ANNUAL = entity.NSTIPEND_ANNUAL,
            NTAXRATE = entity.NTAXRATE,
            NDISSUR_TYPE = entity.NDISSUR_TYPE,
            NCOM_SUPER = entity.NCOM_SUPER,
            NCOMANUAL_SUPER = entity.NCOMANUAL_SUPER,
        };
    }

    public static DETAIL_PRE_INI ToEntity(this CreateDETAIL_PRE_INIDto dto)
    {
        if (dto == null) return null!;
        return new DETAIL_PRE_INI
        {
            SADDSUINI = dto.SADDSUINI,
            STYPE_DETAI = dto.STYPE_DETAI,
            NDET_CODE = dto.NDET_CODE,
            DCOMPDATE = dto.DCOMPDATE,
            NCAPITAL = dto.NCAPITAL,
            NCOMMI_RATE = dto.NCOMMI_RATE,
            NCOMMISION = dto.NCOMMISION,
            NPREMIUM = dto.NPREMIUM,
            NTAX = dto.NTAX,
            NBILL_ITEM = dto.NBILL_ITEM,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_REI = dto.NBRANCH_REI,
            NUSERCODE = dto.NUSERCODE,
            NPREMANUAL = dto.NPREMANUAL,
            SADDTAX = dto.SADDTAX,
            NCOMANUAL = dto.NCOMANUAL,
            NPREMIUMA = dto.NPREMIUMA,
            NPREMIUME = dto.NPREMIUME,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            NRECAMOUNT = dto.NRECAMOUNT,
            NDESCAMOUNT = dto.NDESCAMOUNT,
            NREL_IDBILL = dto.NREL_IDBILL,
            SCLIENT = dto.SCLIENT,
            NREL_IDCODE = dto.NREL_IDCODE,
            NSTIPEND_AMOUNT = dto.NSTIPEND_AMOUNT,
            NSTIPEND_ANNUAL = dto.NSTIPEND_ANNUAL,
            NTAXRATE = dto.NTAXRATE,
            NDISSUR_TYPE = dto.NDISSUR_TYPE,
            NCOM_SUPER = dto.NCOM_SUPER,
            NCOMANUAL_SUPER = dto.NCOMANUAL_SUPER,
        };
    }

    public static void UpdateEntity(this DETAIL_PRE_INI entity, UpdateDETAIL_PRE_INIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SADDSUINI = dto.SADDSUINI;
        entity.STYPE_DETAI = dto.STYPE_DETAI;
        entity.NDET_CODE = dto.NDET_CODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMI_RATE = dto.NCOMMI_RATE;
        entity.NCOMMISION = dto.NCOMMISION;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NTAX = dto.NTAX;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPREMANUAL = dto.NPREMANUAL;
        entity.SADDTAX = dto.SADDTAX;
        entity.NCOMANUAL = dto.NCOMANUAL;
        entity.NPREMIUMA = dto.NPREMIUMA;
        entity.NPREMIUME = dto.NPREMIUME;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.NRECAMOUNT = dto.NRECAMOUNT;
        entity.NDESCAMOUNT = dto.NDESCAMOUNT;
        entity.NREL_IDBILL = dto.NREL_IDBILL;
        entity.SCLIENT = dto.SCLIENT;
        entity.NREL_IDCODE = dto.NREL_IDCODE;
        entity.NSTIPEND_AMOUNT = dto.NSTIPEND_AMOUNT;
        entity.NSTIPEND_ANNUAL = dto.NSTIPEND_ANNUAL;
        entity.NTAXRATE = dto.NTAXRATE;
        entity.NDISSUR_TYPE = dto.NDISSUR_TYPE;
        entity.NCOM_SUPER = dto.NCOM_SUPER;
        entity.NCOMANUAL_SUPER = dto.NCOMANUAL_SUPER;
    }
}
