using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTRMASTERMappingExtensions
{
    public static CONTRMASTERDto ToDto(this CONTRMASTER entity)
    {
        if (entity == null) return null!;
        return new CONTRMASTERDto
        {
            NTYPE_REL = entity.NTYPE_REL,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            TABLE173SDESCRIPT = entity.TABLE173?.SDESCRIPT,
            DSTARTDATE = entity.DSTARTDATE,
            NBRANCH = entity.NBRANCH,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NCURR_PAY = entity.NCURR_PAY,
            SFORMPAY = entity.SFORMPAY,
        };
    }

    public static CONTRMASTER ToEntity(this CreateCONTRMASTERDto dto)
    {
        if (dto == null) return null!;
        return new CONTRMASTER
        {
            DSTARTDATE = dto.DSTARTDATE,
            NCURRENCY = dto.NCURRENCY,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NCURR_PAY = dto.NCURR_PAY,
            SFORMPAY = dto.SFORMPAY,
        };
    }

    public static void UpdateEntity(this CONTRMASTER entity, UpdateCONTRMASTERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NCURR_PAY = dto.NCURR_PAY;
        entity.SFORMPAY = dto.SFORMPAY;
    }
}
