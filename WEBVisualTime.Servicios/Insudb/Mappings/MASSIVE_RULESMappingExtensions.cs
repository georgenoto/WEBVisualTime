using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_RULES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASSIVE_RULESMappingExtensions
{
    public static MASSIVE_RULESDto ToDto(this MASSIVE_RULES entity)
    {
        if (entity == null) return null!;
        return new MASSIVE_RULESDto
        {
            NIDRULE = entity.NIDRULE,
            NERRORNUM = entity.NERRORNUM,
            SERRORTYP = entity.SERRORTYP,
            TABLE153SDESCRIPT = entity.TABLE153?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SBREAK = entity.SBREAK,
            SENABLED = entity.SENABLED,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NACTIONPROC = entity.NACTIONPROC,
            SVIP = entity.SVIP,
            STYP_CONDI = entity.STYP_CONDI,
            TABLE8204SDESCRIPT = entity.TABLE8204?.SDESCRIPT,
            NSECTION = entity.NSECTION,
            TABLE8205SDESCRIPT = entity.TABLE8205?.SDESCRIPT,
        };
    }

    public static MASSIVE_RULES ToEntity(this CreateMASSIVE_RULESDto dto)
    {
        if (dto == null) return null!;
        return new MASSIVE_RULES
        {
            NERRORNUM = dto.NERRORNUM,
            SERRORTYP = dto.SERRORTYP,
            SDESCRIPT = dto.SDESCRIPT,
            SBREAK = dto.SBREAK,
            SENABLED = dto.SENABLED,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NACTIONPROC = dto.NACTIONPROC,
            SVIP = dto.SVIP,
            STYP_CONDI = dto.STYP_CONDI,
            NSECTION = dto.NSECTION,
        };
    }

    public static void UpdateEntity(this MASSIVE_RULES entity, UpdateMASSIVE_RULESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NERRORNUM = dto.NERRORNUM;
        entity.SERRORTYP = dto.SERRORTYP;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SBREAK = dto.SBREAK;
        entity.SENABLED = dto.SENABLED;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NACTIONPROC = dto.NACTIONPROC;
        entity.SVIP = dto.SVIP;
        entity.STYP_CONDI = dto.STYP_CONDI;
        entity.NSECTION = dto.NSECTION;
    }
}
