using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_DENTITIONMappingExtensions
{
    public static TAB_DENTITIONDto ToDto(this TAB_DENTITION entity)
    {
        if (entity == null) return null!;
        return new TAB_DENTITIONDto
        {
            NIDDENTITION = entity.NIDDENTITION,
            SADA = entity.SADA,
            SFDI = entity.SFDI,
            NTHETH = entity.NTHETH,
            NQUADRANT = entity.NQUADRANT,
            NARCADE = entity.NARCADE,
            STOOTHNAM = entity.STOOTHNAM,
            SPALATINE = entity.SPALATINE,
            SLINGUAL = entity.SLINGUAL,
            SVESTIBULAR = entity.SVESTIBULAR,
            SMESIAL = entity.SMESIAL,
            SDISTAL = entity.SDISTAL,
            SINCISAL = entity.SINCISAL,
            SOCLUSAL = entity.SOCLUSAL,
            SLABIAL = entity.SLABIAL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_DENTITION ToEntity(this CreateTAB_DENTITIONDto dto)
    {
        if (dto == null) return null!;
        return new TAB_DENTITION
        {
            SADA = dto.SADA,
            SFDI = dto.SFDI,
            NTHETH = dto.NTHETH,
            NQUADRANT = dto.NQUADRANT,
            NARCADE = dto.NARCADE,
            STOOTHNAM = dto.STOOTHNAM,
            SPALATINE = dto.SPALATINE,
            SLINGUAL = dto.SLINGUAL,
            SVESTIBULAR = dto.SVESTIBULAR,
            SMESIAL = dto.SMESIAL,
            SDISTAL = dto.SDISTAL,
            SINCISAL = dto.SINCISAL,
            SOCLUSAL = dto.SOCLUSAL,
            SLABIAL = dto.SLABIAL,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_DENTITION entity, UpdateTAB_DENTITIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SADA = dto.SADA;
        entity.SFDI = dto.SFDI;
        entity.NTHETH = dto.NTHETH;
        entity.NQUADRANT = dto.NQUADRANT;
        entity.NARCADE = dto.NARCADE;
        entity.STOOTHNAM = dto.STOOTHNAM;
        entity.SPALATINE = dto.SPALATINE;
        entity.SLINGUAL = dto.SLINGUAL;
        entity.SVESTIBULAR = dto.SVESTIBULAR;
        entity.SMESIAL = dto.SMESIAL;
        entity.SDISTAL = dto.SDISTAL;
        entity.SINCISAL = dto.SINCISAL;
        entity.SOCLUSAL = dto.SOCLUSAL;
        entity.SLABIAL = dto.SLABIAL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
