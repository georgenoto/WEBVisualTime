using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.UL_LEGAL_TERMS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class UL_LEGAL_TERMSMappingExtensions
{
    public static UL_LEGAL_TERMSDto ToDto(this UL_LEGAL_TERMS entity)
    {
        if (entity == null) return null!;
        return new UL_LEGAL_TERMSDto
        {
            NTYPE_SAAPV = entity.NTYPE_SAAPV,
            DEFFECDATE = entity.DEFFECDATE,
            NVALUESTY = entity.NVALUESTY,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NVALUESMO = entity.NVALUESMO,
            NDAYADD = entity.NDAYADD,
        };
    }

    public static UL_LEGAL_TERMS ToEntity(this CreateUL_LEGAL_TERMSDto dto)
    {
        if (dto == null) return null!;
        return new UL_LEGAL_TERMS
        {
            NVALUESTY = dto.NVALUESTY,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NVALUESMO = dto.NVALUESMO,
            NDAYADD = dto.NDAYADD,
        };
    }

    public static void UpdateEntity(this UL_LEGAL_TERMS entity, UpdateUL_LEGAL_TERMSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NVALUESTY = dto.NVALUESTY;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NVALUESMO = dto.NVALUESMO;
        entity.NDAYADD = dto.NDAYADD;
    }
}
