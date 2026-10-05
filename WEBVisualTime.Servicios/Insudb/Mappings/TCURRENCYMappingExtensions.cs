using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCURRENCY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TCURRENCYMappingExtensions
{
    public static TCURRENCYDto ToDto(this TCURRENCY entity)
    {
        if (entity == null) return null!;
        return new TCURRENCYDto
        {
            SKEY = entity.SKEY,
            NCURRENCY = entity.NCURRENCY,
            NRECEIPT = entity.NRECEIPT,
            NSITUATION = entity.NSITUATION,
            NEXCHANGE = entity.NEXCHANGE,
            NPREMIUM = entity.NPREMIUM,
            NPREMIUM_N = entity.NPREMIUM_N,
            NCOMMISSION = entity.NCOMMISSION,
            NTAX = entity.NTAX,
            NCAPITAL = entity.NCAPITAL,
            NPREMIUM_A = entity.NPREMIUM_A,
            NPREMIUM_E = entity.NPREMIUM_E,
            NPREMIUMTEC = entity.NPREMIUMTEC,
        };
    }

    public static TCURRENCY ToEntity(this CreateTCURRENCYDto dto)
    {
        if (dto == null) return null!;
        return new TCURRENCY
        {
            SKEY = dto.SKEY,
            NCURRENCY = dto.NCURRENCY,
            NRECEIPT = dto.NRECEIPT,
            NSITUATION = dto.NSITUATION,
            NEXCHANGE = dto.NEXCHANGE,
            NPREMIUM = dto.NPREMIUM,
            NPREMIUM_N = dto.NPREMIUM_N,
            NCOMMISSION = dto.NCOMMISSION,
            NTAX = dto.NTAX,
            NCAPITAL = dto.NCAPITAL,
            NPREMIUM_A = dto.NPREMIUM_A,
            NPREMIUM_E = dto.NPREMIUM_E,
            NPREMIUMTEC = dto.NPREMIUMTEC,
        };
    }

    public static void UpdateEntity(this TCURRENCY entity, UpdateTCURRENCYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NSITUATION = dto.NSITUATION;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPREMIUM_N = dto.NPREMIUM_N;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.NTAX = dto.NTAX;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NPREMIUM_A = dto.NPREMIUM_A;
        entity.NPREMIUM_E = dto.NPREMIUM_E;
        entity.NPREMIUMTEC = dto.NPREMIUMTEC;
    }
}
