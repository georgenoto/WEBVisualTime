using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_PREMIU_INI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class OUT_PREMIU_INIMappingExtensions
{
    public static OUT_PREMIU_INIDto ToDto(this OUT_PREMIU_INI entity)
    {
        if (entity == null) return null!;
        return new OUT_PREMIU_INIDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NMOVNUMBE = entity.NMOVNUMBE,
            NDIGIT = entity.NDIGIT,
            NID_BILL = entity.NID_BILL,
            SADDSUINI = entity.SADDSUINI,
            STYPE_DETAI = entity.STYPE_DETAI,
            NBILL_ITEM = entity.NBILL_ITEM,
            NCODE_DETAI = entity.NCODE_DETAI,
            NBRANCH_EST = entity.NBRANCH_EST,
            NBRANCH_LED = entity.NBRANCH_LED,
            NBRANCH_REI = entity.NBRANCH_REI,
            NCAPITAL = entity.NCAPITAL,
            NCOMMI_RATE = entity.NCOMMI_RATE,
            NCOMMISION = entity.NCOMMISION,
            DCOMPDATE = entity.DCOMPDATE,
            NPREMIUM = entity.NPREMIUM,
            NTAX = entity.NTAX,
            NUSERCODE = entity.NUSERCODE,
            NPROVINCIE = entity.NPROVINCIE,
            NPREM_ANU = entity.NPREM_ANU,
            NCOM_ANU = entity.NCOM_ANU,
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
            NDISSUR_TYPE = entity.NDISSUR_TYPE,
        };
    }

    public static OUT_PREMIU_INI ToEntity(this CreateOUT_PREMIU_INIDto dto)
    {
        if (dto == null) return null!;
        return new OUT_PREMIU_INI
        {
            SADDSUINI = dto.SADDSUINI,
            STYPE_DETAI = dto.STYPE_DETAI,
            NBILL_ITEM = dto.NBILL_ITEM,
            NCODE_DETAI = dto.NCODE_DETAI,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_REI = dto.NBRANCH_REI,
            NCAPITAL = dto.NCAPITAL,
            NCOMMI_RATE = dto.NCOMMI_RATE,
            NCOMMISION = dto.NCOMMISION,
            DCOMPDATE = dto.DCOMPDATE,
            NPREMIUM = dto.NPREMIUM,
            NTAX = dto.NTAX,
            NUSERCODE = dto.NUSERCODE,
            NPROVINCIE = dto.NPROVINCIE,
            NPREM_ANU = dto.NPREM_ANU,
            NCOM_ANU = dto.NCOM_ANU,
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
            NDISSUR_TYPE = dto.NDISSUR_TYPE,
        };
    }

    public static void UpdateEntity(this OUT_PREMIU_INI entity, UpdateOUT_PREMIU_INIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SADDSUINI = dto.SADDSUINI;
        entity.STYPE_DETAI = dto.STYPE_DETAI;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.NCODE_DETAI = dto.NCODE_DETAI;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMI_RATE = dto.NCOMMI_RATE;
        entity.NCOMMISION = dto.NCOMMISION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NTAX = dto.NTAX;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPROVINCIE = dto.NPROVINCIE;
        entity.NPREM_ANU = dto.NPREM_ANU;
        entity.NCOM_ANU = dto.NCOM_ANU;
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
        entity.NDISSUR_TYPE = dto.NDISSUR_TYPE;
    }
}
