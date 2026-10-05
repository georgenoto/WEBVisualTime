using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCEPTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CASH_CONCEPTSMappingExtensions
{
    public static CASH_CONCEPTSDto ToDto(this CASH_CONCEPTS entity)
    {
        if (entity == null) return null!;
        return new CASH_CONCEPTSDto
        {
            NCONCEPT = entity.NCONCEPT,
            TABLE22SDESCRIPT = entity.TABLE22?.SDESCRIPT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CASH_CONCEPTS ToEntity(this CreateCASH_CONCEPTSDto dto)
    {
        if (dto == null) return null!;
        return new CASH_CONCEPTS
        {
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CASH_CONCEPTS entity, UpdateCASH_CONCEPTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
