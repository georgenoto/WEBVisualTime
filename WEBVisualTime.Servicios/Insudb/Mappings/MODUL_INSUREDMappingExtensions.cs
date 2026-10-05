using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_INSURED;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MODUL_INSUREDMappingExtensions
{
    public static MODUL_INSUREDDto ToDto(this MODUL_INSURED entity)
    {
        if (entity == null) return null!;
        return new MODUL_INSUREDDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NGROUP_INSU = entity.NGROUP_INSU,
            NMODULEC = entity.NMODULEC,
            SCLIENT = entity.SCLIENT,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static MODUL_INSURED ToEntity(this CreateMODUL_INSUREDDto dto)
    {
        if (dto == null) return null!;
        return new MODUL_INSURED
        {
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this MODUL_INSURED entity, UpdateMODUL_INSUREDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
