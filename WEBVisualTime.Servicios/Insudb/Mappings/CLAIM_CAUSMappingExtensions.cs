using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CAUS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_CAUSMappingExtensions
{
    public static CLAIM_CAUSDto ToDto(this CLAIM_CAUS entity)
    {
        if (entity == null) return null!;
        return new CLAIM_CAUSDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NCAUSECOD = entity.NCAUSECOD,
            NPRODUCT = entity.NPRODUCT,
            DCOMPDATE = entity.DCOMPDATE,
            SCLAIMTYP = entity.SCLAIMTYP,
            TABLE132SDESCRIPT = entity.TABLE132?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SROUTINE = entity.SROUTINE,
        };
    }

    public static CLAIM_CAUS ToEntity(this CreateCLAIM_CAUSDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_CAUS
        {
            DCOMPDATE = dto.DCOMPDATE,
            SCLAIMTYP = dto.SCLAIMTYP,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SROUTINE = dto.SROUTINE,
        };
    }

    public static void UpdateEntity(this CLAIM_CAUS entity, UpdateCLAIM_CAUSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCLAIMTYP = dto.SCLAIMTYP;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SROUTINE = dto.SROUTINE;
    }
}
