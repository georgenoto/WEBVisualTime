using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class H_ASSIGNMENT_PARTMappingExtensions
{
    public static H_ASSIGNMENT_PARTDto ToDto(this H_ASSIGNMENT_PART entity)
    {
        if (entity == null) return null!;
        return new H_ASSIGNMENT_PARTDto
        {
            NID_NUMREG = entity.NID_NUMREG,
            NINSUR_AREA = entity.NINSUR_AREA,
            NINTERTYP = entity.NINTERTYP,
            NTYPE_ASSIGN = entity.NTYPE_ASSIGN,
            DATE_ASSIG_INI = entity.DATE_ASSIG_INI,
            DATE_ASSIG_END = entity.DATE_ASSIG_END,
            NINTERMED = entity.NINTERMED,
            NTEMPASSI = entity.NTEMPASSI,
            STEMPASSI = entity.STEMPASSI,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static H_ASSIGNMENT_PART ToEntity(this CreateH_ASSIGNMENT_PARTDto dto)
    {
        if (dto == null) return null!;
        return new H_ASSIGNMENT_PART
        {
            NINSUR_AREA = dto.NINSUR_AREA,
            NINTERTYP = dto.NINTERTYP,
            NTYPE_ASSIGN = dto.NTYPE_ASSIGN,
            DATE_ASSIG_INI = dto.DATE_ASSIG_INI,
            DATE_ASSIG_END = dto.DATE_ASSIG_END,
            NINTERMED = dto.NINTERMED,
            NTEMPASSI = dto.NTEMPASSI,
            STEMPASSI = dto.STEMPASSI,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this H_ASSIGNMENT_PART entity, UpdateH_ASSIGNMENT_PARTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NINTERTYP = dto.NINTERTYP;
        entity.NTYPE_ASSIGN = dto.NTYPE_ASSIGN;
        entity.DATE_ASSIG_INI = dto.DATE_ASSIG_INI;
        entity.DATE_ASSIG_END = dto.DATE_ASSIG_END;
        entity.NINTERMED = dto.NINTERMED;
        entity.NTEMPASSI = dto.NTEMPASSI;
        entity.STEMPASSI = dto.STEMPASSI;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
