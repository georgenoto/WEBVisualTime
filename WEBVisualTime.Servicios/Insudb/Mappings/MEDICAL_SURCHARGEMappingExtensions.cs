using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MEDICAL_SURCHARGEMappingExtensions
{
    public static MEDICAL_SURCHARGEDto ToDto(this MEDICAL_SURCHARGE entity)
    {
        if (entity == null) return null!;
        return new MEDICAL_SURCHARGEDto
        {
            NSURCHAR_MED = entity.NSURCHAR_MED,
            NPERC_SURCHAR = entity.NPERC_SURCHAR,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MEDICAL_SURCHARGE ToEntity(this CreateMEDICAL_SURCHARGEDto dto)
    {
        if (dto == null) return null!;
        return new MEDICAL_SURCHARGE
        {
            NPERC_SURCHAR = dto.NPERC_SURCHAR,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MEDICAL_SURCHARGE entity, UpdateMEDICAL_SURCHARGEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPERC_SURCHAR = dto.NPERC_SURCHAR;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
