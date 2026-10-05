using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DISEX_INT_MMappingExtensions
{
    public static DISEX_INT_MDto ToDto(this DISEX_INT_M entity)
    {
        if (entity == null) return null!;
        return new DISEX_INT_MDto
        {
            NECO_SCHE = entity.NECO_SCHE,
            SDESCRIPT = entity.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static DISEX_INT_M ToEntity(this CreateDISEX_INT_MDto dto)
    {
        if (dto == null) return null!;
        return new DISEX_INT_M
        {
            SDESCRIPT = dto.SDESCRIPT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this DISEX_INT_M entity, UpdateDISEX_INT_MDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
