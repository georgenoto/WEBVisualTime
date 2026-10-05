using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_BKACCOUNT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_BKACCOUNTMappingExtensions
{
    public static TAB_PROV_BKACCOUNTDto ToDto(this TAB_PROV_BKACCOUNT entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_BKACCOUNTDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            SACCOUNT = entity.SACCOUNT,
            NTYP_ACC = entity.NTYP_ACC,
            TABLE190SDESCRIPT = entity.TABLE190?.SDESCRIPT,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDEPOSIT = entity.SDEPOSIT,
            SCLIENTR = entity.SCLIENTR,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCURRENCY = entity.NCURRENCY,
        };
    }

    public static TAB_PROV_BKACCOUNT ToEntity(this CreateTAB_PROV_BKACCOUNTDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_BKACCOUNT
        {
            NTYP_ACC = dto.NTYP_ACC,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDEPOSIT = dto.SDEPOSIT,
            SCLIENTR = dto.SCLIENTR,
            NCURRENCY = dto.NCURRENCY,
        };
    }

    public static void UpdateEntity(this TAB_PROV_BKACCOUNT entity, UpdateTAB_PROV_BKACCOUNTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYP_ACC = dto.NTYP_ACC;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDEPOSIT = dto.SDEPOSIT;
        entity.SCLIENTR = dto.SCLIENTR;
        entity.NCURRENCY = dto.NCURRENCY;
    }
}
