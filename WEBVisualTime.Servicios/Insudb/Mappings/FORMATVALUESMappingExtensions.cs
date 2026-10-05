using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FORMATVALUESMappingExtensions
{
    public static FORMATVALUESDto ToDto(this FORMATVALUES entity)
    {
        if (entity == null) return null!;
        return new FORMATVALUESDto
        {
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NCLASSTYPDOC = entity.NCLASSTYPDOC,
            TABLE6023SDESCRIPT = entity.TABLE6023?.SDESCRIPT,
            SFORMAT = entity.SFORMAT,
            STYPPERSON = entity.STYPPERSON,
            SROUTINE = entity.SROUTINE,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static FORMATVALUES ToEntity(this CreateFORMATVALUESDto dto)
    {
        if (dto == null) return null!;
        return new FORMATVALUES
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SFORMAT = dto.SFORMAT,
            STYPPERSON = dto.STYPPERSON,
            SROUTINE = dto.SROUTINE,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this FORMATVALUES entity, UpdateFORMATVALUESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SFORMAT = dto.SFORMAT;
        entity.STYPPERSON = dto.STYPPERSON;
        entity.SROUTINE = dto.SROUTINE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
