using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_FRE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REINSU_FREMappingExtensions
{
    public static REINSU_FREDto ToDto(this REINSU_FRE entity)
    {
        if (entity == null) return null!;
        return new REINSU_FREDto
        {
            SBUSSITYPE = entity.SBUSSITYPE,
            DEFFECDATE = entity.DEFFECDATE,
            NCOMPANY = entity.NCOMPANY,
            SFREE = entity.SFREE,
            NTYPE_REL = entity.NTYPE_REL,
            NNUMBER = entity.NNUMBER,
            DCOMPDATE = entity.DCOMPDATE,
            NTYPE = entity.NTYPE,
            NCLAIM_AM = entity.NCLAIM_AM,
            NYEAR_CONTR = entity.NYEAR_CONTR,
            NPREMIUM_AM = entity.NPREMIUM_AM,
            NBRANCH = entity.NBRANCH,
            NCURRENCY = entity.NCURRENCY,
            NTYPE_PER = entity.NTYPE_PER,
            TABLE97SDESCRIPT = entity.TABLE97?.SDESCRIPT,
            NPERIODY = entity.NPERIODY,
            NUSERCODE = entity.NUSERCODE,
            NYEAR = entity.NYEAR,
            NYEAR_SER = entity.NYEAR_SER,
        };
    }

    public static REINSU_FRE ToEntity(this CreateREINSU_FREDto dto)
    {
        if (dto == null) return null!;
        return new REINSU_FRE
        {
            SBUSSITYPE = dto.SBUSSITYPE,
            SFREE = dto.SFREE,
            DCOMPDATE = dto.DCOMPDATE,
            NCLAIM_AM = dto.NCLAIM_AM,
            NPREMIUM_AM = dto.NPREMIUM_AM,
            NUSERCODE = dto.NUSERCODE,
            NYEAR = dto.NYEAR,
            NYEAR_SER = dto.NYEAR_SER,
        };
    }

    public static void UpdateEntity(this REINSU_FRE entity, UpdateREINSU_FREDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SBUSSITYPE = dto.SBUSSITYPE;
        entity.SFREE = dto.SFREE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCLAIM_AM = dto.NCLAIM_AM;
        entity.NPREMIUM_AM = dto.NPREMIUM_AM;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR = dto.NYEAR;
        entity.NYEAR_SER = dto.NYEAR_SER;
    }
}
