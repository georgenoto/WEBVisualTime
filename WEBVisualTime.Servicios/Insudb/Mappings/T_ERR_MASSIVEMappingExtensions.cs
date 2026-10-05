using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_MASSIVE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_ERR_MASSIVEMappingExtensions
{
    public static T_ERR_MASSIVEDto ToDto(this T_ERR_MASSIVE entity)
    {
        if (entity == null) return null!;
        return new T_ERR_MASSIVEDto
        {
            SKEY = entity.SKEY,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NERROR = entity.NERROR,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SCERTYPE = entity.SCERTYPE,
            SCLIENT = entity.SCLIENT,
            NSEQ = entity.NSEQ,
            STYPE = entity.STYPE,
        };
    }

    public static T_ERR_MASSIVE ToEntity(this CreateT_ERR_MASSIVEDto dto)
    {
        if (dto == null) return null!;
        return new T_ERR_MASSIVE
        {
            SKEY = dto.SKEY,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NERROR = dto.NERROR,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SCERTYPE = dto.SCERTYPE,
            SCLIENT = dto.SCLIENT,
            NSEQ = dto.NSEQ,
            STYPE = dto.STYPE,
        };
    }

    public static void UpdateEntity(this T_ERR_MASSIVE entity, UpdateT_ERR_MASSIVEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NERROR = dto.NERROR;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NSEQ = dto.NSEQ;
        entity.STYPE = dto.STYPE;
    }
}
