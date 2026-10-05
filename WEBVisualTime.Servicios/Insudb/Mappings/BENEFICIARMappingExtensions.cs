using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFICIAR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BENEFICIARMappingExtensions
{
    public static BENEFICIARDto ToDto(this BENEFICIAR entity)
    {
        if (entity == null) return null!;
        return new BENEFICIARDto
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
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NPARTICIP = entity.NPARTICIP,
            NRELATION = entity.NRELATION,
            TABLE55SDESCRIPT = entity.TABLE55?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DDATEDECLA = entity.DDATEDECLA,
            SIRREVOC = entity.SIRREVOC,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SCONTING = entity.SCONTING,
            SSEND_MAIL = entity.SSEND_MAIL,
            SDESIGN = entity.SDESIGN,
        };
    }

    public static BENEFICIAR ToEntity(this CreateBENEFICIARDto dto)
    {
        if (dto == null) return null!;
        return new BENEFICIAR
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NPARTICIP = dto.NPARTICIP,
            NRELATION = dto.NRELATION,
            NUSERCODE = dto.NUSERCODE,
            DDATEDECLA = dto.DDATEDECLA,
            SIRREVOC = dto.SIRREVOC,
            SCONTING = dto.SCONTING,
            SSEND_MAIL = dto.SSEND_MAIL,
            SDESIGN = dto.SDESIGN,
        };
    }

    public static void UpdateEntity(this BENEFICIAR entity, UpdateBENEFICIARDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPARTICIP = dto.NPARTICIP;
        entity.NRELATION = dto.NRELATION;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DDATEDECLA = dto.DDATEDECLA;
        entity.SIRREVOC = dto.SIRREVOC;
        entity.SCONTING = dto.SCONTING;
        entity.SSEND_MAIL = dto.SSEND_MAIL;
        entity.SDESIGN = dto.SDESIGN;
    }
}
