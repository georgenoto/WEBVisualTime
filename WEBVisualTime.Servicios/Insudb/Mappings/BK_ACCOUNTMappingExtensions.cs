using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BK_ACCOUNT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BK_ACCOUNTMappingExtensions
{
    public static BK_ACCOUNTDto ToDto(this BK_ACCOUNT entity)
    {
        if (entity == null) return null!;
        return new BK_ACCOUNTDto
        {
            NBANKEXT = entity.NBANKEXT,
            SACCOUNT = entity.SACCOUNT,
            NTYP_ACC = entity.NTYP_ACC,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDEPOSIT = entity.SDEPOSIT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCURRENCY = entity.NCURRENCY,
        };
    }

    public static BK_ACCOUNT ToEntity(this CreateBK_ACCOUNTDto dto)
    {
        if (dto == null) return null!;
        return new BK_ACCOUNT
        {
            NTYP_ACC = dto.NTYP_ACC,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDEPOSIT = dto.SDEPOSIT,
            NCURRENCY = dto.NCURRENCY,
        };
    }

    public static void UpdateEntity(this BK_ACCOUNT entity, UpdateBK_ACCOUNTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYP_ACC = dto.NTYP_ACC;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDEPOSIT = dto.SDEPOSIT;
        entity.NCURRENCY = dto.NCURRENCY;
    }
}
