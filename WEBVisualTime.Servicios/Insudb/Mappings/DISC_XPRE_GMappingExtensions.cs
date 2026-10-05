using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_G;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DISC_XPRE_GMappingExtensions
{
    public static DISC_XPRE_GDto ToDto(this DISC_XPRE_G entity)
    {
        if (entity == null) return null!;
        return new DISC_XPRE_GDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NGROUP = entity.NGROUP,
            NDISC_CODE = entity.NDISC_CODE,
            DEFFECDATE = entity.DEFFECDATE,
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            NPERCENT = entity.NPERCENT,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static DISC_XPRE_G ToEntity(this CreateDISC_XPRE_GDto dto)
    {
        if (dto == null) return null!;
        return new DISC_XPRE_G
        {
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            NPERCENT = dto.NPERCENT,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this DISC_XPRE_G entity, UpdateDISC_XPRE_GDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPERCENT = dto.NPERCENT;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
