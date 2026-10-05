using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ASCII_I_HEADMappingExtensions
{
    public static ASCII_I_HEADDto ToDto(this ASCII_I_HEAD entity)
    {
        if (entity == null) return null!;
        return new ASCII_I_HEADDto
        {
            SASCII_NAME = entity.SASCII_NAME,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NCONCEPT = entity.NCONCEPT,
            TABLE293SDESCRIPT = entity.TABLE293?.SDESCRIPT,
            DSTAT_DATE = entity.DSTAT_DATE,
            SACC_NUMBER = entity.SACC_NUMBER,
            NAGENCY = entity.NAGENCY,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SSTATMOV = entity.SSTATMOV,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE193SDESCRIPT = entity.TABLE193?.SDESCRIPT,
        };
    }

    public static ASCII_I_HEAD ToEntity(this CreateASCII_I_HEADDto dto)
    {
        if (dto == null) return null!;
        return new ASCII_I_HEAD
        {
            NBANK_CODE = dto.NBANK_CODE,
            NCONCEPT = dto.NCONCEPT,
            DSTAT_DATE = dto.DSTAT_DATE,
            SACC_NUMBER = dto.SACC_NUMBER,
            NAGENCY = dto.NAGENCY,
            SSTATMOV = dto.SSTATMOV,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SPAY_FORM = dto.SPAY_FORM,
        };
    }

    public static void UpdateEntity(this ASCII_I_HEAD entity, UpdateASCII_I_HEADDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.SACC_NUMBER = dto.SACC_NUMBER;
        entity.NAGENCY = dto.NAGENCY;
        entity.SSTATMOV = dto.SSTATMOV;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPAY_FORM = dto.SPAY_FORM;
    }
}
