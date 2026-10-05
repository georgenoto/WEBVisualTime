using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TDETAIL_PRE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TDETAIL_PREMappingExtensions
{
    public static TDETAIL_PREDto ToDto(this TDETAIL_PRE entity)
    {
        if (entity == null) return null!;
        return new TDETAIL_PREDto
        {
            SKEY = entity.SKEY,
            NCURRENCY = entity.NCURRENCY,
            NBILL_ITEM = entity.NBILL_ITEM,
            NBRANCH_EST = entity.NBRANCH_EST,
            NBRANCH_LED = entity.NBRANCH_LED,
            NBRANCH_REI = entity.NBRANCH_REI,
            SADDSUINI = entity.SADDSUINI,
            NMODULEC = entity.NMODULEC,
            NCODE = entity.NCODE,
            NCOMMI_RATE = entity.NCOMMI_RATE,
            NCOMMISION = entity.NCOMMISION,
            NTAX = entity.NTAX,
            NCAPI_INI = entity.NCAPI_INI,
            NCAPITAL = entity.NCAPITAL,
            NPREMIUM = entity.NPREMIUM,
            NPREMIUM_AN = entity.NPREMIUM_AN,
            STYPE_DETAI = entity.STYPE_DETAI,
            NP_NOTCONS = entity.NP_NOTCONS,
            NP_OUTSTAND = entity.NP_OUTSTAND,
            NP_ADJUST = entity.NP_ADJUST,
            NPREM_INI = entity.NPREM_INI,
            NPREM_ACT = entity.NPREM_ACT,
            NCOMMI_ANU = entity.NCOMMI_ANU,
            SADDTAX = entity.SADDTAX,
            NID_BILL = entity.NID_BILL,
            NREL_IDBILL = entity.NREL_IDBILL,
            SCLIENT = entity.SCLIENT,
            NROLE = entity.NROLE,
            NTAXIVA = entity.NTAXIVA,
            NINSURED = entity.NINSURED,
            NGROUP = entity.NGROUP,
            NINSUCOUNT = entity.NINSUCOUNT,
            NTAXMAR = entity.NTAXMAR,
            NAMOUNTIVA = entity.NAMOUNTIVA,
            NTAXTARIF = entity.NTAXTARIF,
            NPREMIUMA = entity.NPREMIUMA,
            NPREMIUME = entity.NPREMIUME,
            SSHORT_DES = entity.SSHORT_DES,
            SCACALILI = entity.SCACALILI,
            SCOMMISSI_I = entity.SCOMMISSI_I,
            SADDTAXIN = entity.SADDTAXIN,
            NTYPDURINS = entity.NTYPDURINS,
            NTYPDURPAY = entity.NTYPDURPAY,
            NCOM_NOTCONS = entity.NCOM_NOTCONS,
            NCOM_OUTSTAND = entity.NCOM_OUTSTAND,
            NPREM_DET = entity.NPREM_DET,
            SPREM_DET = entity.SPREM_DET,
            NREL_IDCODE = entity.NREL_IDCODE,
            NTAXRATE = entity.NTAXRATE,
            NDISSUR_TYPE = entity.NDISSUR_TYPE,
            TABLE9207SDESCRIPT = entity.TABLE9207?.SDESCRIPT,
            NCOM_SUPER = entity.NCOM_SUPER,
            NCOMANUAL_SUPER = entity.NCOMANUAL_SUPER,
            NCOMSUP_RATE = entity.NCOMSUP_RATE,
        };
    }

    public static TDETAIL_PRE ToEntity(this CreateTDETAIL_PREDto dto)
    {
        if (dto == null) return null!;
        return new TDETAIL_PRE
        {
            SKEY = dto.SKEY,
            NCURRENCY = dto.NCURRENCY,
            NBILL_ITEM = dto.NBILL_ITEM,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_REI = dto.NBRANCH_REI,
            SADDSUINI = dto.SADDSUINI,
            NMODULEC = dto.NMODULEC,
            NCODE = dto.NCODE,
            NCOMMI_RATE = dto.NCOMMI_RATE,
            NCOMMISION = dto.NCOMMISION,
            NTAX = dto.NTAX,
            NCAPI_INI = dto.NCAPI_INI,
            NCAPITAL = dto.NCAPITAL,
            NPREMIUM = dto.NPREMIUM,
            NPREMIUM_AN = dto.NPREMIUM_AN,
            STYPE_DETAI = dto.STYPE_DETAI,
            NP_NOTCONS = dto.NP_NOTCONS,
            NP_OUTSTAND = dto.NP_OUTSTAND,
            NP_ADJUST = dto.NP_ADJUST,
            NPREM_INI = dto.NPREM_INI,
            NPREM_ACT = dto.NPREM_ACT,
            NCOMMI_ANU = dto.NCOMMI_ANU,
            SADDTAX = dto.SADDTAX,
            NID_BILL = dto.NID_BILL,
            NREL_IDBILL = dto.NREL_IDBILL,
            SCLIENT = dto.SCLIENT,
            NROLE = dto.NROLE,
            NTAXIVA = dto.NTAXIVA,
            NINSURED = dto.NINSURED,
            NGROUP = dto.NGROUP,
            NINSUCOUNT = dto.NINSUCOUNT,
            NTAXMAR = dto.NTAXMAR,
            NAMOUNTIVA = dto.NAMOUNTIVA,
            NTAXTARIF = dto.NTAXTARIF,
            NPREMIUMA = dto.NPREMIUMA,
            NPREMIUME = dto.NPREMIUME,
            SSHORT_DES = dto.SSHORT_DES,
            SCACALILI = dto.SCACALILI,
            SCOMMISSI_I = dto.SCOMMISSI_I,
            SADDTAXIN = dto.SADDTAXIN,
            NTYPDURINS = dto.NTYPDURINS,
            NTYPDURPAY = dto.NTYPDURPAY,
            NCOM_NOTCONS = dto.NCOM_NOTCONS,
            NCOM_OUTSTAND = dto.NCOM_OUTSTAND,
            NPREM_DET = dto.NPREM_DET,
            SPREM_DET = dto.SPREM_DET,
            NREL_IDCODE = dto.NREL_IDCODE,
            NTAXRATE = dto.NTAXRATE,
            NDISSUR_TYPE = dto.NDISSUR_TYPE,
            NCOM_SUPER = dto.NCOM_SUPER,
            NCOMANUAL_SUPER = dto.NCOMANUAL_SUPER,
            NCOMSUP_RATE = dto.NCOMSUP_RATE,
        };
    }

    public static void UpdateEntity(this TDETAIL_PRE entity, UpdateTDETAIL_PREDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.SADDSUINI = dto.SADDSUINI;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCODE = dto.NCODE;
        entity.NCOMMI_RATE = dto.NCOMMI_RATE;
        entity.NCOMMISION = dto.NCOMMISION;
        entity.NTAX = dto.NTAX;
        entity.NCAPI_INI = dto.NCAPI_INI;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPREMIUM_AN = dto.NPREMIUM_AN;
        entity.STYPE_DETAI = dto.STYPE_DETAI;
        entity.NP_NOTCONS = dto.NP_NOTCONS;
        entity.NP_OUTSTAND = dto.NP_OUTSTAND;
        entity.NP_ADJUST = dto.NP_ADJUST;
        entity.NPREM_INI = dto.NPREM_INI;
        entity.NPREM_ACT = dto.NPREM_ACT;
        entity.NCOMMI_ANU = dto.NCOMMI_ANU;
        entity.SADDTAX = dto.SADDTAX;
        entity.NID_BILL = dto.NID_BILL;
        entity.NREL_IDBILL = dto.NREL_IDBILL;
        entity.SCLIENT = dto.SCLIENT;
        entity.NROLE = dto.NROLE;
        entity.NTAXIVA = dto.NTAXIVA;
        entity.NINSURED = dto.NINSURED;
        entity.NGROUP = dto.NGROUP;
        entity.NINSUCOUNT = dto.NINSUCOUNT;
        entity.NTAXMAR = dto.NTAXMAR;
        entity.NAMOUNTIVA = dto.NAMOUNTIVA;
        entity.NTAXTARIF = dto.NTAXTARIF;
        entity.NPREMIUMA = dto.NPREMIUMA;
        entity.NPREMIUME = dto.NPREMIUME;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SCACALILI = dto.SCACALILI;
        entity.SCOMMISSI_I = dto.SCOMMISSI_I;
        entity.SADDTAXIN = dto.SADDTAXIN;
        entity.NTYPDURINS = dto.NTYPDURINS;
        entity.NTYPDURPAY = dto.NTYPDURPAY;
        entity.NCOM_NOTCONS = dto.NCOM_NOTCONS;
        entity.NCOM_OUTSTAND = dto.NCOM_OUTSTAND;
        entity.NPREM_DET = dto.NPREM_DET;
        entity.SPREM_DET = dto.SPREM_DET;
        entity.NREL_IDCODE = dto.NREL_IDCODE;
        entity.NTAXRATE = dto.NTAXRATE;
        entity.NDISSUR_TYPE = dto.NDISSUR_TYPE;
        entity.NCOM_SUPER = dto.NCOM_SUPER;
        entity.NCOMANUAL_SUPER = dto.NCOMANUAL_SUPER;
        entity.NCOMSUP_RATE = dto.NCOMSUP_RATE;
    }
}
