using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_FILE_G;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WIN_FILE_GMappingExtensions
{
    public static WIN_FILE_GDto ToDto(this WIN_FILE_G entity)
    {
        if (entity == null) return null!;
        return new WIN_FILE_GDto
        {
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NBRANCH_GEN = entity.NBRANCH_GEN,
            TABLE634SDESCRIPT = entity.TABLE634?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            STABNAME = entity.STABNAME,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static WIN_FILE_G ToEntity(this CreateWIN_FILE_GDto dto)
    {
        if (dto == null) return null!;
        return new WIN_FILE_G
        {
            NBRANCH_GEN = dto.NBRANCH_GEN,
            DCOMPDATE = dto.DCOMPDATE,
            STABNAME = dto.STABNAME,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this WIN_FILE_G entity, UpdateWIN_FILE_GDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH_GEN = dto.NBRANCH_GEN;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.STABNAME = dto.STABNAME;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
