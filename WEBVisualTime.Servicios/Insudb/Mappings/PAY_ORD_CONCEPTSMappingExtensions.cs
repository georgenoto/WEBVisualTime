using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_ORD_CONCEPTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PAY_ORD_CONCEPTSMappingExtensions
{
    public static PAY_ORD_CONCEPTSDto ToDto(this PAY_ORD_CONCEPTS entity)
    {
        if (entity == null) return null!;
        return new PAY_ORD_CONCEPTSDto
        {
            NCOMPANY = entity.NCOMPANY,
            NCONCEPT = entity.NCONCEPT,
            TABLE293SDESCRIPT = entity.TABLE293?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PAY_ORD_CONCEPTS ToEntity(this CreatePAY_ORD_CONCEPTSDto dto)
    {
        if (dto == null) return null!;
        return new PAY_ORD_CONCEPTS
        {
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PAY_ORD_CONCEPTS entity, UpdatePAY_ORD_CONCEPTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
