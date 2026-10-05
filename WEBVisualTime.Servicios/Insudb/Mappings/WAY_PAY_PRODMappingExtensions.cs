using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WAY_PAY_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WAY_PAY_PRODMappingExtensions
{
    public static WAY_PAY_PRODDto ToDto(this WAY_PAY_PROD entity)
    {
        if (entity == null) return null!;
        return new WAY_PAY_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NRATE_EX = entity.NRATE_EX,
            NRATE_DISC = entity.NRATE_DISC,
            SPREM_FIRST = entity.SPREM_FIRST,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NNULL_DAY = entity.NNULL_DAY,
            SIND_PREISSU = entity.SIND_PREISSU,
            SIND_PREREF = entity.SIND_PREREF,
            SONERECEIPT = entity.SONERECEIPT,
            SLASTRECEIPT = entity.SLASTRECEIPT,
            SCOLLECTION = entity.SCOLLECTION,
            SIND_PREREFMAX = entity.SIND_PREREFMAX,
            SPRFIRST_EXPR = entity.SPRFIRST_EXPR,
            NTYPE_VALUECOLLECT = entity.NTYPE_VALUECOLLECT,
            TABLE8215SDESCRIPT = entity.TABLE8215?.SDESCRIPT,
        };
    }

    public static WAY_PAY_PROD ToEntity(this CreateWAY_PAY_PRODDto dto)
    {
        if (dto == null) return null!;
        return new WAY_PAY_PROD
        {
            NRATE_EX = dto.NRATE_EX,
            NRATE_DISC = dto.NRATE_DISC,
            SPREM_FIRST = dto.SPREM_FIRST,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NNULL_DAY = dto.NNULL_DAY,
            SIND_PREISSU = dto.SIND_PREISSU,
            SIND_PREREF = dto.SIND_PREREF,
            SONERECEIPT = dto.SONERECEIPT,
            SLASTRECEIPT = dto.SLASTRECEIPT,
            SCOLLECTION = dto.SCOLLECTION,
            SIND_PREREFMAX = dto.SIND_PREREFMAX,
            SPRFIRST_EXPR = dto.SPRFIRST_EXPR,
            NTYPE_VALUECOLLECT = dto.NTYPE_VALUECOLLECT,
        };
    }

    public static void UpdateEntity(this WAY_PAY_PROD entity, UpdateWAY_PAY_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NRATE_EX = dto.NRATE_EX;
        entity.NRATE_DISC = dto.NRATE_DISC;
        entity.SPREM_FIRST = dto.SPREM_FIRST;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NNULL_DAY = dto.NNULL_DAY;
        entity.SIND_PREISSU = dto.SIND_PREISSU;
        entity.SIND_PREREF = dto.SIND_PREREF;
        entity.SONERECEIPT = dto.SONERECEIPT;
        entity.SLASTRECEIPT = dto.SLASTRECEIPT;
        entity.SCOLLECTION = dto.SCOLLECTION;
        entity.SIND_PREREFMAX = dto.SIND_PREREFMAX;
        entity.SPRFIRST_EXPR = dto.SPRFIRST_EXPR;
        entity.NTYPE_VALUECOLLECT = dto.NTYPE_VALUECOLLECT;
    }
}
