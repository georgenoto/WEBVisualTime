using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLDOCREQ;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ROLDOCREQMappingExtensions
{
    public static ROLDOCREQDto ToDto(this ROLDOCREQ entity)
    {
        if (entity == null) return null!;
        return new ROLDOCREQDto
        {
            NBRANCH = entity.NBRANCH,
            CLIALLOPRONBRANCHSDEFAULTI = entity.CLIALLOPRONBRANCH?.SDEFAULTI,
            NPRODUCT = entity.NPRODUCT,
            CLIALLOPRONPRODUCTSDEFAULTI = entity.CLIALLOPRONPRODUCT?.SDEFAULTI,
            SPOLITYPE = entity.SPOLITYPE,
            CLIALLOPROSPOLITYPESDEFAULTI = entity.CLIALLOPROSPOLITYPE?.SDEFAULTI,
            SCOMPON = entity.SCOMPON,
            CLIALLOPROSCOMPONSDEFAULTI = entity.CLIALLOPROSCOMPON?.SDEFAULTI,
            NROLE = entity.NROLE,
            CLIALLOPRONROLESDEFAULTI = entity.CLIALLOPRONROLE?.SDEFAULTI,
            NCLASSTYPDOC = entity.NCLASSTYPDOC,
            FORMATVALUESNCLASSTYPDOCSDESCRIPT = entity.FORMATVALUESNCLASSTYPDOC?.SDESCRIPT,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            FORMATVALUESNTYPCLIENTDOCSDESCRIPT = entity.FORMATVALUESNTYPCLIENTDOC?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static ROLDOCREQ ToEntity(this CreateROLDOCREQDto dto)
    {
        if (dto == null) return null!;
        return new ROLDOCREQ
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this ROLDOCREQ entity, UpdateROLDOCREQDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
