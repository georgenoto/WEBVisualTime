using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMIS_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMIS_HISMappingExtensions
{
    public static COMMIS_HISDto ToDto(this COMMIS_HIS entity)
    {
        if (entity == null) return null!;
        return new COMMIS_HISDto
        {
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            STYP_COMISS = entity.STYP_COMISS,
            TABLE7504SDESCRIPT = entity.TABLE7504?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NCOMTAB = entity.NCOMTAB,
        };
    }

    public static COMMIS_HIS ToEntity(this CreateCOMMIS_HISDto dto)
    {
        if (dto == null) return null!;
        return new COMMIS_HIS
        {
            NCOMTAB = dto.NCOMTAB,
        };
    }

    public static void UpdateEntity(this COMMIS_HIS entity, UpdateCOMMIS_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCOMTAB = dto.NCOMTAB;
    }
}
