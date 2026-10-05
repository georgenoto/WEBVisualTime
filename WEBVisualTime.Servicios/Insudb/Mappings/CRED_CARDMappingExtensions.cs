using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CRED_CARD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CRED_CARDMappingExtensions
{
    public static CRED_CARDDto ToDto(this CRED_CARD entity)
    {
        if (entity == null) return null!;
        return new CRED_CARDDto
        {
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            SCREDI_CARD = entity.SCREDI_CARD,
            NCARD_TYPE = entity.NCARD_TYPE,
            TABLE183SDESCRIPT = entity.TABLE183?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            DCARDEXPIR = entity.DCARDEXPIR,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            STYP_DIRDEB = entity.STYP_DIRDEB,
            NCURRENCY = entity.NCURRENCY,
        };
    }

    public static CRED_CARD ToEntity(this CreateCRED_CARDDto dto)
    {
        if (dto == null) return null!;
        return new CRED_CARD
        {
            NCARD_TYPE = dto.NCARD_TYPE,
            SSTATREGT = dto.SSTATREGT,
            DCARDEXPIR = dto.DCARDEXPIR,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            STYP_DIRDEB = dto.STYP_DIRDEB,
            NCURRENCY = dto.NCURRENCY,
        };
    }

    public static void UpdateEntity(this CRED_CARD entity, UpdateCRED_CARDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCARD_TYPE = dto.NCARD_TYPE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCARDEXPIR = dto.DCARDEXPIR;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.STYP_DIRDEB = dto.STYP_DIRDEB;
        entity.NCURRENCY = dto.NCURRENCY;
    }
}
