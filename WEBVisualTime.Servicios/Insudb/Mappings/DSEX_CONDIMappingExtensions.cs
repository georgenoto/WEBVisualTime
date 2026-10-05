using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DSEX_CONDI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DSEX_CONDIMappingExtensions
{
    public static DSEX_CONDIDto ToDto(this DSEX_CONDI entity)
    {
        if (entity == null) return null!;
        return new DSEX_CONDIDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NDISEXPRC = entity.NDISEXPRC,
            NAPLICATION = entity.NAPLICATION,
            TABLE298SDESCRIPT = entity.TABLE298?.SDESCRIPT,
            NCODE = entity.NCODE,
            DCOMPDATE = entity.DCOMPDATE,
            DEFFECDATE = entity.DEFFECDATE,
            NMODULEC = entity.NMODULEC,
            DNULLDATE = entity.DNULLDATE,
            NROLE = entity.NROLE,
            NUSERCODE = entity.NUSERCODE,
            NRATE = entity.NRATE,
        };
    }

    public static DSEX_CONDI ToEntity(this CreateDSEX_CONDIDto dto)
    {
        if (dto == null) return null!;
        return new DSEX_CONDI
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            NRATE = dto.NRATE,
        };
    }

    public static void UpdateEntity(this DSEX_CONDI entity, UpdateDSEX_CONDIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NRATE = dto.NRATE;
    }
}
