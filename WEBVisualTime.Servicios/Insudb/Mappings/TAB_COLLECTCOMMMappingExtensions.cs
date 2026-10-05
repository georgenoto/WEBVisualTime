using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_COLLECTCOMMMappingExtensions
{
    public static TAB_COLLECTCOMMDto ToDto(this TAB_COLLECTCOMM entity)
    {
        if (entity == null) return null!;
        return new TAB_COLLECTCOMMDto
        {
            NCODE = entity.NCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TAB_COLLECTCOMM ToEntity(this CreateTAB_COLLECTCOMMDto dto)
    {
        if (dto == null) return null!;
        return new TAB_COLLECTCOMM
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TAB_COLLECTCOMM entity, UpdateTAB_COLLECTCOMMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
