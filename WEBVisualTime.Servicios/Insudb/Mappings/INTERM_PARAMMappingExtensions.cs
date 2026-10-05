using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_PARAM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INTERM_PARAMMappingExtensions
{
    public static INTERM_PARAMDto ToDto(this INTERM_PARAM entity)
    {
        if (entity == null) return null!;
        return new INTERM_PARAMDto
        {
            NINSU_ASSIST = entity.NINSU_ASSIST,
            NSOAP_AGENT = entity.NSOAP_AGENT,
            NSOAP_SUPERVIS = entity.NSOAP_SUPERVIS,
            NBONUS_CURR = entity.NBONUS_CURR,
            NMAX_BONUS = entity.NMAX_BONUS,
            NMAX_ACCOMP = entity.NMAX_ACCOMP,
            NMINAMOUNT = entity.NMINAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NDAY_DISCLOAN = entity.NDAY_DISCLOAN,
        };
    }

    public static INTERM_PARAM ToEntity(this CreateINTERM_PARAMDto dto)
    {
        if (dto == null) return null!;
        return new INTERM_PARAM
        {
            NINSU_ASSIST = dto.NINSU_ASSIST,
            NSOAP_AGENT = dto.NSOAP_AGENT,
            NSOAP_SUPERVIS = dto.NSOAP_SUPERVIS,
            NBONUS_CURR = dto.NBONUS_CURR,
            NMAX_BONUS = dto.NMAX_BONUS,
            NMAX_ACCOMP = dto.NMAX_ACCOMP,
            NMINAMOUNT = dto.NMINAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NDAY_DISCLOAN = dto.NDAY_DISCLOAN,
        };
    }

    public static void UpdateEntity(this INTERM_PARAM entity, UpdateINTERM_PARAMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINSU_ASSIST = dto.NINSU_ASSIST;
        entity.NSOAP_AGENT = dto.NSOAP_AGENT;
        entity.NSOAP_SUPERVIS = dto.NSOAP_SUPERVIS;
        entity.NBONUS_CURR = dto.NBONUS_CURR;
        entity.NMAX_BONUS = dto.NMAX_BONUS;
        entity.NMAX_ACCOMP = dto.NMAX_ACCOMP;
        entity.NMINAMOUNT = dto.NMINAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NDAY_DISCLOAN = dto.NDAY_DISCLOAN;
    }
}
