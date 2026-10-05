using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RNULLCONDI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RNULLCONDIMappingExtensions
{
    public static RNULLCONDIDto ToDto(this RNULLCONDI entity)
    {
        if (entity == null) return null!;
        return new RNULLCONDIDto
        {
            NNULLCODE = entity.NNULLCODE,
            TABLE95SDESCRIPT = entity.TABLE95?.SDESCRIPT,
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            SPOLITYPE = entity.SPOLITYPE,
            NTRATYPEI = entity.NTRATYPEI,
            SPOLICY = entity.SPOLICY,
            TABLE7505SPOLICYSDESCRIPT = entity.TABLE7505SPOLICY?.SDESCRIPT,
            SCERTIF = entity.SCERTIF,
            TABLE7505SCERTIFSDESCRIPT = entity.TABLE7505SCERTIF?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
        };
    }

    public static RNULLCONDI ToEntity(this CreateRNULLCONDIDto dto)
    {
        if (dto == null) return null!;
        return new RNULLCONDI
        {
            SPOLICY = dto.SPOLICY,
            SCERTIF = dto.SCERTIF,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
        };
    }

    public static void UpdateEntity(this RNULLCONDI entity, UpdateRNULLCONDIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPOLICY = dto.SPOLICY;
        entity.SCERTIF = dto.SCERTIF;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
    }
}
