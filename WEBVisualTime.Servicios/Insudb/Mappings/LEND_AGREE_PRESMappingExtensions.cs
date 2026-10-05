using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PRES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LEND_AGREE_PRESMappingExtensions
{
    public static LEND_AGREE_PRESDto ToDto(this LEND_AGREE_PRES entity)
    {
        if (entity == null) return null!;
        return new LEND_AGREE_PRESDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NGROUP = entity.NGROUP,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NPRESTAC = entity.NPRESTAC,
            NCOD_AGREE = entity.NCOD_AGREE,
            NCITY_RESIDENCE = entity.NCITY_RESIDENCE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NAMOUNT = entity.NAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static LEND_AGREE_PRES ToEntity(this CreateLEND_AGREE_PRESDto dto)
    {
        if (dto == null) return null!;
        return new LEND_AGREE_PRES
        {
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NAMOUNT = dto.NAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this LEND_AGREE_PRES entity, UpdateLEND_AGREE_PRESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
