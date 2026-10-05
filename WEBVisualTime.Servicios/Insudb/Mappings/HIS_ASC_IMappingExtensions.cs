using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_I;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HIS_ASC_IMappingExtensions
{
    public static HIS_ASC_IDto ToDto(this HIS_ASC_I entity)
    {
        if (entity == null) return null!;
        return new HIS_ASC_IDto
        {
            NID = entity.NID,
            SASCII_NAME = entity.SASCII_NAME,
            ASCII_I_HEADSACC_NUMBER = entity.ASCII_I_HEAD?.SACC_NUMBER,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE182SDESCRIPT = entity.TABLE182?.SDESCRIPT,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7NBANK_CODESDESCRIPT = entity.TABLE7NBANK_CODE?.SDESCRIPT,
            NCONCEPT = entity.NCONCEPT,
            TABLE293SDESCRIPT = entity.TABLE293?.SDESCRIPT,
            DSTAT_DATE = entity.DSTAT_DATE,
            SACC_NUMBER = entity.SACC_NUMBER,
            NAGENCY = entity.NAGENCY,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            SACCOUNTHOLDER = entity.SACCOUNTHOLDER,
            NREQUEST_NU = entity.NREQUEST_NU,
            NAMOUNT = entity.NAMOUNT,
            SDESCRIPT = entity.SDESCRIPT,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            NBANKEXT = entity.NBANKEXT,
            TABLE7NBANKEXTSDESCRIPT = entity.TABLE7NBANKEXT?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static HIS_ASC_I ToEntity(this CreateHIS_ASC_IDto dto)
    {
        if (dto == null) return null!;
        return new HIS_ASC_I
        {
            SASCII_NAME = dto.SASCII_NAME,
            SPAY_FORM = dto.SPAY_FORM,
            NBANK_CODE = dto.NBANK_CODE,
            NCONCEPT = dto.NCONCEPT,
            DSTAT_DATE = dto.DSTAT_DATE,
            SACC_NUMBER = dto.SACC_NUMBER,
            NAGENCY = dto.NAGENCY,
            SCLIENT = dto.SCLIENT,
            SACCOUNTHOLDER = dto.SACCOUNTHOLDER,
            NREQUEST_NU = dto.NREQUEST_NU,
            NAMOUNT = dto.NAMOUNT,
            SDESCRIPT = dto.SDESCRIPT,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            NBANKEXT = dto.NBANKEXT,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this HIS_ASC_I entity, UpdateHIS_ASC_IDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SASCII_NAME = dto.SASCII_NAME;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.SACC_NUMBER = dto.SACC_NUMBER;
        entity.NAGENCY = dto.NAGENCY;
        entity.SCLIENT = dto.SCLIENT;
        entity.SACCOUNTHOLDER = dto.SACCOUNTHOLDER;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
