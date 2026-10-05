using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_INTERFACE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_ERR_INTERFACEMappingExtensions
{
    public static T_ERR_INTERFACEDto ToDto(this T_ERR_INTERFACE entity)
    {
        if (entity == null) return null!;
        return new T_ERR_INTERFACEDto
        {
            SKEY = entity.SKEY,
            NSEQ = entity.NSEQ,
            NROW = entity.NROW,
            NERROR = entity.NERROR,
            SDESCRIPT = entity.SDESCRIPT,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            SCLIENT = entity.SCLIENT,
            NCLAIM = entity.NCLAIM,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static T_ERR_INTERFACE ToEntity(this CreateT_ERR_INTERFACEDto dto)
    {
        if (dto == null) return null!;
        return new T_ERR_INTERFACE
        {
            NERROR = dto.NERROR,
            SDESCRIPT = dto.SDESCRIPT,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            SCLIENT = dto.SCLIENT,
            NCLAIM = dto.NCLAIM,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this T_ERR_INTERFACE entity, UpdateT_ERR_INTERFACEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NERROR = dto.NERROR;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCLAIM = dto.NCLAIM;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
