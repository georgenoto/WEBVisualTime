using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCLASS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CASH_CONCLASSMappingExtensions
{
    public static CASH_CONCLASSDto ToDto(this CASH_CONCLASS entity)
    {
        if (entity == null) return null!;
        return new CASH_CONCLASSDto
        {
            NCLASS_CONCEPT = entity.NCLASS_CONCEPT,
            TABLE5650SDESCRIPT = entity.TABLE5650?.SDESCRIPT,
            NCONCEPT = entity.NCONCEPT,
            TABLE22SDESCRIPT = entity.TABLE22?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static CASH_CONCLASS ToEntity(this CreateCASH_CONCLASSDto dto)
    {
        if (dto == null) return null!;
        return new CASH_CONCLASS
        {
            NCLASS_CONCEPT = dto.NCLASS_CONCEPT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this CASH_CONCLASS entity, UpdateCASH_CONCLASSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCLASS_CONCEPT = dto.NCLASS_CONCEPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
