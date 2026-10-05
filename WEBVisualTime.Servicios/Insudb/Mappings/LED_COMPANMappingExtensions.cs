using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LED_COMPAN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LED_COMPANMappingExtensions
{
    public static LED_COMPANDto ToDto(this LED_COMPAN entity)
    {
        if (entity == null) return null!;
        return new LED_COMPANDto
        {
            NLED_COMPAN = entity.NLED_COMPAN,
            SACCOUNT_BG = entity.SACCOUNT_BG,
            SACCOUNT_GP = entity.SACCOUNT_GP,
            SBAL_ACTU = entity.SBAL_ACTU,
            SCLOSE_MONT = entity.SCLOSE_MONT,
            SSTATREGT = entity.SSTATREGT,
            SSTRUCT_UNI = entity.SSTRUCT_UNI,
            SSTRUCTURE = entity.SSTRUCTURE,
            DCOMPAN_DAT = entity.DCOMPAN_DAT,
            DCOMPDATE = entity.DCOMPDATE,
            DDATE_END = entity.DDATE_END,
            DDATE_INIT = entity.DDATE_INIT,
            NVOUCHER = entity.NVOUCHER,
            NCURRENCY = entity.NCURRENCY,
            NUSERCODE = entity.NUSERCODE,
            NYEAR = entity.NYEAR,
            DINILEDDAT = entity.DINILEDDAT,
            DENDLEDDAT = entity.DENDLEDDAT,
        };
    }

    public static LED_COMPAN ToEntity(this CreateLED_COMPANDto dto)
    {
        if (dto == null) return null!;
        return new LED_COMPAN
        {
            SACCOUNT_BG = dto.SACCOUNT_BG,
            SACCOUNT_GP = dto.SACCOUNT_GP,
            SBAL_ACTU = dto.SBAL_ACTU,
            SCLOSE_MONT = dto.SCLOSE_MONT,
            SSTATREGT = dto.SSTATREGT,
            SSTRUCT_UNI = dto.SSTRUCT_UNI,
            SSTRUCTURE = dto.SSTRUCTURE,
            DCOMPAN_DAT = dto.DCOMPAN_DAT,
            DCOMPDATE = dto.DCOMPDATE,
            DDATE_END = dto.DDATE_END,
            DDATE_INIT = dto.DDATE_INIT,
            NVOUCHER = dto.NVOUCHER,
            NCURRENCY = dto.NCURRENCY,
            NUSERCODE = dto.NUSERCODE,
            NYEAR = dto.NYEAR,
            DINILEDDAT = dto.DINILEDDAT,
            DENDLEDDAT = dto.DENDLEDDAT,
        };
    }

    public static void UpdateEntity(this LED_COMPAN entity, UpdateLED_COMPANDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACCOUNT_BG = dto.SACCOUNT_BG;
        entity.SACCOUNT_GP = dto.SACCOUNT_GP;
        entity.SBAL_ACTU = dto.SBAL_ACTU;
        entity.SCLOSE_MONT = dto.SCLOSE_MONT;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SSTRUCT_UNI = dto.SSTRUCT_UNI;
        entity.SSTRUCTURE = dto.SSTRUCTURE;
        entity.DCOMPAN_DAT = dto.DCOMPAN_DAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDATE_END = dto.DDATE_END;
        entity.DDATE_INIT = dto.DDATE_INIT;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR = dto.NYEAR;
        entity.DINILEDDAT = dto.DINILEDDAT;
        entity.DENDLEDDAT = dto.DENDLEDDAT;
    }
}
