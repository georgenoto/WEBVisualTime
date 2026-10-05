using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_PCON;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_PCONMappingExtensions
{
    public static SCHE_PCONDto ToDto(this SCHE_PCON entity)
    {
        if (entity == null) return null!;
        return new SCHE_PCONDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            NCONCEPT = entity.NCONCEPT,
            TABLE293SDESCRIPT = entity.TABLE293?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static SCHE_PCON ToEntity(this CreateSCHE_PCONDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_PCON
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this SCHE_PCON entity, UpdateSCHE_PCONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
