using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_LIFCOVMappingExtensions
{
    public static TAB_LIFCOVDto ToDto(this TAB_LIFCOV entity)
    {
        if (entity == null) return null!;
        return new TAB_LIFCOVDto
        {
            NCOVERGEN = entity.NCOVERGEN,
            NAGEMAXI = entity.NAGEMAXI,
            NBRANCH_EST = entity.NBRANCH_EST,
            TABLE71SDESCRIPT = entity.TABLE71?.SDESCRIPT,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NBRANCH_GEN = entity.NBRANCH_GEN,
            TABLE634SDESCRIPT = entity.TABLE634?.SDESCRIPT,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NCACALFIX = entity.NCACALFIX,
            SCACALFRI = entity.SCACALFRI,
            SCAPIPREM = entity.SCAPIPREM,
            SCLACCIDI = entity.SCLACCIDI,
            SCLDEATHI = entity.SCLDEATHI,
            SCLINCAPI = entity.SCLINCAPI,
            SCLINVALI = entity.SCLINVALI,
            SCLSURVII = entity.SCLSURVII,
            SCLVEHACI = entity.SCLVEHACI,
            DCOMPDATE = entity.DCOMPDATE,
            SCOVERUSE = entity.SCOVERUSE,
            NCURRENCY = entity.NCURRENCY,
            SDESCRIPT = entity.SDESCRIPT,
            SIDURAAGE = entity.SIDURAAGE,
            SIDURAYEAR = entity.SIDURAYEAR,
            SIDUROPEI = entity.SIDUROPEI,
            SINSURINI = entity.SINSURINI,
            NCOVER_IN = entity.NCOVER_IN,
            NPREMIRAT = entity.NPREMIRAT,
            SPDURAAGE = entity.SPDURAAGE,
            NDURATIND = entity.NDURATIND,
            NDURATPAY = entity.NDURATPAY,
            SREVINDEX = entity.SREVINDEX,
            SPDUROPEI = entity.SPDUROPEI,
            SPDURYEAR = entity.SPDURYEAR,
            SPREMCAPI = entity.SPREMCAPI,
            SRECHAPRI = entity.SRECHAPRI,
            SRENEWALI = entity.SRENEWALI,
            SROUCHACA = entity.SROUCHACA,
            SROUCHAPR = entity.SROUCHAPR,
            SROUPRCAL = entity.SROUPRCAL,
            SROURESER = entity.SROURESER,
            SROUSURRE = entity.SROUSURRE,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SCLILLNESS = entity.SCLILLNESS,
            SCONDSVS = entity.SCONDSVS,
            SINFORPROV = entity.SINFORPROV,
            SPROVIDER = entity.SPROVIDER,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCLA_LI_TYP = entity.NCLA_LI_TYP,
            TABLE210SDESCRIPT = entity.TABLE210?.SDESCRIPT,
            SDESCOVER = entity.SDESCOVER,
            STAXHEREDITY = entity.STAXHEREDITY,
            DSTARTDATE = entity.DSTARTDATE,
            DOCCURDAT = entity.DOCCURDAT,
        };
    }

    public static TAB_LIFCOV ToEntity(this CreateTAB_LIFCOVDto dto)
    {
        if (dto == null) return null!;
        return new TAB_LIFCOV
        {
            NAGEMAXI = dto.NAGEMAXI,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_GEN = dto.NBRANCH_GEN,
            NBRANCH_REI = dto.NBRANCH_REI,
            NCACALFIX = dto.NCACALFIX,
            SCACALFRI = dto.SCACALFRI,
            SCAPIPREM = dto.SCAPIPREM,
            SCLACCIDI = dto.SCLACCIDI,
            SCLDEATHI = dto.SCLDEATHI,
            SCLINCAPI = dto.SCLINCAPI,
            SCLINVALI = dto.SCLINVALI,
            SCLSURVII = dto.SCLSURVII,
            SCLVEHACI = dto.SCLVEHACI,
            DCOMPDATE = dto.DCOMPDATE,
            SCOVERUSE = dto.SCOVERUSE,
            NCURRENCY = dto.NCURRENCY,
            SDESCRIPT = dto.SDESCRIPT,
            SIDURAAGE = dto.SIDURAAGE,
            SIDURAYEAR = dto.SIDURAYEAR,
            SIDUROPEI = dto.SIDUROPEI,
            SINSURINI = dto.SINSURINI,
            NCOVER_IN = dto.NCOVER_IN,
            NPREMIRAT = dto.NPREMIRAT,
            SPDURAAGE = dto.SPDURAAGE,
            NDURATIND = dto.NDURATIND,
            NDURATPAY = dto.NDURATPAY,
            SREVINDEX = dto.SREVINDEX,
            SPDUROPEI = dto.SPDUROPEI,
            SPDURYEAR = dto.SPDURYEAR,
            SPREMCAPI = dto.SPREMCAPI,
            SRECHAPRI = dto.SRECHAPRI,
            SRENEWALI = dto.SRENEWALI,
            SROUCHACA = dto.SROUCHACA,
            SROUCHAPR = dto.SROUCHAPR,
            SROUPRCAL = dto.SROUPRCAL,
            SROURESER = dto.SROURESER,
            SROUSURRE = dto.SROUSURRE,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SCLILLNESS = dto.SCLILLNESS,
            SCONDSVS = dto.SCONDSVS,
            SINFORPROV = dto.SINFORPROV,
            SPROVIDER = dto.SPROVIDER,
            NCLA_LI_TYP = dto.NCLA_LI_TYP,
            SDESCOVER = dto.SDESCOVER,
            STAXHEREDITY = dto.STAXHEREDITY,
            DSTARTDATE = dto.DSTARTDATE,
            DOCCURDAT = dto.DOCCURDAT,
        };
    }

    public static void UpdateEntity(this TAB_LIFCOV entity, UpdateTAB_LIFCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAGEMAXI = dto.NAGEMAXI;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_GEN = dto.NBRANCH_GEN;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NCACALFIX = dto.NCACALFIX;
        entity.SCACALFRI = dto.SCACALFRI;
        entity.SCAPIPREM = dto.SCAPIPREM;
        entity.SCLACCIDI = dto.SCLACCIDI;
        entity.SCLDEATHI = dto.SCLDEATHI;
        entity.SCLINCAPI = dto.SCLINCAPI;
        entity.SCLINVALI = dto.SCLINVALI;
        entity.SCLSURVII = dto.SCLSURVII;
        entity.SCLVEHACI = dto.SCLVEHACI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCOVERUSE = dto.SCOVERUSE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SIDURAAGE = dto.SIDURAAGE;
        entity.SIDURAYEAR = dto.SIDURAYEAR;
        entity.SIDUROPEI = dto.SIDUROPEI;
        entity.SINSURINI = dto.SINSURINI;
        entity.NCOVER_IN = dto.NCOVER_IN;
        entity.NPREMIRAT = dto.NPREMIRAT;
        entity.SPDURAAGE = dto.SPDURAAGE;
        entity.NDURATIND = dto.NDURATIND;
        entity.NDURATPAY = dto.NDURATPAY;
        entity.SREVINDEX = dto.SREVINDEX;
        entity.SPDUROPEI = dto.SPDUROPEI;
        entity.SPDURYEAR = dto.SPDURYEAR;
        entity.SPREMCAPI = dto.SPREMCAPI;
        entity.SRECHAPRI = dto.SRECHAPRI;
        entity.SRENEWALI = dto.SRENEWALI;
        entity.SROUCHACA = dto.SROUCHACA;
        entity.SROUCHAPR = dto.SROUCHAPR;
        entity.SROUPRCAL = dto.SROUPRCAL;
        entity.SROURESER = dto.SROURESER;
        entity.SROUSURRE = dto.SROUSURRE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCLILLNESS = dto.SCLILLNESS;
        entity.SCONDSVS = dto.SCONDSVS;
        entity.SINFORPROV = dto.SINFORPROV;
        entity.SPROVIDER = dto.SPROVIDER;
        entity.NCLA_LI_TYP = dto.NCLA_LI_TYP;
        entity.SDESCOVER = dto.SDESCOVER;
        entity.STAXHEREDITY = dto.STAXHEREDITY;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DOCCURDAT = dto.DOCCURDAT;
    }
}
